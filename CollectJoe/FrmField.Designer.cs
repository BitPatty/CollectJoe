namespace CollectJoe
{
  partial class frmField
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
      this.components = new System.ComponentModel.Container();
      this.pnlPlayField = new System.Windows.Forms.Panel();
      this.btnStart = new System.Windows.Forms.Button();
      this.lblScore = new System.Windows.Forms.Label();
      this.txtScore = new System.Windows.Forms.TextBox();
      this.btnOptions = new System.Windows.Forms.Button();
      this.btnScore = new System.Windows.Forms.Button();
      this.tmrGame = new System.Windows.Forms.Timer(this.components);
      this.SuspendLayout();
      // 
      // pnlPlayField
      // 
      this.pnlPlayField.Location = new System.Drawing.Point(12, 12);
      this.pnlPlayField.Name = "pnlPlayField";
      this.pnlPlayField.Size = new System.Drawing.Size(960, 486);
      this.pnlPlayField.TabIndex = 0;
      // 
      // btnStart
      // 
      this.btnStart.Location = new System.Drawing.Point(12, 504);
      this.btnStart.Name = "btnStart";
      this.btnStart.Size = new System.Drawing.Size(114, 23);
      this.btnStart.TabIndex = 1;
      this.btnStart.Text = "Spiel Starten";
      this.btnStart.UseVisualStyleBackColor = true;
      this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
      // 
      // lblScore
      // 
      this.lblScore.AutoSize = true;
      this.lblScore.Location = new System.Drawing.Point(167, 507);
      this.lblScore.Name = "lblScore";
      this.lblScore.Size = new System.Drawing.Size(67, 13);
      this.lblScore.TabIndex = 2;
      this.lblScore.Text = "Punktestand";
      // 
      // txtScore
      // 
      this.txtScore.Enabled = false;
      this.txtScore.Location = new System.Drawing.Point(240, 504);
      this.txtScore.Name = "txtScore";
      this.txtScore.Size = new System.Drawing.Size(100, 20);
      this.txtScore.TabIndex = 3;
      // 
      // btnOptions
      // 
      this.btnOptions.Location = new System.Drawing.Point(857, 504);
      this.btnOptions.Name = "btnOptions";
      this.btnOptions.Size = new System.Drawing.Size(114, 23);
      this.btnOptions.TabIndex = 1;
      this.btnOptions.Text = "Einstellungen";
      this.btnOptions.UseVisualStyleBackColor = true;
      this.btnOptions.Click += new System.EventHandler(this.BtnOptions_Click);
      // 
      // btnScore
      // 
      this.btnScore.Location = new System.Drawing.Point(737, 504);
      this.btnScore.Name = "btnScore";
      this.btnScore.Size = new System.Drawing.Size(114, 23);
      this.btnScore.TabIndex = 1;
      this.btnScore.Text = "Rangliste anzeigen";
      this.btnScore.UseVisualStyleBackColor = true;
      this.btnScore.Click += new System.EventHandler(this.BtnScore_Click);
      // 
      // tmrGame
      // 
      this.tmrGame.Interval = 1000;
      this.tmrGame.Tick += new System.EventHandler(this.TmrGame_Tick);
      // 
      // frmField
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(983, 557);
      this.Controls.Add(this.txtScore);
      this.Controls.Add(this.lblScore);
      this.Controls.Add(this.btnScore);
      this.Controls.Add(this.btnOptions);
      this.Controls.Add(this.btnStart);
      this.Controls.Add(this.pnlPlayField);
      this.Name = "frmField";
      this.Text = "CollectJoe";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Panel pnlPlayField;
    private System.Windows.Forms.Button btnStart;
    private System.Windows.Forms.Label lblScore;
    private System.Windows.Forms.TextBox txtScore;
    private System.Windows.Forms.Button btnOptions;
    private System.Windows.Forms.Button btnScore;
    private System.Windows.Forms.Timer tmrGame;
  }
}

