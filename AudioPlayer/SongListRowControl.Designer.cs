namespace AudioPlayer {
	partial class SongListRowControl {
		/// <summary> 
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором компонентов

		/// <summary> 
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent() {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SongListRowControl));
			this.PlayButton = new System.Windows.Forms.Button();
			this.TitleLabel = new System.Windows.Forms.Label();
			this.ArtistLabel = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.TimeLabel = new System.Windows.Forms.Label();
			this.EditButton = new System.Windows.Forms.Button();
			this.DeleteButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// PlayButton
			// 
			this.PlayButton.FlatAppearance.BorderSize = 0;
			this.PlayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.PlayButton.Image = ((System.Drawing.Image)(resources.GetObject("PlayButton.Image")));
			this.PlayButton.Location = new System.Drawing.Point(2, 2);
			this.PlayButton.Margin = new System.Windows.Forms.Padding(0);
			this.PlayButton.Name = "PlayButton";
			this.PlayButton.Size = new System.Drawing.Size(31, 31);
			this.PlayButton.TabIndex = 0;
			this.PlayButton.UseVisualStyleBackColor = true;
			this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
			// 
			// TitleLabel
			// 
			this.TitleLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.TitleLabel.AutoEllipsis = true;
			this.TitleLabel.AutoSize = true;
			this.TitleLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.TitleLabel.Location = new System.Drawing.Point(67, 7);
			this.TitleLabel.MaximumSize = new System.Drawing.Size(230, 23);
			this.TitleLabel.Name = "TitleLabel";
			this.TitleLabel.Size = new System.Drawing.Size(35, 20);
			this.TitleLabel.TabIndex = 2;
			this.TitleLabel.Text = "Title";
			this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// ArtistLabel
			// 
			this.ArtistLabel.AutoEllipsis = true;
			this.ArtistLabel.AutoSize = true;
			this.ArtistLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.ArtistLabel.Location = new System.Drawing.Point(306, 6);
			this.ArtistLabel.MaximumSize = new System.Drawing.Size(160, 23);
			this.ArtistLabel.Name = "ArtistLabel";
			this.ArtistLabel.Size = new System.Drawing.Size(44, 20);
			this.ArtistLabel.TabIndex = 3;
			this.ArtistLabel.Text = "Artist";
			this.ArtistLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(286, 6);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(14, 20);
			this.label2.TabIndex = 4;
			this.label2.Text = "-";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(464, 6);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(14, 20);
			this.label1.TabIndex = 5;
			this.label1.Text = "-";
			// 
			// TimeLabel
			// 
			this.TimeLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.TimeLabel.Location = new System.Drawing.Point(478, 2);
			this.TimeLabel.Name = "TimeLabel";
			this.TimeLabel.Size = new System.Drawing.Size(52, 31);
			this.TimeLabel.TabIndex = 6;
			this.TimeLabel.Text = "0:00";
			this.TimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// EditButton
			// 
			this.EditButton.FlatAppearance.BorderSize = 0;
			this.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.EditButton.Image = ((System.Drawing.Image)(resources.GetObject("EditButton.Image")));
			this.EditButton.Location = new System.Drawing.Point(33, 2);
			this.EditButton.Margin = new System.Windows.Forms.Padding(0);
			this.EditButton.Name = "EditButton";
			this.EditButton.Size = new System.Drawing.Size(31, 31);
			this.EditButton.TabIndex = 7;
			this.EditButton.UseVisualStyleBackColor = true;
			this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
			// 
			// DeleteButton
			// 
			this.DeleteButton.FlatAppearance.BorderSize = 0;
			this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.DeleteButton.Image = ((System.Drawing.Image)(resources.GetObject("DeleteButton.Image")));
			this.DeleteButton.Location = new System.Drawing.Point(533, 2);
			this.DeleteButton.Margin = new System.Windows.Forms.Padding(0);
			this.DeleteButton.Name = "DeleteButton";
			this.DeleteButton.Size = new System.Drawing.Size(31, 31);
			this.DeleteButton.TabIndex = 8;
			this.DeleteButton.UseVisualStyleBackColor = true;
			this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
			// 
			// SongListRowControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDark;
			this.Controls.Add(this.DeleteButton);
			this.Controls.Add(this.EditButton);
			this.Controls.Add(this.TimeLabel);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.ArtistLabel);
			this.Controls.Add(this.TitleLabel);
			this.Controls.Add(this.PlayButton);
			this.Margin = new System.Windows.Forms.Padding(0);
			this.Name = "SongListRowControl";
			this.Size = new System.Drawing.Size(565, 35);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button PlayButton;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label TimeLabel;
		private System.Windows.Forms.Button EditButton;
		private System.Windows.Forms.Button DeleteButton;
		public System.Windows.Forms.Label TitleLabel;
		public System.Windows.Forms.Label ArtistLabel;
	}
}
