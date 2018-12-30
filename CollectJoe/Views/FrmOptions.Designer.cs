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
      this.lblPlayField = new System.Windows.Forms.Label();
      this.lblHorizontal = new System.Windows.Forms.Label();
      this.lblVertical = new System.Windows.Forms.Label();
      this.nudHorizontal = new System.Windows.Forms.NumericUpDown();
      this.nudVertical = new System.Windows.Forms.NumericUpDown();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.nudRatingBoxtype1 = new System.Windows.Forms.NumericUpDown();
      this.nudRatingBoxtype0 = new System.Windows.Forms.NumericUpDown();
      this.lblRatingBoxtype1 = new System.Windows.Forms.Label();
      this.lblRatingBoxtype0 = new System.Windows.Forms.Label();
      this.lblRatings = new System.Windows.Forms.Label();
      this.lblRatingBoxtype2 = new System.Windows.Forms.Label();
      this.nudRatingBoxtype2 = new System.Windows.Forms.NumericUpDown();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.lblColorField = new System.Windows.Forms.Label();
      this.lblColorBoxes = new System.Windows.Forms.Label();
      this.lblColors = new System.Windows.Forms.Label();
      this.btnColorField = new System.Windows.Forms.Button();
      this.btnColorBoxes = new System.Windows.Forms.Button();
      this.lblColorBoxtype0 = new System.Windows.Forms.Label();
      this.lblColorBoxtype1 = new System.Windows.Forms.Label();
      this.btnColorBoxtype1 = new System.Windows.Forms.Button();
      this.btnColorBoxtype0 = new System.Windows.Forms.Button();
      this.lblColorBoxtype2 = new System.Windows.Forms.Label();
      this.btnColorBoxtype2 = new System.Windows.Forms.Button();
      this.btnUse = new System.Windows.Forms.Button();
      this.clrDialog = new System.Windows.Forms.ColorDialog();
      this.gpxPlayField.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.nudHorizontal)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.nudVertical)).BeginInit();
      this.groupBox1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.nudRatingBoxtype1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.nudRatingBoxtype0)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.nudRatingBoxtype2)).BeginInit();
      this.groupBox2.SuspendLayout();
      this.SuspendLayout();
      // 
      // lblSettings
      // 
      this.lblSettings.AutoSize = true;
      this.lblSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblSettings.Location = new System.Drawing.Point(6, 13);
      this.lblSettings.Name = "lblSettings";
      this.lblSettings.Size = new System.Drawing.Size(190, 31);
      this.lblSettings.TabIndex = 0;
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
      // lblPlayField
      // 
      this.lblPlayField.AutoSize = true;
      this.lblPlayField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblPlayField.Location = new System.Drawing.Point(6, 16);
      this.lblPlayField.Name = "lblPlayField";
      this.lblPlayField.Size = new System.Drawing.Size(91, 24);
      this.lblPlayField.TabIndex = 0;
      this.lblPlayField.Text = "Spielfeld";
      // 
      // lblHorizontal
      // 
      this.lblHorizontal.AutoSize = true;
      this.lblHorizontal.Location = new System.Drawing.Point(10, 57);
      this.lblHorizontal.Name = "lblHorizontal";
      this.lblHorizontal.Size = new System.Drawing.Size(85, 13);
      this.lblHorizontal.TabIndex = 1;
      this.lblHorizontal.Text = "Boxen horizontal";
      // 
      // lblVertical
      // 
      this.lblVertical.AutoSize = true;
      this.lblVertical.Location = new System.Drawing.Point(10, 85);
      this.lblVertical.Name = "lblVertical";
      this.lblVertical.Size = new System.Drawing.Size(74, 13);
      this.lblVertical.TabIndex = 1;
      this.lblVertical.Text = "Boxen vertikal";
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
      this.nudHorizontal.TabIndex = 2;
      this.nudHorizontal.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
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
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.nudRatingBoxtype2);
      this.groupBox1.Controls.Add(this.nudRatingBoxtype1);
      this.groupBox1.Controls.Add(this.nudRatingBoxtype0);
      this.groupBox1.Controls.Add(this.lblRatingBoxtype2);
      this.groupBox1.Controls.Add(this.lblRatingBoxtype1);
      this.groupBox1.Controls.Add(this.lblRatingBoxtype0);
      this.groupBox1.Controls.Add(this.lblRatings);
      this.groupBox1.Location = new System.Drawing.Point(12, 190);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(256, 150);
      this.groupBox1.TabIndex = 1;
      this.groupBox1.TabStop = false;
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
      this.nudRatingBoxtype1.TabIndex = 2;
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
      this.nudRatingBoxtype0.TabIndex = 2;
      this.nudRatingBoxtype0.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      // 
      // lblRatingBoxtype1
      // 
      this.lblRatingBoxtype1.AutoSize = true;
      this.lblRatingBoxtype1.Location = new System.Drawing.Point(10, 85);
      this.lblRatingBoxtype1.Name = "lblRatingBoxtype1";
      this.lblRatingBoxtype1.Size = new System.Drawing.Size(51, 13);
      this.lblRatingBoxtype1.TabIndex = 1;
      this.lblRatingBoxtype1.Text = "2. Boxtyp";
      // 
      // lblRatingBoxtype0
      // 
      this.lblRatingBoxtype0.AutoSize = true;
      this.lblRatingBoxtype0.Location = new System.Drawing.Point(10, 57);
      this.lblRatingBoxtype0.Name = "lblRatingBoxtype0";
      this.lblRatingBoxtype0.Size = new System.Drawing.Size(51, 13);
      this.lblRatingBoxtype0.TabIndex = 1;
      this.lblRatingBoxtype0.Text = "1. Boxtyp";
      // 
      // lblRatings
      // 
      this.lblRatings.AutoSize = true;
      this.lblRatings.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblRatings.Location = new System.Drawing.Point(6, 16);
      this.lblRatings.Name = "lblRatings";
      this.lblRatings.Size = new System.Drawing.Size(113, 24);
      this.lblRatings.TabIndex = 0;
      this.lblRatings.Text = "Wertungen";
      // 
      // lblRatingBoxtype2
      // 
      this.lblRatingBoxtype2.AutoSize = true;
      this.lblRatingBoxtype2.Location = new System.Drawing.Point(10, 115);
      this.lblRatingBoxtype2.Name = "lblRatingBoxtype2";
      this.lblRatingBoxtype2.Size = new System.Drawing.Size(51, 13);
      this.lblRatingBoxtype2.TabIndex = 1;
      this.lblRatingBoxtype2.Text = "3. Boxtyp";
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
      this.nudRatingBoxtype2.TabIndex = 2;
      this.nudRatingBoxtype2.Value = new decimal(new int[] {
            50,
            0,
            0,
            -2147483648});
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.btnColorBoxtype0);
      this.groupBox2.Controls.Add(this.btnColorBoxes);
      this.groupBox2.Controls.Add(this.btnColorBoxtype2);
      this.groupBox2.Controls.Add(this.btnColorBoxtype1);
      this.groupBox2.Controls.Add(this.btnColorField);
      this.groupBox2.Controls.Add(this.lblColorBoxtype2);
      this.groupBox2.Controls.Add(this.lblColorBoxtype1);
      this.groupBox2.Controls.Add(this.lblColorField);
      this.groupBox2.Controls.Add(this.lblColorBoxtype0);
      this.groupBox2.Controls.Add(this.lblColorBoxes);
      this.groupBox2.Controls.Add(this.lblColors);
      this.groupBox2.Location = new System.Drawing.Point(274, 62);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(256, 278);
      this.groupBox2.TabIndex = 1;
      this.groupBox2.TabStop = false;
      // 
      // lblColorField
      // 
      this.lblColorField.AutoSize = true;
      this.lblColorField.Location = new System.Drawing.Point(10, 85);
      this.lblColorField.Name = "lblColorField";
      this.lblColorField.Size = new System.Drawing.Size(47, 13);
      this.lblColorField.TabIndex = 1;
      this.lblColorField.Text = "Spielfeld";
      // 
      // lblColorBoxes
      // 
      this.lblColorBoxes.AutoSize = true;
      this.lblColorBoxes.Location = new System.Drawing.Point(10, 57);
      this.lblColorBoxes.Name = "lblColorBoxes";
      this.lblColorBoxes.Size = new System.Drawing.Size(37, 13);
      this.lblColorBoxes.TabIndex = 1;
      this.lblColorBoxes.Text = "Boxen";
      // 
      // lblColors
      // 
      this.lblColors.AutoSize = true;
      this.lblColors.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblColors.Location = new System.Drawing.Point(6, 16);
      this.lblColors.Name = "lblColors";
      this.lblColors.Size = new System.Drawing.Size(77, 24);
      this.lblColors.TabIndex = 0;
      this.lblColors.Text = "Farben";
      // 
      // btnColorField
      // 
      this.btnColorField.BackColor = System.Drawing.Color.DimGray;
      this.btnColorField.Location = new System.Drawing.Point(121, 80);
      this.btnColorField.Name = "btnColorField";
      this.btnColorField.Size = new System.Drawing.Size(114, 23);
      this.btnColorField.TabIndex = 2;
      this.btnColorField.UseVisualStyleBackColor = false;
      this.btnColorField.Click += new System.EventHandler(this.BtnColor_Click);
      // 
      // btnColorBoxes
      // 
      this.btnColorBoxes.BackColor = System.Drawing.Color.LightGray;
      this.btnColorBoxes.Location = new System.Drawing.Point(121, 52);
      this.btnColorBoxes.Name = "btnColorBoxes";
      this.btnColorBoxes.Size = new System.Drawing.Size(114, 23);
      this.btnColorBoxes.TabIndex = 2;
      this.btnColorBoxes.UseVisualStyleBackColor = false;
      this.btnColorBoxes.Click += new System.EventHandler(this.BtnColor_Click);
      // 
      // lblColorBoxtype0
      // 
      this.lblColorBoxtype0.AutoSize = true;
      this.lblColorBoxtype0.Location = new System.Drawing.Point(10, 185);
      this.lblColorBoxtype0.Name = "lblColorBoxtype0";
      this.lblColorBoxtype0.Size = new System.Drawing.Size(51, 13);
      this.lblColorBoxtype0.TabIndex = 1;
      this.lblColorBoxtype0.Text = "1. Boxtyp";
      // 
      // lblColorBoxtype1
      // 
      this.lblColorBoxtype1.AutoSize = true;
      this.lblColorBoxtype1.Location = new System.Drawing.Point(10, 213);
      this.lblColorBoxtype1.Name = "lblColorBoxtype1";
      this.lblColorBoxtype1.Size = new System.Drawing.Size(51, 13);
      this.lblColorBoxtype1.TabIndex = 1;
      this.lblColorBoxtype1.Text = "2. Boxtyp";
      // 
      // btnColorBoxtype1
      // 
      this.btnColorBoxtype1.BackColor = System.Drawing.Color.Green;
      this.btnColorBoxtype1.Location = new System.Drawing.Point(121, 208);
      this.btnColorBoxtype1.Name = "btnColorBoxtype1";
      this.btnColorBoxtype1.Size = new System.Drawing.Size(114, 23);
      this.btnColorBoxtype1.TabIndex = 2;
      this.btnColorBoxtype1.UseVisualStyleBackColor = false;
      this.btnColorBoxtype1.Click += new System.EventHandler(this.BtnColor_Click);
      // 
      // btnColorBoxtype0
      // 
      this.btnColorBoxtype0.BackColor = System.Drawing.Color.Blue;
      this.btnColorBoxtype0.Location = new System.Drawing.Point(121, 180);
      this.btnColorBoxtype0.Name = "btnColorBoxtype0";
      this.btnColorBoxtype0.Size = new System.Drawing.Size(114, 23);
      this.btnColorBoxtype0.TabIndex = 2;
      this.btnColorBoxtype0.UseVisualStyleBackColor = false;
      this.btnColorBoxtype0.Click += new System.EventHandler(this.BtnColor_Click);
      // 
      // lblColorBoxtype2
      // 
      this.lblColorBoxtype2.AutoSize = true;
      this.lblColorBoxtype2.Location = new System.Drawing.Point(10, 243);
      this.lblColorBoxtype2.Name = "lblColorBoxtype2";
      this.lblColorBoxtype2.Size = new System.Drawing.Size(51, 13);
      this.lblColorBoxtype2.TabIndex = 1;
      this.lblColorBoxtype2.Text = "3. Boxtyp";
      // 
      // btnColorBoxtype2
      // 
      this.btnColorBoxtype2.BackColor = System.Drawing.Color.Red;
      this.btnColorBoxtype2.Location = new System.Drawing.Point(121, 238);
      this.btnColorBoxtype2.Name = "btnColorBoxtype2";
      this.btnColorBoxtype2.Size = new System.Drawing.Size(114, 23);
      this.btnColorBoxtype2.TabIndex = 2;
      this.btnColorBoxtype2.UseVisualStyleBackColor = false;
      this.btnColorBoxtype2.Click += new System.EventHandler(this.BtnColor_Click);
      // 
      // btnUse
      // 
      this.btnUse.Location = new System.Drawing.Point(12, 346);
      this.btnUse.Name = "btnUse";
      this.btnUse.Size = new System.Drawing.Size(114, 23);
      this.btnUse.TabIndex = 2;
      this.btnUse.Text = "Übernehmen";
      this.btnUse.UseVisualStyleBackColor = true;
      this.btnUse.Click += new System.EventHandler(this.BtnUse_Click);
      // 
      // frmOptions
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(544, 382);
      this.Controls.Add(this.btnUse);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.groupBox2);
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
      ((System.ComponentModel.ISupportInitialize)(this.nudHorizontal)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.nudVertical)).EndInit();
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.nudRatingBoxtype1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.nudRatingBoxtype0)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.nudRatingBoxtype2)).EndInit();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
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
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.NumericUpDown nudRatingBoxtype1;
    private System.Windows.Forms.NumericUpDown nudRatingBoxtype0;
    private System.Windows.Forms.Label lblRatingBoxtype1;
    private System.Windows.Forms.Label lblRatingBoxtype0;
    private System.Windows.Forms.Label lblRatings;
    private System.Windows.Forms.NumericUpDown nudRatingBoxtype2;
    private System.Windows.Forms.Label lblRatingBoxtype2;
    private System.Windows.Forms.GroupBox groupBox2;
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
  }
}