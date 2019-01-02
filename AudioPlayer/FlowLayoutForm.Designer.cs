namespace AudioPlayer {
	partial class FlowLayoutForm {
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
			this.ListPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.SuspendLayout();
			// 
			// ListPanel
			// 
			this.ListPanel.AutoScroll = true;
			this.ListPanel.Location = new System.Drawing.Point(12, 12);
			this.ListPanel.Name = "ListPanel";
			this.ListPanel.Size = new System.Drawing.Size(560, 537);
			this.ListPanel.TabIndex = 0;
			this.ListPanel.Click += new System.EventHandler(this.ListPanel_Click);
			// 
			// FlowLayoutForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDark;
			this.ClientSize = new System.Drawing.Size(584, 561);
			this.Controls.Add(this.ListPanel);
			this.Name = "FlowLayoutForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Items";
			this.ResumeLayout(false);

		}

		#endregion

		public System.Windows.Forms.FlowLayoutPanel ListPanel;
	}
}