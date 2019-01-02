namespace AudioPlayer {
	partial class PlaylistControl {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlaylistControl));
			this.ImageBox = new System.Windows.Forms.PictureBox();
			this.TitleLabel = new System.Windows.Forms.Label();
			this.PlayButton = new System.Windows.Forms.Button();
			this.EditButton = new System.Windows.Forms.Button();
			this.ImageAddButton = new System.Windows.Forms.Button();
			this.ContentButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.ImageBox)).BeginInit();
			this.SuspendLayout();
			// 
			// ImageBox
			// 
			this.ImageBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.ImageBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ImageBox.BackgroundImage")));
			this.ImageBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.ImageBox.Location = new System.Drawing.Point(0, 0);
			this.ImageBox.Name = "ImageBox";
			this.ImageBox.Size = new System.Drawing.Size(200, 200);
			this.ImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.ImageBox.TabIndex = 0;
			this.ImageBox.TabStop = false;
			// 
			// TitleLabel
			// 
			this.TitleLabel.AutoEllipsis = true;
			this.TitleLabel.BackColor = System.Drawing.SystemColors.ControlDark;
			this.TitleLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.TitleLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.TitleLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.TitleLabel.Location = new System.Drawing.Point(0, 200);
			this.TitleLabel.Margin = new System.Windows.Forms.Padding(0);
			this.TitleLabel.Name = "TitleLabel";
			this.TitleLabel.Size = new System.Drawing.Size(200, 40);
			this.TitleLabel.TabIndex = 1;
			this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// PlayButton
			// 
			this.PlayButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.PlayButton.FlatAppearance.BorderSize = 0;
			this.PlayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.PlayButton.Image = ((System.Drawing.Image)(resources.GetObject("PlayButton.Image")));
			this.PlayButton.Location = new System.Drawing.Point(0, 240);
			this.PlayButton.Margin = new System.Windows.Forms.Padding(0);
			this.PlayButton.Name = "PlayButton";
			this.PlayButton.Size = new System.Drawing.Size(67, 40);
			this.PlayButton.TabIndex = 2;
			this.PlayButton.UseVisualStyleBackColor = false;
			this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
			// 
			// EditButton
			// 
			this.EditButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.EditButton.FlatAppearance.BorderSize = 0;
			this.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.EditButton.Image = ((System.Drawing.Image)(resources.GetObject("EditButton.Image")));
			this.EditButton.Location = new System.Drawing.Point(133, 240);
			this.EditButton.Margin = new System.Windows.Forms.Padding(0);
			this.EditButton.Name = "EditButton";
			this.EditButton.Size = new System.Drawing.Size(67, 40);
			this.EditButton.TabIndex = 3;
			this.EditButton.UseVisualStyleBackColor = false;
			this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
			// 
			// ImageAddButton
			// 
			this.ImageAddButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.ImageAddButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ImageAddButton.BackgroundImage")));
			this.ImageAddButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.ImageAddButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.ImageAddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ImageAddButton.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.ImageAddButton.Location = new System.Drawing.Point(170, 170);
			this.ImageAddButton.Name = "ImageAddButton";
			this.ImageAddButton.Size = new System.Drawing.Size(30, 30);
			this.ImageAddButton.TabIndex = 19;
			this.ImageAddButton.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this.ImageAddButton.UseVisualStyleBackColor = false;
			this.ImageAddButton.Click += new System.EventHandler(this.ImageAddButton_Click);
			// 
			// ContentButton
			// 
			this.ContentButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.ContentButton.FlatAppearance.BorderSize = 0;
			this.ContentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ContentButton.Image = ((System.Drawing.Image)(resources.GetObject("ContentButton.Image")));
			this.ContentButton.Location = new System.Drawing.Point(67, 240);
			this.ContentButton.Margin = new System.Windows.Forms.Padding(0);
			this.ContentButton.Name = "ContentButton";
			this.ContentButton.Size = new System.Drawing.Size(66, 40);
			this.ContentButton.TabIndex = 20;
			this.ContentButton.UseVisualStyleBackColor = false;
			this.ContentButton.Click += new System.EventHandler(this.ContentButton_Click);
			// 
			// PlaylistControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDark;
			this.Controls.Add(this.TitleLabel);
			this.Controls.Add(this.ContentButton);
			this.Controls.Add(this.ImageAddButton);
			this.Controls.Add(this.EditButton);
			this.Controls.Add(this.PlayButton);
			this.Controls.Add(this.ImageBox);
			this.Margin = new System.Windows.Forms.Padding(35);
			this.Name = "PlaylistControl";
			this.Size = new System.Drawing.Size(200, 280);
			this.EnabledChanged += new System.EventHandler(this.PlaylistControl_EnabledChanged);
			((System.ComponentModel.ISupportInitialize)(this.ImageBox)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox ImageBox;
		private System.Windows.Forms.Button PlayButton;
		private System.Windows.Forms.Button EditButton;
		private System.Windows.Forms.Button ImageAddButton;
		private System.Windows.Forms.Button ContentButton;
		public System.Windows.Forms.Label TitleLabel;
	}
}
