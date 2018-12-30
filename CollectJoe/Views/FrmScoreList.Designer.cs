namespace CollectJoe.Views
{
  partial class frmScoreList
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
      this.lblScoreList = new System.Windows.Forms.Label();
      this.txtScoreList = new System.Windows.Forms.TextBox();
      this.btnClose = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // lblScoreList
      // 
      this.lblScoreList.AutoSize = true;
      this.lblScoreList.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblScoreList.Location = new System.Drawing.Point(7, 9);
      this.lblScoreList.Name = "lblScoreList";
      this.lblScoreList.Size = new System.Drawing.Size(137, 31);
      this.lblScoreList.TabIndex = 1;
      this.lblScoreList.Text = "Rangliste";
      // 
      // txtScoreList
      // 
      this.txtScoreList.Location = new System.Drawing.Point(13, 55);
      this.txtScoreList.Multiline = true;
      this.txtScoreList.Name = "txtScoreList";
      this.txtScoreList.ReadOnly = true;
      this.txtScoreList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.txtScoreList.Size = new System.Drawing.Size(219, 240);
      this.txtScoreList.TabIndex = 2;
      // 
      // btnClose
      // 
      this.btnClose.Location = new System.Drawing.Point(13, 301);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new System.Drawing.Size(114, 23);
      this.btnClose.TabIndex = 3;
      this.btnClose.Text = "Schliessen";
      this.btnClose.UseVisualStyleBackColor = true;
      this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
      // 
      // frmScoreList
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(249, 336);
      this.Controls.Add(this.btnClose);
      this.Controls.Add(this.txtScoreList);
      this.Controls.Add(this.lblScoreList);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "frmScoreList";
      this.Text = "Rangliste";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmScoreList_Closing);
      this.VisibleChanged += new System.EventHandler(this.FrmScoreList_VisibleChanged);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lblScoreList;
    private System.Windows.Forms.TextBox txtScoreList;
    private System.Windows.Forms.Button btnClose;
  }
}