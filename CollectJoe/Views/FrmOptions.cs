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

    public int GetHorizontal()
    {
      if (nudHorizontal.Value > 20) return 20;
      if (nudHorizontal.Value < 1) return 10;
      if (nudHorizontal.Value <= 20 && nudHorizontal.Value >= 1) return (int)nudHorizontal.Value;
      return 20;
    }

    public int GetVertical()
    {
      if (nudVertical.Value > 10 || nudVertical.Value < 1) return 10;
      if (nudVertical.Value <= 10 && nudVertical.Value >= 1) return (int)nudVertical.Value;
      return 10;
    }

    public int GetMaxPlaytime()
    {
      return (int)nudMaxPlaytime.Value * 1000;
    }

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

    private bool ShowColorMatchError(string color1, string color2)
    {
      MessageBox.Show(String.Format("'{0}' hat die gleiche Farbe wie '{1}'", color1, color2), "Fehler", MessageBoxButtons.OK);
      return false;
    }

    private void BtnColor_Click(object sender, EventArgs e)
    {
      clrDialog.Color = ((Button)sender).BackColor;
      if (clrDialog.ShowDialog() == DialogResult.OK) ((Button)sender).BackColor = clrDialog.Color;
    }

    private void BtnUse_Click(object sender, EventArgs e)
    {
      if (UniqueColorCheck()) Hide();
    }

    private void FrmOptions_FormClosing(object sender, FormClosingEventArgs e)
    {
      e.Cancel = true;
      if (UniqueColorCheck()) Hide();
    }
  }
}
