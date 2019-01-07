using System;
using System.Drawing;
using System.Windows.Forms;

namespace CollectJoe.Views
{
  public partial class frmOptions : Form
  {
    public frmOptions()
    {
      InitializeComponent();
    }

    /// <summary>
    /// Retourniert die Anzahl horizontaler Boxen
    /// </summary>
    /// <returns>Retourniert die Anzahl horizontaler Boxen</returns>
    public int GetHorizontal()
    {
      if (nudHorizontal.Value > 20) return 20;
      if (nudHorizontal.Value < 1) return 10;
      if (nudHorizontal.Value <= 20 && nudHorizontal.Value >= 1) return (int)nudHorizontal.Value;
      return 20;
    }

    /// <summary>
    /// Retourniert die Anzahl vertikaler Boxen
    /// </summary>
    /// <returns>Retourniert die Anzahl vertikaler Boxen</returns>
    public int GetVertical()
    {
      if (nudVertical.Value > 10 || nudVertical.Value < 1) return 10;
      if (nudVertical.Value <= 10 && nudVertical.Value >= 1) return (int)nudVertical.Value;
      return 10;
    }

    /// <summary>
    /// Retourniert die (maximale) Spielzeit in Millisekunden
    /// </summary>
    /// <returns>Retourniert die (maximale) Spielzeit in Millisekunden</returns>
    public int GetMaxPlaytime()
    {
      return (int)nudMaxPlaytime.Value;
    }

    /// <summary>
    /// Retourniert die Wertung der angegebenen Box
    /// </summary>
    /// <param name="boxName">Der Name des NumericUpDown Feldes</param>
    /// <returns>Gibt die Wertung der Box zurück oder 1 wenn sie nicht gefunden wurde</returns>
    public int GetValue(string boxName)
    {
      switch (boxName)
      {
        case nameof(nudRatingBoxtype0): return (int)nudRatingBoxtype0.Value;
        case nameof(nudRatingBoxtype1): return (int)nudRatingBoxtype1.Value;
        case nameof(nudRatingBoxtype2): return (int)nudRatingBoxtype2.Value;
        default: return 1;
      }
    }

    /// <summary>
    /// Retourniert die Farbe der angegebenen Box
    /// </summary>
    /// <param name="boxName">Der Name des Button Feldes</param>
    /// <returns>Gibt die Farbe der Box zurück oder <see cref="Color.Black"/> wenn sie nicht gefunden wurde</returns>
    public Color GetColor(string boxName)
    {
      switch (boxName)
      {
        case nameof(btnColorBoxes): return btnColorBoxes.BackColor;
        case nameof(btnColorField): return btnColorField.BackColor;
        case nameof(btnColorBoxtype0): return btnColorBoxtype0.BackColor;
        case nameof(btnColorBoxtype1): return btnColorBoxtype1.BackColor;
        case nameof(btnColorBoxtype2): return btnColorBoxtype2.BackColor;
        default: return Color.Black;
      }
    }

    /// <summary>
    /// Überprüft ob alle Farben einmalig sind und gibt eine passende Fehlermeldung aus
    /// sollte dies nicht der Fall sein
    /// </summary>
    /// <returns>Gibt <see cref="true"/> zurück wenn die Überprüfung erfolgreich war</returns>
    private bool UniqueColorCheck()
    {
      if (btnColorBoxes.BackColor == btnColorField.BackColor) return ShowColorMatchError(lblColorBoxes.Text, lblColorField.Text);
      if (btnColorBoxes.BackColor == btnColorBoxtype0.BackColor) return ShowColorMatchError(lblColorBoxes.Text, lblColorBoxtype0.Text);
      if (btnColorBoxes.BackColor == btnColorBoxtype1.BackColor) return ShowColorMatchError(lblColorBoxes.Text, lblColorBoxtype1.Text);
      if (btnColorBoxes.BackColor == btnColorBoxtype2.BackColor) return ShowColorMatchError(lblColorBoxes.Text, lblColorBoxtype2.Text);
      if (btnColorField.BackColor == btnColorBoxtype0.BackColor) return ShowColorMatchError(lblColorField.Text, lblColorBoxtype0.Text);
      if (btnColorField.BackColor == btnColorBoxtype1.BackColor) return ShowColorMatchError(lblColorField.Text, lblColorBoxtype1.Text);
      if (btnColorField.BackColor == btnColorBoxtype2.BackColor) return ShowColorMatchError(lblColorField.Text, lblColorBoxtype2.Text);
      if (btnColorBoxtype0.BackColor == btnColorBoxtype1.BackColor) return ShowColorMatchError(lblColorBoxtype0.Text, lblColorBoxtype1.Text);
      if (btnColorBoxtype0.BackColor == btnColorBoxtype2.BackColor) return ShowColorMatchError(lblColorBoxtype0.Text, lblColorBoxtype2.Text);
      if (btnColorBoxtype1.BackColor == btnColorBoxtype2.BackColor) return ShowColorMatchError(lblColorBoxtype1.Text, lblColorBoxtype2.Text);
      return true;
    }

    /// <summary>
    /// Zeigt eine Fehlermeldung, wenn die Farben nicht einmalig sind.
    /// </summary>
    /// <param name="colorBox1">Beschreibung der ersten Box</param>
    /// <param name="colorBox2">Beschreibung der zweiten Box</param>
    /// <returns>Gibt 'false' zurück</returns>
    private bool ShowColorMatchError(string colorBox1, string colorBox2)
    {
      MessageBox.Show(String.Format("'{0}' hat die gleiche Farbe wie '{1}'", colorBox1, colorBox2), "Fehler", MessageBoxButtons.OK);
      return false;
    }

    /// <summary>
    /// Zeigt einen <see cref="ColorDialog"/> um die Farbe anzupassen und
    /// übernimmt sie falls notwendig
    /// </summary>
    /// <param name="sender">Der Farb-Button</param>
    /// <param name="e">Die Event Argumente</param>
    private void BtnColor_Click(object sender, EventArgs e)
    {
      clrDialog.Color = ((Button)sender).BackColor;
      if (clrDialog.ShowDialog() == DialogResult.OK) ((Button)sender).BackColor = clrDialog.Color;
    }

    /// <summary>
    /// Überprüft ob alle Farben einmalig sind und versteckt das Fenster
    /// wenn die Überprüfung erfolgreich ist
    /// </summary>
    /// <param name="sender">Der 'Übernehmen' Button</param>
    /// <param name="e">Die Event Argumente</param>
    private void BtnUse_Click(object sender, EventArgs e)
    {
      if (UniqueColorCheck()) Hide();
    }

    /// <summary>
    /// Überprüft ob alle Farben einmalig sind und versteckt das Fenster
    /// wenn die Überprüfung erfolgreich ist
    /// </summary>
    /// <param name="sender">Der 'X' Button</param>
    /// <param name="e">Die Event Argumente</param>
    private void FrmOptions_FormClosing(object sender, FormClosingEventArgs e)
    {
      e.Cancel = true;
      if (UniqueColorCheck()) Hide();
    }
  }
}
