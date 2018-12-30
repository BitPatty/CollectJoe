using System;
using System.IO;
using System.Windows.Forms;

namespace CollectJoe.Views
{
  public partial class frmEditScore : Form
  {
    private readonly string _scoreListPath;

    public frmEditScore(string scoreListPath)
    {
      InitializeComponent();
      _scoreListPath = scoreListPath;
    }

    public void SetScore(string score)
    {
      lblScore.Text = score;
    }

    public void ReSetNameAndScore()
    {
      lblScore.Text = String.Empty;
      txtName.Text = String.Empty;
    }

    private void BtnSave_Click(object sender, EventArgs e)
    {
      if (String.IsNullOrWhiteSpace(txtName.Text))
      {
        MessageBox.Show("Bitte geben Sie ihren Namen ein.", "Keinen Namen eingegeben", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }
      else
      {
        File.AppendAllLines(_scoreListPath, new string[] { String.Format("{0};{1}", txtName.Text, lblScore.Text) });
        Hide();
      }
    }

    private void BtnCancel_Click(object sender, EventArgs e)
    {
      Hide();
    }

    private void FrmEditScore_FormClosing(object sender, FormClosingEventArgs e)
    {
      e.Cancel = true;
      Hide();
    }
  }
}
