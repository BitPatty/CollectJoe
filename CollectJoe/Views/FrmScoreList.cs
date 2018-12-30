using System;
using System.IO;
using System.Windows.Forms;

namespace CollectJoe.Views
{
  public partial class frmScoreList : Form
  {
    private readonly string _scoreListPath;

    public frmScoreList(string scoreListPath)
    {
      InitializeComponent();
      _scoreListPath = scoreListPath;
    }

    public void RefreshScore()
    {
      try
      {
        if (!string.IsNullOrWhiteSpace(_scoreListPath) && File.Exists(_scoreListPath))
        {
          string scoreList = File.ReadAllText(_scoreListPath);

          if (!string.IsNullOrWhiteSpace(scoreList))
          {
            txtScoreList.Text = scoreList;
            return;
          }
        }
      }
      catch (IOException) { }
      catch (ArgumentException) { }

      txtScoreList.Text = "Rangliste nicht verfügbar.";
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

    private void FrmScoreList_VisibleChanged(object sender, EventArgs e)
    {
      RefreshScore();
    }
  }
}
