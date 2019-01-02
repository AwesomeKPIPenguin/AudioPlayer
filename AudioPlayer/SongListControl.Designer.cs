namespace AudioPlayer {
	partial class SongListControl {
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
			this.Panel = new System.Windows.Forms.FlowLayoutPanel();
			this.SuspendLayout();
			// 
			// Panel
			// 
			this.Panel.AutoScroll = true;
			this.Panel.Location = new System.Drawing.Point(0, 0);
			this.Panel.Name = "Panel";
			this.Panel.Size = new System.Drawing.Size(600, 150);
			this.Panel.TabIndex = 0;
			// 
			// SongListControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.Panel);
			this.Name = "SongListControl";
			this.Size = new System.Drawing.Size(600, 150);
			this.ResumeLayout(false);

		}

		#endregion

		public System.Windows.Forms.FlowLayoutPanel Panel;
	}
}
