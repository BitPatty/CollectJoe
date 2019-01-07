namespace CollectJoe.Views
{
  partial class frmOptions
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
      this.lblSettings = new System.Windows.Forms.Label();
      this.gpxPlayField = new System.Windows.Forms.GroupBox();
      this.nudVertical = new System.Windows.Forms.NumericUpDown();
      this.nudHorizontal = new System.Windows.Forms.NumericUpDown();
      this.lblVertical = new System.Windows.Forms.Label();
      this.lblHorizontal = new System.Windows.Forms.Label();
      this.lblPlayField = new System.Windows.Forms.Label();
      this.gpxRatings = new System.Windows.Forms.GroupBox();
      this.nudRatingBoxtype2 = new System.Windows.Forms.NumericUpDown();
      this.nudRatingBoxtype1 = new System.Windows.Forms.NumericUpDown();
      this.nudRatingBoxtype0 = new System.Windows.Forms.NumericUpDown();
      this.lblRatingBoxtype2 = new System.Windows.Forms.Label();
      this.lblRatingBoxtype1 = new System.Windows.Forms.Label();
      this.lblRatingBoxtype0 = new System.Windows.Forms.Label();
      this.lblRatings = new System.Windows.Forms.Label();
      this.gpxColors = new System.Windows.Forms.GroupBox();
      this.btnColorBoxtype0 = new System.Windows.Forms.Button();
      this.btnColorBoxes = new System.Windows.Forms.Button();
      this.btnColorBoxtype2 = new System.Windows.Forms.Button();
      this.btnColorBoxtype1 = new System.Windows.Forms.Button();
      this.btnColorField = new System.Windows.Forms.Button();
      this.lblColorBoxtype2 = new System.Windows.Forms.Label();
      this.lblColorBoxtype1 = new System.Windows.Forms.Label();
      this.lblColorField = new System.Windows.Forms.Label();
      this.lblColorBoxtype0 = new System.Windows.Forms.Label();
      this.lblColorBoxes = new System.Windows.Forms.Label();
      this.lblColors = new System.Windows.Forms.Label();
      this.btnUse = new System.Windows.Forms.Button();
      this.clrDialog = new System.Windows.Forms.ColorDialog();
      this.groupBox3 = new System.Windows.Forms.GroupBox();
      this.nudMaxPlaytime = new System.Windows.Forms.NumericUpDown();
      this.lblMaxPlaytime = new System.Windows.Forms.Label();
      this.lblGame = new System.Windows.Forms.Label();
      this.gpxPlayField.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.nudVertical)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.nudHorizontal)).BeginInit();
      this.gpxRatings.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.nudRatingBoxtype2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.nudRatingBoxtype1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.nudRatingBoxtype0)).BeginInit();
      this.gpxColors.SuspendLayout();
      this.groupBox3.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.nudMaxPlaytime)).BeginInit();
      this.SuspendLayout();
      // 
      // lblSettings
      // 
      this.lblSettings.AutoSize = true;
      this.lblSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblSettings.Location = new System.Drawing.Point(6, 13);
      this.lblSettings.Name = "lblSettings";
      this.lblSettings.Size = new System.Drawing.Size(190, 31);
      this.lblSettings.TabIndex = 100;
      this.lblSettings.Text = "Einstellungen";
      // 
      // gpxPlayField
      // 
      this.gpxPlayField.Controls.Add(this.nudVertical);
      this.gpxPlayField.Controls.Add(this.nudHorizontal);
      this.gpxPlayField.Controls.Add(this.lblVertical);
      this.gpxPlayField.Controls.Add(this.lblHorizontal);
      this.gpxPlayField.Controls.Add(this.lblPlayField);
      this.gpxPlayField.Location = new System.Drawing.Point(12, 62);
      this.gpxPlayField.Name = "gpxPlayField";
      this.gpxPlayField.Size = new System.Drawing.Size(256, 122);
      this.gpxPlayField.TabIndex = 1;
      this.gpxPlayField.TabStop = false;
      // 
      // nudVertical
      // 
      this.nudVertical.Location = new System.Drawing.Point(119, 83);
      this.nudVertical.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
      this.nudVertical.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.nudVertical.Name = "nudVertical";
      this.nudVertical.Size = new System.Drawing.Size(120, 20);
      this.nudVertical.TabIndex = 2;
      this.nudVertical.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
      // 
      // nudHorizontal
      // 
      this.nudHorizontal.Location = new System.Drawing.Point(119, 55);
      this.nudHorizontal.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
      this.nudHorizontal.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.nudHorizontal.Name = "nudHorizontal";
      this.nudHorizontal.Size = new System.Drawing.Size(120, 20);
      this.nudHorizontal.TabIndex = 1;
      this.nudHorizontal.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
      // 
      // lblVertical
      // 
      this.lblVertical.AutoSize = true;
      this.lblVertical.Location = new System.Drawing.Point(10, 85);
      this.lblVertical.Name = "lblVertical";
      this.lblVertical.Size = new System.Drawing.Size(74, 13);
      this.lblVertical.TabIndex = 100;
      this.lblVertical.Text = "Boxen vertikal";
      // 
      // lblHorizontal
      // 
      this.lblHorizontal.AutoSize = true;
      this.lblHorizontal.Location = new System.Drawing.Point(10, 57);
      this.lblHorizontal.Name = "lblHorizontal";
      this.lblHorizontal.Size = new System.Drawing.Size(85, 13);
      this.lblHorizontal.TabIndex = 100;
      this.lblHorizontal.Text = "Boxen horizontal";
      // 
      // lblPlayField
      // 
      this.lblPlayField.AutoSize = true;
      this.lblPlayField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblPlayField.Location = new System.Drawing.Point(6, 16);
      this.lblPlayField.Name = "lblPlayField";
      this.lblPlayField.Size = new System.Drawing.Size(91, 24);
      this.lblPlayField.TabIndex = 100;
      this.lblPlayField.Text = "Spielfeld";
      // 
      // gpxRatings
      // 
      this.gpxRatings.Controls.Add(this.nudRatingBoxtype2);
      this.gpxRatings.Controls.Add(this.nudRatingBoxtype1);
      this.gpxRatings.Controls.Add(this.nudRatingBoxtype0);
      this.gpxRatings.Controls.Add(this.lblRatingBoxtype2);
      this.gpxRatings.Controls.Add(this.lblRatingBoxtype1);
      this.gpxRatings.Controls.Add(this.lblRatingBoxtype0);
      this.gpxRatings.Controls.Add(this.lblRatings);
      this.gpxRatings.Location = new System.Drawing.Point(12, 190);
      this.gpxRatings.Name = "gpxRatings";
      this.gpxRatings.Size = new System.Drawing.Size(256, 150);
      this.gpxRatings.TabIndex = 2;
      this.gpxRatings.TabStop = false;
      // 
      // nudRatingBoxtype2
      // 
      this.nudRatingBoxtype2.Location = new System.Drawing.Point(119, 113);
      this.nudRatingBoxtype2.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
      this.nudRatingBoxtype2.Name = "nudRatingBoxtype2";
      this.nudRatingBoxtype2.Size = new System.Drawing.Size(120, 20);
      this.nudRatingBoxtype2.TabIndex = 5;
      this.nudRatingBoxtype2.Value = new decimal(new int[] {
            50,
            0,
            0,
            -2147483648});
      // 
      // nudRatingBoxtype1
      // 
      this.nudRatingBoxtype1.Location = new System.Drawing.Point(119, 83);
      this.nudRatingBoxtype1.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
      this.nudRatingBoxtype1.Name = "nudRatingBoxtype1";
      this.nudRatingBoxtype1.Size = new System.Drawing.Size(120, 20);
      this.nudRatingBoxtype1.TabIndex = 4;
      this.nudRatingBoxtype1.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
      // 
      // nudRatingBoxtype0
      // 
      this.nudRatingBoxtype0.Location = new System.Drawing.Point(119, 55);
      this.nudRatingBoxtype0.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
      this.nudRatingBoxtype0.Name = "nudRatingBoxtype0";
      this.nudRatingBoxtype0.Size = new System.Drawing.Size(120, 20);
      this.nudRatingBoxtype0.TabIndex = 3;
      this.nudRatingBoxtype0.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      // 
      // lblRatingBoxtype2
      // 
      this.lblRatingBoxtype2.AutoSize = true;
      this.lblRatingBoxtype2.Location = new System.Drawing.Point(10, 115);
      this.lblRatingBoxtype2.Name = "lblRatingBoxtype2";
      this.lblRatingBoxtype2.Size = new System.Drawing.Size(51, 13);
      this.lblRatingBoxtype2.TabIndex = 100;
      this.lblRatingBoxtype2.Text = "3. Boxtyp";
      // 
      // lblRatingBoxtype1
      // 
      this.lblRatingBoxtype1.AutoSize = true;
      this.lblRatingBoxtype1.Location = new System.Drawing.Point(10, 85);
      this.lblRatingBoxtype1.Name = "lblRatingBoxtype1";
      this.lblRatingBoxtype1.Size = new System.Drawing.Size(51, 13);
      this.lblRatingBoxtype1.TabIndex = 100;
      this.lblRatingBoxtype1.Text = "2. Boxtyp";
      // 
      // lblRatingBoxtype0
      // 
      this.lblRatingBoxtype0.AutoSize = true;
      this.lblRatingBoxtype0.Location = new System.Drawing.Point(10, 57);
      this.lblRatingBoxtype0.Name = "lblRatingBoxtype0";
      this.lblRatingBoxtype0.Size = new System.Drawing.Size(51, 13);
      this.lblRatingBoxtype0.TabIndex = 100;
      this.lblRatingBoxtype0.Text = "1. Boxtyp";
      // 
      // lblRatings
      // 
      this.lblRatings.AutoSize = true;
      this.lblRatings.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblRatings.Location = new System.Drawing.Point(6, 16);
      this.lblRatings.Name = "lblRatings";
      this.lblRatings.Size = new System.Drawing.Size(113, 24);
      this.lblRatings.TabIndex = 100;
      this.lblRatings.Text = "Wertungen";
      // 
      // gpxColors
      // 
      this.gpxColors.Controls.Add(this.btnColorBoxtype0);
      this.gpxColors.Controls.Add(this.btnColorBoxes);
      this.gpxColors.Controls.Add(this.btnColorBoxtype2);
      this.gpxColors.Controls.Add(this.btnColorBoxtype1);
      this.gpxColors.Controls.Add(this.btnColorField);
      this.gpxColors.Controls.Add(this.lblColorBoxtype2);
      this.gpxColors.Controls.Add(this.lblColorBoxtype1);
      this.gpxColors.Controls.Add(this.lblColorField);
      this.gpxColors.Controls.Add(this.lblColorBoxtype0);
      this.gpxColors.Controls.Add(this.lblColorBoxes);
      this.gpxColors.Controls.Add(this.lblColors);
      this.gpxColors.Location = new System.Drawing.Point(274, 62);
      this.gpxColors.Name = "gpxColors";
      this.gpxColors.Size = new System.Drawing.Size(256, 278);
      this.gpxColors.TabIndex = 4;
      this.gpxColors.TabStop = false;
      // 
      // btnColorBoxtype0
      // 
      this.btnColorBoxtype0.BackColor = System.Drawing.Color.Blue;
      this.btnColorBoxtype0.Location = new System.Drawing.Point(121, 180);
      this.btnColorBoxtype0.Name = "btnColorBoxtype0";
      this.btnColorBoxtype0.Size = new System.Drawing.Size(114, 23);
      this.btnColorBoxtype0.TabIndex = 9;
      this.btnColorBoxtype0.UseVisualStyleBackColor = false;
      this.btnColorBoxtype0.Click += new System.EventHandler(this.BtnColor_Click);
      // 
      // btnColorBoxes
      // 
      this.btnColorBoxes.BackColor = System.Drawing.Color.LightGray;
      this.btnColorBoxes.Location = new System.Drawing.Point(121, 52);
      this.btnColorBoxes.Name = "btnColorBoxes";
      this.btnColorBoxes.Size = new System.Drawing.Size(114, 23);
      this.btnColorBoxes.TabIndex = 7;
      this.btnColorBoxes.UseVisualStyleBackColor = false;
      this.btnColorBoxes.Click += new System.EventHandler(this.BtnColor_Click);
      // 
      // btnColorBoxtype2
      // 
      this.btnColorBoxtype2.BackColor = System.Drawing.Color.Red;
      this.btnColorBoxtype2.Location = new System.Drawing.Point(121, 238);
      this.btnColorBoxtype2.Name = "btnColorBoxtype2";
      this.btnColorBoxtype2.Size = new System.Drawing.Size(114, 23);
      this.btnColorBoxtype2.TabIndex = 11;
      this.btnColorBoxtype2.UseVisualStyleBackColor = false;
      this.btnColorBoxtype2.Click += new System.EventHandler(this.BtnColor_Click);
      // 
      // btnColorBoxtype1
      // 
      this.btnColorBoxtype1.BackColor = System.Drawing.Color.Green;
      this.btnColorBoxtype1.Location = new System.Drawing.Point(121, 208);
      this.btnColorBoxtype1.Name = "btnColorBoxtype1";
      this.btnColorBoxtype1.Size = new System.Drawing.Size(114, 23);
      this.btnColorBoxtype1.TabIndex = 10;
      this.btnColorBoxtype1.UseVisualStyleBackColor = false;
      this.btnColorBoxtype1.Click += new System.EventHandler(this.BtnColor_Click);
      // 
      // btnColorField
      // 
      this.btnColorField.BackColor = System.Drawing.Color.DimGray;
      this.btnColorField.Location = new System.Drawing.Point(121, 80);
      this.btnColorField.Name = "btnColorField";
      this.btnColorField.Size = new System.Drawing.Size(114, 23);
      this.btnColorField.TabIndex = 8;
      this.btnColorField.UseVisualStyleBackColor = false;
      this.btnColorField.Click += new System.EventHandler(this.BtnColor_Click);
      // 
      // lblColorBoxtype2
      // 
      this.lblColorBoxtype2.AutoSize = true;
      this.lblColorBoxtype2.Location = new System.Drawing.Point(10, 243);
      this.lblColorBoxtype2.Name = "lblColorBoxtype2";
      this.lblColorBoxtype2.Size = new System.Drawing.Size(51, 13);
      this.lblColorBoxtype2.TabIndex = 100;
      this.lblColorBoxtype2.Text = "3. Boxtyp";
      // 
      // lblColorBoxtype1
      // 
      this.lblColorBoxtype1.AutoSize = true;
      this.lblColorBoxtype1.Location = new System.Drawing.Point(10, 213);
      this.lblColorBoxtype1.Name = "lblColorBoxtype1";
      this.lblColorBoxtype1.Size = new System.Drawing.Size(51, 13);
      this.lblColorBoxtype1.TabIndex = 100;
      this.lblColorBoxtype1.Text = "2. Boxtyp";
      // 
      // lblColorField
      // 
      this.lblColorField.AutoSize = true;
      this.lblColorField.Location = new System.Drawing.Point(10, 85);
      this.lblColorField.Name = "lblColorField";
      this.lblColorField.Size = new System.Drawing.Size(47, 13);
      this.lblColorField.TabIndex = 100;
      this.lblColorField.Text = "Spielfeld";
      // 
      // lblColorBoxtype0
      // 
      this.lblColorBoxtype0.AutoSize = true;
      this.lblColorBoxtype0.Location = new System.Drawing.Point(10, 185);
      this.lblColorBoxtype0.Name = "lblColorBoxtype0";
      this.lblColorBoxtype0.Size = new System.Drawing.Size(51, 13);
      this.lblColorBoxtype0.TabIndex = 100;
      this.lblColorBoxtype0.Text = "1. Boxtyp";
      // 
      // lblColorBoxes
      // 
      this.lblColorBoxes.AutoSize = true;
      this.lblColorBoxes.Location = new System.Drawing.Point(10, 57);
      this.lblColorBoxes.Name = "lblColorBoxes";
      this.lblColorBoxes.Size = new System.Drawing.Size(37, 13);
      this.lblColorBoxes.TabIndex = 100;
      this.lblColorBoxes.Text = "Boxen";
      // 
      // lblColors
      // 
      this.lblColors.AutoSize = true;
      this.lblColors.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblColors.Location = new System.Drawing.Point(6, 16);
      this.lblColors.Name = "lblColors";
      this.lblColors.Size = new System.Drawing.Size(77, 24);
      this.lblColors.TabIndex = 100;
      this.lblColors.Text = "Farben";
      // 
      // btnUse
      // 
      this.btnUse.Location = new System.Drawing.Point(416, 409);
      this.btnUse.Name = "btnUse";
      this.btnUse.Size = new System.Drawing.Size(114, 23);
      this.btnUse.TabIndex = 99;
      this.btnUse.Text = "Übernehmen";
      this.btnUse.UseVisualStyleBackColor = true;
      this.btnUse.Click += new System.EventHandler(this.BtnUse_Click);
      // 
      // groupBox3
      // 
      this.groupBox3.Controls.Add(this.nudMaxPlaytime);
      this.groupBox3.Controls.Add(this.lblMaxPlaytime);
      this.groupBox3.Controls.Add(this.lblGame);
      this.groupBox3.Location = new System.Drawing.Point(12, 346);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new System.Drawing.Size(256, 86);
      this.groupBox3.TabIndex = 3;
      this.groupBox3.TabStop = false;
      // 
      // nudMaxPlaytime
      // 
      this.nudMaxPlaytime.Location = new System.Drawing.Point(119, 55);
      this.nudMaxPlaytime.Maximum = new decimal(new int[] {
            300000,
            0,
            0,
            0});
      this.nudMaxPlaytime.Minimum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
      this.nudMaxPlaytime.Name = "nudMaxPlaytime";
      this.nudMaxPlaytime.Size = new System.Drawing.Size(120, 20);
      this.nudMaxPlaytime.TabIndex = 6;
      this.nudMaxPlaytime.Value = new decimal(new int[] {
            39999,
            0,
            0,
            0});
      // 
      // lblMaxPlaytime
      // 
      this.lblMaxPlaytime.AutoSize = true;
      this.lblMaxPlaytime.Location = new System.Drawing.Point(10, 57);
      this.lblMaxPlaytime.Name = "lblMaxPlaytime";
      this.lblMaxPlaytime.Size = new System.Drawing.Size(79, 13);
      this.lblMaxPlaytime.TabIndex = 100;
      this.lblMaxPlaytime.Text = "Spieldauer (ms)";
      // 
      // lblGame
      // 
      this.lblGame.AutoSize = true;
      this.lblGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblGame.Location = new System.Drawing.Point(6, 16);
      this.lblGame.Name = "lblGame";
      this.lblGame.Size = new System.Drawing.Size(57, 24);
      this.lblGame.TabIndex = 100;
      this.lblGame.Text = "Spiel";
      // 
      // frmOptions
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(544, 442);
      this.Controls.Add(this.btnUse);
      this.Controls.Add(this.gpxRatings);
      this.Controls.Add(this.gpxColors);
      this.Controls.Add(this.groupBox3);
      this.Controls.Add(this.gpxPlayField);
      this.Controls.Add(this.lblSettings);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "frmOptions";
      this.Text = "Optionen";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmOptions_FormClosing);
      this.gpxPlayField.ResumeLayout(false);
      this.gpxPlayField.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.nudVertical)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.nudHorizontal)).EndInit();
      this.gpxRatings.ResumeLayout(false);
      this.gpxRatings.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.nudRatingBoxtype2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.nudRatingBoxtype1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.nudRatingBoxtype0)).EndInit();
      this.gpxColors.ResumeLayout(false);
      this.gpxColors.PerformLayout();
      this.groupBox3.ResumeLayout(false);
      this.groupBox3.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.nudMaxPlaytime)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lblSettings;
    private System.Windows.Forms.GroupBox gpxPlayField;
    private System.Windows.Forms.Label lblPlayField;
    private System.Windows.Forms.Label lblHorizontal;
    private System.Windows.Forms.Label lblVertical;
    private System.Windows.Forms.NumericUpDown nudVertical;
    private System.Windows.Forms.NumericUpDown nudHorizontal;
    private System.Windows.Forms.GroupBox gpxRatings;
    private System.Windows.Forms.NumericUpDown nudRatingBoxtype1;
    private System.Windows.Forms.NumericUpDown nudRatingBoxtype0;
    private System.Windows.Forms.Label lblRatingBoxtype1;
    private System.Windows.Forms.Label lblRatingBoxtype0;
    private System.Windows.Forms.Label lblRatings;
    private System.Windows.Forms.NumericUpDown nudRatingBoxtype2;
    private System.Windows.Forms.Label lblRatingBoxtype2;
    private System.Windows.Forms.GroupBox gpxColors;
    private System.Windows.Forms.Label lblColorField;
    private System.Windows.Forms.Label lblColorBoxes;
    private System.Windows.Forms.Label lblColors;
    private System.Windows.Forms.Button btnColorField;
    private System.Windows.Forms.Button btnColorBoxes;
    private System.Windows.Forms.Button btnColorBoxtype0;
    private System.Windows.Forms.Button btnColorBoxtype2;
    private System.Windows.Forms.Button btnColorBoxtype1;
    private System.Windows.Forms.Label lblColorBoxtype2;
    private System.Windows.Forms.Label lblColorBoxtype1;
    private System.Windows.Forms.Label lblColorBoxtype0;
    private System.Windows.Forms.Button btnUse;
    private System.Windows.Forms.ColorDialog clrDialog;
    private System.Windows.Forms.GroupBox groupBox3;
    private System.Windows.Forms.NumericUpDown nudMaxPlaytime;
    private System.Windows.Forms.Label lblMaxPlaytime;
    private System.Windows.Forms.Label lblGame;
  }
}