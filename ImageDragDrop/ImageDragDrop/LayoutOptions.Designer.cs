namespace ImageDragDrop
{
	partial class LayoutOptions
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
			this.label1 = new System.Windows.Forms.Label();
			this.gbOptions = new System.Windows.Forms.GroupBox();
			this.gbLandscapeOptions = new System.Windows.Forms.GroupBox();
			this.gbPortraitOptions = new System.Windows.Forms.GroupBox();
			this.rbPortrait3by2 = new System.Windows.Forms.RadioButton();
			this.rbPortrait2by2 = new System.Windows.Forms.RadioButton();
			this.rbPortrait3by3 = new System.Windows.Forms.RadioButton();
			this.rbLandscape = new System.Windows.Forms.RadioButton();
			this.rbPortrait = new System.Windows.Forms.RadioButton();
			this.rbPortrait1by2 = new System.Windows.Forms.RadioButton();
			this.rbPortrait1by1 = new System.Windows.Forms.RadioButton();
			this.rbLandscape1by2 = new System.Windows.Forms.RadioButton();
			this.rbLandscape1by3 = new System.Windows.Forms.RadioButton();
			this.btnNext = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.gbOptions.SuspendLayout();
			this.gbLandscapeOptions.SuspendLayout();
			this.gbPortraitOptions.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
			this.label1.Location = new System.Drawing.Point(56, 54);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(282, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Select a layout from the following:";
			// 
			// gbOptions
			// 
			this.gbOptions.Controls.Add(this.gbLandscapeOptions);
			this.gbOptions.Controls.Add(this.gbPortraitOptions);
			this.gbOptions.Controls.Add(this.rbLandscape);
			this.gbOptions.Controls.Add(this.rbPortrait);
			this.gbOptions.Location = new System.Drawing.Point(60, 117);
			this.gbOptions.Name = "gbOptions";
			this.gbOptions.Size = new System.Drawing.Size(458, 456);
			this.gbOptions.TabIndex = 1;
			this.gbOptions.TabStop = false;
			// 
			// gbLandscapeOptions
			// 
			this.gbLandscapeOptions.Controls.Add(this.rbLandscape1by3);
			this.gbLandscapeOptions.Controls.Add(this.rbLandscape1by2);
			this.gbLandscapeOptions.Enabled = false;
			this.gbLandscapeOptions.Location = new System.Drawing.Point(73, 259);
			this.gbLandscapeOptions.Name = "gbLandscapeOptions";
			this.gbLandscapeOptions.Size = new System.Drawing.Size(312, 178);
			this.gbLandscapeOptions.TabIndex = 3;
			this.gbLandscapeOptions.TabStop = false;
			this.gbLandscapeOptions.Text = "Available Options";
			// 
			// gbPortraitOptions
			// 
			this.gbPortraitOptions.Controls.Add(this.rbPortrait1by1);
			this.gbPortraitOptions.Controls.Add(this.rbPortrait1by2);
			this.gbPortraitOptions.Controls.Add(this.rbPortrait3by2);
			this.gbPortraitOptions.Controls.Add(this.rbPortrait2by2);
			this.gbPortraitOptions.Controls.Add(this.rbPortrait3by3);
			this.gbPortraitOptions.Enabled = false;
			this.gbPortraitOptions.Location = new System.Drawing.Point(73, 46);
			this.gbPortraitOptions.Name = "gbPortraitOptions";
			this.gbPortraitOptions.Size = new System.Drawing.Size(312, 178);
			this.gbPortraitOptions.TabIndex = 2;
			this.gbPortraitOptions.TabStop = false;
			this.gbPortraitOptions.Text = "Available Options";
			// 
			// rbPortrait3by2
			// 
			this.rbPortrait3by2.AutoSize = true;
			this.rbPortrait3by2.Location = new System.Drawing.Point(20, 131);
			this.rbPortrait3by2.Name = "rbPortrait3by2";
			this.rbPortrait3by2.Size = new System.Drawing.Size(48, 17);
			this.rbPortrait3by2.TabIndex = 2;
			this.rbPortrait3by2.TabStop = true;
			this.rbPortrait3by2.Text = "3 x 2";
			this.rbPortrait3by2.UseVisualStyleBackColor = true;
			// 
			// rbPortrait2by2
			// 
			this.rbPortrait2by2.AutoSize = true;
			this.rbPortrait2by2.Location = new System.Drawing.Point(20, 80);
			this.rbPortrait2by2.Name = "rbPortrait2by2";
			this.rbPortrait2by2.Size = new System.Drawing.Size(48, 17);
			this.rbPortrait2by2.TabIndex = 1;
			this.rbPortrait2by2.TabStop = true;
			this.rbPortrait2by2.Text = "2 x 2";
			this.rbPortrait2by2.UseVisualStyleBackColor = true;
			// 
			// rbPortrait3by3
			// 
			this.rbPortrait3by3.AutoSize = true;
			this.rbPortrait3by3.Location = new System.Drawing.Point(20, 32);
			this.rbPortrait3by3.Name = "rbPortrait3by3";
			this.rbPortrait3by3.Size = new System.Drawing.Size(48, 17);
			this.rbPortrait3by3.TabIndex = 0;
			this.rbPortrait3by3.TabStop = true;
			this.rbPortrait3by3.Text = "3 x 3";
			this.rbPortrait3by3.UseVisualStyleBackColor = true;
			// 
			// rbLandscape
			// 
			this.rbLandscape.AutoSize = true;
			this.rbLandscape.Location = new System.Drawing.Point(22, 232);
			this.rbLandscape.Name = "rbLandscape";
			this.rbLandscape.Size = new System.Drawing.Size(78, 17);
			this.rbLandscape.TabIndex = 1;
			this.rbLandscape.TabStop = true;
			this.rbLandscape.Text = "Landscape";
			this.rbLandscape.UseVisualStyleBackColor = true;
			this.rbLandscape.CheckedChanged += new System.EventHandler(this.rbLandscape_CheckedChanged);
			// 
			// rbPortrait
			// 
			this.rbPortrait.AutoSize = true;
			this.rbPortrait.Location = new System.Drawing.Point(22, 23);
			this.rbPortrait.Name = "rbPortrait";
			this.rbPortrait.Size = new System.Drawing.Size(58, 17);
			this.rbPortrait.TabIndex = 0;
			this.rbPortrait.TabStop = true;
			this.rbPortrait.Text = "Portrait";
			this.rbPortrait.UseVisualStyleBackColor = true;
			this.rbPortrait.CheckedChanged += new System.EventHandler(this.rbPortrait_CheckedChanged);
			// 
			// rbPortrait1by2
			// 
			this.rbPortrait1by2.AutoSize = true;
			this.rbPortrait1by2.Location = new System.Drawing.Point(183, 32);
			this.rbPortrait1by2.Name = "rbPortrait1by2";
			this.rbPortrait1by2.Size = new System.Drawing.Size(48, 17);
			this.rbPortrait1by2.TabIndex = 3;
			this.rbPortrait1by2.TabStop = true;
			this.rbPortrait1by2.Text = "1 x 2";
			this.rbPortrait1by2.UseVisualStyleBackColor = true;
			// 
			// rbPortrait1by1
			// 
			this.rbPortrait1by1.AutoSize = true;
			this.rbPortrait1by1.Location = new System.Drawing.Point(183, 80);
			this.rbPortrait1by1.Name = "rbPortrait1by1";
			this.rbPortrait1by1.Size = new System.Drawing.Size(48, 17);
			this.rbPortrait1by1.TabIndex = 4;
			this.rbPortrait1by1.TabStop = true;
			this.rbPortrait1by1.Text = "1 x 1";
			this.rbPortrait1by1.UseVisualStyleBackColor = true;
			// 
			// rbLandscape1by2
			// 
			this.rbLandscape1by2.AutoSize = true;
			this.rbLandscape1by2.Location = new System.Drawing.Point(20, 38);
			this.rbLandscape1by2.Name = "rbLandscape1by2";
			this.rbLandscape1by2.Size = new System.Drawing.Size(48, 17);
			this.rbLandscape1by2.TabIndex = 1;
			this.rbLandscape1by2.TabStop = true;
			this.rbLandscape1by2.Text = "1 x 2";
			this.rbLandscape1by2.UseVisualStyleBackColor = true;
			// 
			// rbLandscape1by3
			// 
			this.rbLandscape1by3.AutoSize = true;
			this.rbLandscape1by3.Location = new System.Drawing.Point(20, 79);
			this.rbLandscape1by3.Name = "rbLandscape1by3";
			this.rbLandscape1by3.Size = new System.Drawing.Size(48, 17);
			this.rbLandscape1by3.TabIndex = 2;
			this.rbLandscape1by3.TabStop = true;
			this.rbLandscape1by3.Text = "1 x 3";
			this.rbLandscape1by3.UseVisualStyleBackColor = true;
			// 
			// btnNext
			// 
			this.btnNext.Location = new System.Drawing.Point(60, 590);
			this.btnNext.Name = "btnNext";
			this.btnNext.Size = new System.Drawing.Size(196, 45);
			this.btnNext.TabIndex = 2;
			this.btnNext.Text = "&Next";
			this.btnNext.UseVisualStyleBackColor = true;
			this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(322, 590);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(196, 45);
			this.btnExit.TabIndex = 3;
			this.btnExit.Text = "&Exit";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// LayoutOptions
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(579, 804);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnNext);
			this.Controls.Add(this.gbOptions);
			this.Controls.Add(this.label1);
			this.Name = "LayoutOptions";
			this.Text = "LayoutOptions";
			this.Load += new System.EventHandler(this.LayoutOptions_Load);
			this.gbOptions.ResumeLayout(false);
			this.gbOptions.PerformLayout();
			this.gbLandscapeOptions.ResumeLayout(false);
			this.gbLandscapeOptions.PerformLayout();
			this.gbPortraitOptions.ResumeLayout(false);
			this.gbPortraitOptions.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox gbOptions;
		private System.Windows.Forms.GroupBox gbPortraitOptions;
		private System.Windows.Forms.RadioButton rbLandscape;
		private System.Windows.Forms.RadioButton rbPortrait;
		private System.Windows.Forms.GroupBox gbLandscapeOptions;
		private System.Windows.Forms.RadioButton rbPortrait3by2;
		private System.Windows.Forms.RadioButton rbPortrait2by2;
		private System.Windows.Forms.RadioButton rbPortrait3by3;
		private System.Windows.Forms.RadioButton rbPortrait1by2;
		private System.Windows.Forms.RadioButton rbPortrait1by1;
		private System.Windows.Forms.RadioButton rbLandscape1by3;
		private System.Windows.Forms.RadioButton rbLandscape1by2;
		private System.Windows.Forms.Button btnNext;
		private System.Windows.Forms.Button btnExit;
	}
}