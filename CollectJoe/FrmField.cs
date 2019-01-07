using CollectJoe.Views;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Windows.Forms;

namespace CollectJoe
{
  public partial class frmField : Form
  {
    private readonly frmOptions _optionsForm;            //Attribut-ID 1
    private readonly frmEditScore _editScoreForm;        //Attribut-ID 2
    private readonly frmScoreList _scoreListForm;        //Attribut-ID 3

    private readonly Random _random = new Random();      //Attribut-ID 4
    private int _maxPlayTime;                            //Attribut-ID 5
    private int _currentPlayTime;                        //Attribut-ID 6
    private readonly string _scoreListPath;              //Attribut-ID 7

    private int _boxCountHorizontal;                     //Attribut-ID 8
    private int _boxCountVertical;                       //Attribut-ID 9

    private int _boxHeight;                              //Attribut-ID 10
    private int _boxWidth;                               //Attribut-ID 11

    private Color _boxColor;                             //Attribut-ID 12

    private readonly List<Button> _boxList;              //Attribut-ID 13
    private int _lastFlippedButtonIndex;                 //Attribut-ID 14

    private readonly Dictionary<Color, int> _boxRatings; //Attribut-ID 15
    private readonly int[] _gamePanelMargin = { 10, 10 }; //Attribut-ID 16

    private int _playerScore = 0;                        //Zusätliches Attribut

    public frmField()
    {
      InitializeComponent();

      _scoreListPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "scorelist.txt");

      _optionsForm = new frmOptions();
      _editScoreForm = new frmEditScore(_scoreListPath);
      _scoreListForm = new frmScoreList(_scoreListPath);

      _boxList = new List<Button>();
      _boxRatings = new Dictionary<Color, int>();

      _scoreListForm.RefreshScore();

      _optionsForm.VisibleChanged += BtnHideOptions_Click;
      SetupPlayField();
    }

    /// <summary>
    /// Übernimmt die Optionen aus dem <see cref="frmOptions"/> Form und baut das Spielfeld auf
    /// </summary>
    public void SetupPlayField()
    {
      pnlPlayField.BackColor = _optionsForm.GetColor("btnColorField");
      _boxColor = _optionsForm.GetColor("btnColorBoxes");
      _maxPlayTime = _optionsForm.GetMaxPlaytime();

      _boxCountHorizontal = _optionsForm.GetHorizontal();
      _boxCountVertical = _optionsForm.GetVertical();

      _boxWidth = (pnlPlayField.Width - (_gamePanelMargin[0] * 2)) / _boxCountHorizontal;
      _boxHeight = (pnlPlayField.Height - (_gamePanelMargin[1] * 2)) / _boxCountVertical;

      _boxRatings.Clear();

      for (int i = 0; i < 3; i++)
      {
        Color color = _optionsForm.GetColor("btnColorBoxtype" + i);
        int rating = _optionsForm.GetValue("nudRatingBoxtype" + i);
        _boxRatings.Add(color, rating);
      }

      BuildButtonField();
    }

    /// <summary>
    /// Stopped das Game und gibt bei negativem Punktestand
    /// 'Game Over!' aus. Bei positivem Punktestand wird
    /// eine Fanfare abgespielt und das Formular zur Eintragung
    /// geöffnet.
    /// </summary>
    public void StopGame()
    {
      tmrGame.Stop();
      if (_playerScore < 0)
      {
        ShowGameOverBox();
      }
      else
      {
        if (_playerScore > _scoreListForm.GetCurrentHighScore())
        {
          using (SoundPlayer sp = new SoundPlayer(Properties.Resources.trumpet))
          {
            sp.Play();
          }
        }

        _editScoreForm.SetScore(txtScore.Text);
        _editScoreForm.ShowDialog();
        _scoreListForm.RefreshScore();
      }

      _boxList[_lastFlippedButtonIndex].BackColor = _boxColor;
    }

    /// <summary>
    /// Baut das Spielfeld gemäss aktueller Konfiguration auf
    /// </summary>
    public void BuildButtonField()
    {
      pnlPlayField.Controls.Clear();
      _boxList.Clear();

      for (int i = 0; i < _boxCountVertical; i++)
      {
        for (int k = 0; k < _boxCountHorizontal; k++)
        {
          Button btn = new Button()
          {
            Name = String.Format("btn_{0}", (i * _boxCountHorizontal) + k),
            Height = _boxHeight,
            Width = _boxWidth,
            Location = new Point((k * _boxWidth) + _gamePanelMargin[0], (i * _boxHeight) + _gamePanelMargin[1]),
            Text = "",
            BackColor = _boxColor,
          };

          btn.Click += BtnBox_Click;
          _boxList.Add(btn);
        }
      }

      pnlPlayField.Controls.AddRange(_boxList.ToArray());
    }

    /// <summary>
    /// Zeigt eine Box mit 'Game Over!'
    /// </summary>
    private void ShowGameOverBox()
    {
      MessageBox.Show("Game Over!", "Game Over!", MessageBoxButtons.OK);
    }

    /// <summary>
    /// Übernimmt die neuen Optionen und setzt das Feld neu auf
    /// </summary>
    /// <param name="sender">Ein <see cref="frmOptions"/> Form</param>
    /// <param name="e">Die Event Argumente</param>
    private void BtnHideOptions_Click(object sender, EventArgs e)
    {
      if (!((frmOptions)sender).Visible) SetupPlayField();
    }

    /// <summary>
    /// Addiert die Punkte sofern die angeklickte Box aufgedeckt ist.
    /// </summary>
    /// <param name="sender">Eine Box im Spielfeld</param>
    /// <param name="e">Die Event Argumente</param>
    private void BtnBox_Click(object sender, EventArgs e)
    {
      Button btn = (Button)sender;
      if (_boxRatings.ContainsKey(btn.BackColor))
      {
        _playerScore += _boxRatings[btn.BackColor];
        txtScore.Text = _playerScore.ToString();
        if (_playerScore < 0) StopGame();
      }
    }

    /// <summary>
    /// Setzt das Spiel zurück und startet es neu
    /// </summary>
    /// <param name="sender">Der Start Button</param>
    /// <param name="e">Die Event Argumente</param>
    private void BtnStart_Click(object sender, EventArgs e)
    {
      if (tmrGame.Enabled) tmrGame.Stop();
      _playerScore = 0;
      txtScore.Text = _playerScore.ToString();
      _currentPlayTime = 0;
      _boxList[_lastFlippedButtonIndex].BackColor = _boxColor;
      _lastFlippedButtonIndex = 0;
      _editScoreForm.ReSetNameAndScore();
      tmrGame.Start();
    }

    /// <summary>
    /// Zeigt das <see cref="frmScoreList"/> Form
    /// </summary>
    /// <param name="sender">Der 'Rangliste anzeigen' Button</param>
    /// <param name="e">Die Event Argumente</param>
    private void BtnScore_Click(object sender, EventArgs e)
    {
      if (tmrGame.Enabled) tmrGame.Stop();
      _scoreListForm.ShowDialog();
    }

    /// <summary>
    /// Zeigt das <see cref="frmOptions"/> Form
    /// </summary>
    /// <param name="sender">Der 'Einstellungen' Button</param>
    /// <param name="e">Die Event Argumente</param>
    private void BtnOptions_Click(object sender, EventArgs e)
    {
      if (tmrGame.Enabled) tmrGame.Stop();
      _optionsForm.ShowDialog();
    }

    /// <summary>
    /// Deckt die aktive Box zu und eine neue auf. Bei übertritt
    /// der maximalen Spielzeit wird das Spiel beendet.
    /// </summary>
    /// <param name="sender">Der Game Timer</param>
    /// <param name="e">Die Event Argumente</param>
    private void TmrGame_Tick(object sender, EventArgs e)
    {
      _currentPlayTime += tmrGame.Interval;

      if (_currentPlayTime >= _maxPlayTime)
      {
        StopGame();
      }
      else
      {
        _boxList[_lastFlippedButtonIndex].BackColor = _boxColor;
        _lastFlippedButtonIndex = _random.Next(0, _boxList.Count);
        _boxList[_lastFlippedButtonIndex].BackColor = _boxRatings.Keys.ElementAt(_random.Next(0, _boxRatings.Keys.Count));
      }
    }
  }
}
