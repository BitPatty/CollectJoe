using System;
using System.IO;
using System.Windows.Forms;

namespace CollectJoe.Views
{
  public partial class frmEditScore : Form
  {
    private readonly string _scoreListPath;

    /// <summary>
    /// Initialisiert ein neues <see cref="frmEditScore"/> Form
    /// mit dem angegebenen Pfad zur Ranglisten Datei
    /// </summary>
    /// <param name="scoreListPath">Der Pfad zur Ranglisten Datei</param>
    public frmEditScore(string scoreListPath)
    {
      InitializeComponent();
      _scoreListPath = scoreListPath;
    }

    /// <summary>
    /// Setzt den Punktestand
    /// </summary>
    /// <param name="score">Der Punktestand</param>
    public void SetScore(string score)
    {
      lblScore.Text = score;
    }

    /// <summary>
    /// Setzt den Punktestand und den Namen zurück
    /// </summary>
    public void ReSetNameAndScore()
    {
      lblScore.Text = String.Empty;
      txtName.Text = String.Empty;
    }

    /// <summary>
    /// Schreibt den Punktestand in die Rangliste, sofern der Name
    /// nicht leer ist. Ansonsten wird eine Fehlermeldung ausgegeben.
    /// </summary>
    /// <param name="sender">Der 'Speichern' Button</param>
    /// <param name="e">Die Event Argumente</param>
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
