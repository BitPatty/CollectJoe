using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace CollectJoe.Views
{
  public partial class frmScoreList : Form
  {
    private readonly string _scoreListPath;

    public int HighestScore { get; private set; }

    public frmScoreList(string scoreListPath)
    {
      InitializeComponent();
      _scoreListPath = scoreListPath;
      RefreshScore();
    }

    public void RefreshScore()
    {
      txtScoreList.ResetText();

      string[] scoreList = GetScoreFileContent();
      if (scoreList != null) PopulateScoreList(scoreList);
      else txtScoreList.Text = "Rangliste nicht verfügbar.";
    }

    private void PopulateScoreList(string[] scoreList)
    {
      List<Tuple<string, int>> scores = new List<Tuple<string, int>>();

      foreach (string entry in scoreList)
      {
        if (!String.IsNullOrWhiteSpace(entry))
        {
          string name = entry.Trim().Split(';')[0];
          int score = Int32.Parse(entry.Trim().Split(';')[1]);
          scores.Add(new Tuple<string, int>(name, score));
        }
      }

      scores.Sort((s1, s2) => s2.Item2.CompareTo(s1.Item2));
      HighestScore = scores[0].Item2;

      foreach (Tuple<string, int> entry in scores)
        txtScoreList.AppendText(string.Format("{0};{1}\r\n", entry.Item1, entry.Item2));
    }

    private string[] GetScoreFileContent()
    {
      try
      {
        if (!string.IsNullOrWhiteSpace(_scoreListPath) && File.Exists(_scoreListPath))
          return File.ReadAllLines(_scoreListPath);
      }
      catch (IOException) { }
      catch (ArgumentException) { }

      return null;
    }

    private void BtnClose_Click(object sender, EventArgs e)
    {
      Hide();
    }

    private void FrmScoreList_Closing(object sender, FormClosingEventArgs e)
    {
      e.Cancel = true;
      Hide();
    }
  }
}
