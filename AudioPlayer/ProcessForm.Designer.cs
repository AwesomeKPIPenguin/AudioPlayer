namespace AudioPlayer {
	partial class ProcessForm {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.ProgressBar = new System.Windows.Forms.ProgressBar();
			this.TextLabel = new System.Windows.Forms.Label();
			this.TotalCountLabel = new System.Windows.Forms.Label();
			this.ProcessedCountLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// ProgressBar
			// 
			this.ProgressBar.Location = new System.Drawing.Point(12, 62);
			this.ProgressBar.Name = "ProgressBar";
			this.ProgressBar.Size = new System.Drawing.Size(358, 23);
			this.ProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
			this.ProgressBar.TabIndex = 0;
			// 
			// TextLabel
			// 
			this.TextLabel.AutoSize = true;
			this.TextLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.TextLabel.Location = new System.Drawing.Point(12, 24);
			this.TextLabel.Name = "TextLabel";
			this.TextLabel.Size = new System.Drawing.Size(136, 17);
			this.TextLabel.TabIndex = 1;
			this.TextLabel.Text = "Processing MP3 files:";
			// 
			// TotalCountLabel
			// 
			this.TotalCountLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.TotalCountLabel.Location = new System.Drawing.Point(315, 24);
			this.TotalCountLabel.Name = "TotalCountLabel";
			this.TotalCountLabel.Size = new System.Drawing.Size(55, 17);
			this.TotalCountLabel.TabIndex = 2;
			this.TotalCountLabel.Text = "/ 0";
			// 
			// ProcessedCountLabel
			// 
			this.ProcessedCountLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.ProcessedCountLabel.Location = new System.Drawing.Point(256, 24);
			this.ProcessedCountLabel.Name = "ProcessedCountLabel";
			this.ProcessedCountLabel.Size = new System.Drawing.Size(62, 17);
			this.ProcessedCountLabel.TabIndex = 3;
			this.ProcessedCountLabel.Text = "0";
			this.ProcessedCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// ProcessForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(382, 97);
			this.Controls.Add(this.ProcessedCountLabel);
			this.Controls.Add(this.TotalCountLabel);
			this.Controls.Add(this.TextLabel);
			this.Controls.Add(this.ProgressBar);
			this.Name = "ProcessForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ProcessForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		public System.Windows.Forms.Label ProcessedCountLabel;
		public System.Windows.Forms.ProgressBar ProgressBar;
		public System.Windows.Forms.Label TotalCountLabel;
		public System.Windows.Forms.Label TextLabel;
	}
}