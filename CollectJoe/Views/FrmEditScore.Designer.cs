namespace CollectJoe.Views
{
  partial class frmEditScore
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.lblEnter = new System.Windows.Forms.Label();
      this.lblScore = new System.Windows.Forms.Label();
      this.lblName = new System.Windows.Forms.Label();
      this.txtName = new System.Windows.Forms.TextBox();
      this.btnSave = new System.Windows.Forms.Button();
      this.btnCancel = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // lblEnter
      // 
      this.lblEnter.AutoSize = true;
      this.lblEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblEnter.Location = new System.Drawing.Point(9, 9);
      this.lblEnter.Name = "lblEnter";
      this.lblEnter.Size = new System.Drawing.Size(139, 31);
      this.lblEnter.TabIndex = 1;
      this.lblEnter.Text = "Eintragen";
      // 
      // lblScore
      // 
      this.lblScore.AutoSize = true;
      this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblScore.Location = new System.Drawing.Point(10, 50);
      this.lblScore.Name = "lblScore";
      this.lblScore.Size = new System.Drawing.Size(25, 26);
      this.lblScore.TabIndex = 2;
      this.lblScore.Text = "0";
      // 
      // lblName
      // 
      this.lblName.AutoSize = true;
      this.lblName.Location = new System.Drawing.Point(12, 86);
      this.lblName.Name = "lblName";
      this.lblName.Size = new System.Drawing.Size(61, 13);
      this.lblName.TabIndex = 3;
      this.lblName.Text = "dein Name:";
      // 
      // txtName
      // 
      this.txtName.Location = new System.Drawing.Point(88, 83);
      this.txtName.Name = "txtName";
      this.txtName.Size = new System.Drawing.Size(161, 20);
      this.txtName.TabIndex = 4;
      // 
      // btnSave
      // 
      this.btnSave.Location = new System.Drawing.Point(15, 125);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(114, 23);
      this.btnSave.TabIndex = 5;
      this.btnSave.Text = "Speichern";
      this.btnSave.UseVisualStyleBackColor = true;
      this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
      // 
      // btnCancel
      // 
      this.btnCancel.Location = new System.Drawing.Point(135, 125);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(114, 23);
      this.btnCancel.TabIndex = 5;
      this.btnCancel.Text = "Abbrechen";
      this.btnCancel.UseVisualStyleBackColor = true;
      this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
      // 
      // frmEditScore
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(273, 170);
      this.Controls.Add(this.btnCancel);
      this.Controls.Add(this.btnSave);
      this.Controls.Add(this.txtName);
      this.Controls.Add(this.lblName);
      this.Controls.Add(this.lblScore);
      this.Controls.Add(this.lblEnter);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "frmEditScore";
      this.Text = "Resultat Speichern";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmEditScore_FormClosing);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lblEnter;
    private System.Windows.Forms.Label lblScore;
    private System.Windows.Forms.Label lblName;
    private System.Windows.Forms.TextBox txtName;
    private System.Windows.Forms.Button btnSave;
    private System.Windows.Forms.Button btnCancel;
  }
}