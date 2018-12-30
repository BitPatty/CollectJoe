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
    private readonly frmOptions _optionsForm;
    private readonly frmEditScore _editScoreForm;
    private readonly frmScoreList _scoreListForm;

    private readonly Random _random = new Random();
    private int _maxPlayTime = 39999;
    private int _currentPlayTime = 0;
    private readonly string _scoreListPath;

    private int _boxCountHorizontal;
    private int _boxCountVertical;

    private int _boxHeight;
    private int _boxWidth;

    private readonly int[] _gamePanelMargin = { 10, 10 };
    private Color _boxColor;

    private readonly List<Button> _boxList;
    private int _lastFlippedButtonIndex;

    private readonly Dictionary<Color, int> _boxRatings;
    private int _playerScore = 0;

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
      _optionsForm.ShowDialog();
    }

    public void SetOptions()
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
    }

    public void StopGame()
    {
      tmrGame.Stop();
      if (_playerScore <= 0)
      {
        ShowGameOverBox();
      }
      else
      {
        if (_playerScore > _scoreListForm.HighestScore)
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
    }

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
            Location = new Point(k * _boxWidth, i * _boxHeight),
            Text = "",
            BackColor = _boxColor,
          };

          btn.Click += BtnBox_Click;
          _boxList.Add(btn);
        }
      }

      pnlPlayField.Controls.AddRange(_boxList.ToArray());
    }

    private void ShowGameOverBox()
    {
      MessageBox.Show("Game Over!", "Game Over!", MessageBoxButtons.OK);
    }

    private void BtnHideOptions_Click(object sender, EventArgs e)
    {
      if (!((frmOptions)sender).Visible)
      {
        SetOptions();
        BuildButtonField();
      }
    }

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

    private void BtnStart_Click(object sender, EventArgs e)
    {
      tmrGame.Stop();
      _playerScore = 0;
      txtScore.Text = _playerScore.ToString();
      _currentPlayTime = 0;
      _boxList[_lastFlippedButtonIndex].BackColor = _boxColor;
      _lastFlippedButtonIndex = 0;
      _editScoreForm.ReSetNameAndScore();
      tmrGame.Start();
    }

    private void BtnScore_Click(object sender, EventArgs e)
    {
      _scoreListForm.ShowDialog();
    }

    private void BtnOptions_Click(object sender, EventArgs e)
    {
      _optionsForm.ShowDialog();
    }

    private void TmrGame_Tick(object sender, EventArgs e)
    {
      _currentPlayTime += tmrGame.Interval;

      if (_currentPlayTime > _maxPlayTime)
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
