namespace Login
{
	partial class Form1
	{
		/// <summary>
		///Gerekli tasarımcı değişkeni.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///Kullanılan tüm kaynakları temizleyin.
		/// </summary>
		///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer üretilen kod

		/// <summary>
		/// Tasarımcı desteği için gerekli metot - bu metodun 
		///içeriğini kod düzenleyici ile değiştirmeyin.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.roundedPanel2 = new AutoCaptivePortalLogin.CustomUI.RoundedPanel();
			this.reportBugButton = new AutoCaptivePortalLogin.CustomUI.ModernButton();
			this.roundedPanel1 = new AutoCaptivePortalLogin.CustomUI.RoundedPanel();
			this.refreshButton = new AutoCaptivePortalLogin.CustomUI.ModernButton();
			this.label1 = new System.Windows.Forms.Label();
			this.manageProfilesButton = new AutoCaptivePortalLogin.CustomUI.ModernButton();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.roundedPanel2.SuspendLayout();
			this.roundedPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// roundedPanel2
			// 
			this.roundedPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.roundedPanel2.Controls.Add(this.reportBugButton);
			this.roundedPanel2.CornerRadius = 45;
			this.roundedPanel2.Location = new System.Drawing.Point(12, 435);
			this.roundedPanel2.Name = "roundedPanel2";
			this.roundedPanel2.Size = new System.Drawing.Size(810, 44);
			this.roundedPanel2.TabIndex = 6;
			// 
			// reportBugButton
			// 
			this.reportBugButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
			this.reportBugButton.BorderRadius = 10;
			this.reportBugButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.reportBugButton.FlatAppearance.BorderSize = 0;
			this.reportBugButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.reportBugButton.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.reportBugButton.ForeColor = System.Drawing.Color.Black;
			this.reportBugButton.hoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(229)))), ((int)(((byte)(236)))));
			this.reportBugButton.Location = new System.Drawing.Point(654, 12);
			this.reportBugButton.Margin = new System.Windows.Forms.Padding(12);
			this.reportBugButton.Name = "reportBugButton";
			this.reportBugButton.normalColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
			this.reportBugButton.Padding = new System.Windows.Forms.Padding(2);
			this.reportBugButton.Size = new System.Drawing.Size(144, 23);
			this.reportBugButton.TabIndex = 0;
			this.reportBugButton.Text = "Report Bug";
			this.reportBugButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.reportBugButton.UseVisualStyleBackColor = false;
			// 
			// roundedPanel1
			// 
			this.roundedPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.roundedPanel1.Controls.Add(this.refreshButton);
			this.roundedPanel1.Controls.Add(this.label1);
			this.roundedPanel1.Controls.Add(this.manageProfilesButton);
			this.roundedPanel1.Controls.Add(this.pictureBox1);
			this.roundedPanel1.CornerRadius = 45;
			this.roundedPanel1.Location = new System.Drawing.Point(12, 12);
			this.roundedPanel1.Name = "roundedPanel1";
			this.roundedPanel1.Size = new System.Drawing.Size(810, 75);
			this.roundedPanel1.TabIndex = 3;
			// 
			// refreshButton
			// 
			this.refreshButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
			this.refreshButton.BorderRadius = 10;
			this.refreshButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.refreshButton.FlatAppearance.BorderSize = 0;
			this.refreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.refreshButton.Font = new System.Drawing.Font("Segoe UI", 8.25F);
			this.refreshButton.ForeColor = System.Drawing.Color.Black;
			this.refreshButton.hoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(229)))), ((int)(((byte)(236)))));
			this.refreshButton.Location = new System.Drawing.Point(733, 12);
			this.refreshButton.Margin = new System.Windows.Forms.Padding(12);
			this.refreshButton.Name = "refreshButton";
			this.refreshButton.normalColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
			this.refreshButton.Padding = new System.Windows.Forms.Padding(2);
			this.refreshButton.Size = new System.Drawing.Size(65, 48);
			this.refreshButton.TabIndex = 5;
			this.refreshButton.Text = "Refresh";
			this.refreshButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.refreshButton.UseVisualStyleBackColor = false;
			this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(255, 14);
			this.label1.Name = "label1";
			this.label1.Padding = new System.Windows.Forms.Padding(3);
			this.label1.Size = new System.Drawing.Size(299, 43);
			this.label1.TabIndex = 4;
			this.label1.Text = "Auto Captive Portal";
			// 
			// manageProfilesButton
			// 
			this.manageProfilesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
			this.manageProfilesButton.BorderRadius = 10;
			this.manageProfilesButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.manageProfilesButton.FlatAppearance.BorderSize = 0;
			this.manageProfilesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.manageProfilesButton.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.manageProfilesButton.ForeColor = System.Drawing.Color.Black;
			this.manageProfilesButton.hoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(229)))), ((int)(((byte)(236)))));
			this.manageProfilesButton.Location = new System.Drawing.Point(584, 12);
			this.manageProfilesButton.Margin = new System.Windows.Forms.Padding(12);
			this.manageProfilesButton.Name = "manageProfilesButton";
			this.manageProfilesButton.normalColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
			this.manageProfilesButton.Padding = new System.Windows.Forms.Padding(2);
			this.manageProfilesButton.Size = new System.Drawing.Size(140, 48);
			this.manageProfilesButton.TabIndex = 1;
			this.manageProfilesButton.Text = "Manage Profiles";
			this.manageProfilesButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.manageProfilesButton.UseVisualStyleBackColor = false;
			this.manageProfilesButton.Click += new System.EventHandler(this.manageProfilesButton_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(3, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(75, 75);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
			this.ClientSize = new System.Drawing.Size(834, 491);
			this.Controls.Add(this.roundedPanel2);
			this.Controls.Add(this.roundedPanel1);
			this.DoubleBuffered = true;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.Text = "AutoCaptivePortal";
			this.roundedPanel2.ResumeLayout(false);
			this.roundedPanel1.ResumeLayout(false);
			this.roundedPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.FlowLayoutPanel panelProfiles;
		private AutoCaptivePortalLogin.CustomUI.ModernButton manageProfilesButton;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private AutoCaptivePortalLogin.CustomUI.RoundedPanel roundedPanel1;
		private System.Windows.Forms.Label label1;
		private AutoCaptivePortalLogin.CustomUI.ModernButton refreshButton;
		private AutoCaptivePortalLogin.CustomUI.RoundedPanel roundedPanel2;
		private AutoCaptivePortalLogin.CustomUI.ModernButton reportBugButton;
	}
}

