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
			this.footerRoundedPanel = new AutoCaptivePortalLogin.CustomUI.RoundedPanel();
			this.linkedinButton = new AutoCaptivePortalLogin.CustomUI.ModernButton();
			this.githubButton = new AutoCaptivePortalLogin.CustomUI.ModernButton();
			this.instagramButton = new AutoCaptivePortalLogin.CustomUI.ModernButton();
			this.emailMeButton = new AutoCaptivePortalLogin.CustomUI.ModernButton();
			this.reportBugButton = new AutoCaptivePortalLogin.CustomUI.ModernButton();
			this.roundedPanel1 = new AutoCaptivePortalLogin.CustomUI.RoundedPanel();
			this.refreshButton = new AutoCaptivePortalLogin.CustomUI.ModernButton();
			this.label1 = new System.Windows.Forms.Label();
			this.manageProfilesButton = new AutoCaptivePortalLogin.CustomUI.ModernButton();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.footerRoundedPanel.SuspendLayout();
			this.roundedPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// footerRoundedPanel
			// 
			this.footerRoundedPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.footerRoundedPanel.Controls.Add(this.linkedinButton);
			this.footerRoundedPanel.Controls.Add(this.githubButton);
			this.footerRoundedPanel.Controls.Add(this.instagramButton);
			this.footerRoundedPanel.Controls.Add(this.emailMeButton);
			this.footerRoundedPanel.Controls.Add(this.reportBugButton);
			this.footerRoundedPanel.CornerRadius = 45;
			this.footerRoundedPanel.Location = new System.Drawing.Point(12, 430);
			this.footerRoundedPanel.Name = "footerRoundedPanel";
			this.footerRoundedPanel.Size = new System.Drawing.Size(810, 54);
			this.footerRoundedPanel.TabIndex = 6;
			// 
			// linkedinButton
			// 
			this.linkedinButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
			this.linkedinButton.BorderRadius = 10;
			this.linkedinButton.centerIcon = false;
			this.linkedinButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.linkedinButton.FlatAppearance.BorderSize = 0;
			this.linkedinButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.linkedinButton.Font = new System.Drawing.Font("Segoe UI", 8.25F);
			this.linkedinButton.ForeColor = System.Drawing.Color.Black;
			this.linkedinButton.hoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(229)))), ((int)(((byte)(236)))));
			this.linkedinButton.iconChar = null;
			this.linkedinButton.iconColor = System.Drawing.Color.Black;
			this.linkedinButton.iconFont = AutoCaptivePortalLogin.CustomUI.IconFont.solid;
			this.linkedinButton.IconHeight = 20;
			this.linkedinButton.IconWidth = 20;
			this.linkedinButton.Location = new System.Drawing.Point(106, 14);
			this.linkedinButton.Margin = new System.Windows.Forms.Padding(12);
			this.linkedinButton.Name = "linkedinButton";
			this.linkedinButton.normalColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
			this.linkedinButton.Padding = new System.Windows.Forms.Padding(2);
			this.linkedinButton.Size = new System.Drawing.Size(28, 28);
			this.linkedinButton.TabIndex = 4;
			this.linkedinButton.Text = " ";
			this.linkedinButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.linkedinButton.UseVisualStyleBackColor = false;
			this.linkedinButton.Click += new System.EventHandler(this.linkedinButton_Click);
			// 
			// githubButton
			// 
			this.githubButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
			this.githubButton.BorderRadius = 10;
			this.githubButton.centerIcon = false;
			this.githubButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.githubButton.FlatAppearance.BorderSize = 0;
			this.githubButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.githubButton.Font = new System.Drawing.Font("Segoe UI", 8.25F);
			this.githubButton.ForeColor = System.Drawing.Color.Black;
			this.githubButton.hoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(229)))), ((int)(((byte)(236)))));
			this.githubButton.iconChar = null;
			this.githubButton.iconColor = System.Drawing.Color.Black;
			this.githubButton.iconFont = AutoCaptivePortalLogin.CustomUI.IconFont.solid;
			this.githubButton.IconHeight = 20;
			this.githubButton.IconWidth = 20;
			this.githubButton.Location = new System.Drawing.Point(66, 14);
			this.githubButton.Margin = new System.Windows.Forms.Padding(12);
			this.githubButton.Name = "githubButton";
			this.githubButton.normalColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
			this.githubButton.Padding = new System.Windows.Forms.Padding(2);
			this.githubButton.Size = new System.Drawing.Size(28, 28);
			this.githubButton.TabIndex = 3;
			this.githubButton.Text = " ";
			this.githubButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.githubButton.UseVisualStyleBackColor = false;
			this.githubButton.Click += new System.EventHandler(this.githubButton_Click);
			// 
			// instagramButton
			// 
			this.instagramButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
			this.instagramButton.BorderRadius = 10;
			this.instagramButton.centerIcon = false;
			this.instagramButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.instagramButton.FlatAppearance.BorderSize = 0;
			this.instagramButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.instagramButton.Font = new System.Drawing.Font("Segoe UI", 8.25F);
			this.instagramButton.ForeColor = System.Drawing.Color.Black;
			this.instagramButton.hoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(229)))), ((int)(((byte)(236)))));
			this.instagramButton.iconChar = null;
			this.instagramButton.iconColor = System.Drawing.Color.Black;
			this.instagramButton.iconFont = AutoCaptivePortalLogin.CustomUI.IconFont.solid;
			this.instagramButton.IconHeight = 20;
			this.instagramButton.IconWidth = 20;
			this.instagramButton.Location = new System.Drawing.Point(26, 14);
			this.instagramButton.Margin = new System.Windows.Forms.Padding(12);
			this.instagramButton.Name = "instagramButton";
			this.instagramButton.normalColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
			this.instagramButton.Padding = new System.Windows.Forms.Padding(2);
			this.instagramButton.Size = new System.Drawing.Size(28, 28);
			this.instagramButton.TabIndex = 2;
			this.instagramButton.Text = " ";
			this.instagramButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.instagramButton.UseVisualStyleBackColor = false;
			this.instagramButton.Click += new System.EventHandler(this.instagramButton_Click);
			// 
			// emailMeButton
			// 
			this.emailMeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
			this.emailMeButton.BorderRadius = 10;
			this.emailMeButton.centerIcon = false;
			this.emailMeButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.emailMeButton.FlatAppearance.BorderSize = 0;
			this.emailMeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.emailMeButton.Font = new System.Drawing.Font("Segoe UI", 8.25F);
			this.emailMeButton.ForeColor = System.Drawing.Color.Black;
			this.emailMeButton.hoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(229)))), ((int)(((byte)(236)))));
			this.emailMeButton.iconChar = "";
			this.emailMeButton.iconColor = System.Drawing.Color.Black;
			this.emailMeButton.iconFont = AutoCaptivePortalLogin.CustomUI.IconFont.solid;
			this.emailMeButton.IconHeight = 20;
			this.emailMeButton.IconWidth = 20;
			this.emailMeButton.Location = new System.Drawing.Point(652, 14);
			this.emailMeButton.Margin = new System.Windows.Forms.Padding(12);
			this.emailMeButton.Name = "emailMeButton";
			this.emailMeButton.normalColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
			this.emailMeButton.Padding = new System.Windows.Forms.Padding(2);
			this.emailMeButton.Size = new System.Drawing.Size(91, 28);
			this.emailMeButton.TabIndex = 1;
			this.emailMeButton.Text = "E-Mail Me";
			this.emailMeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.emailMeButton.UseVisualStyleBackColor = false;
			this.emailMeButton.Click += new System.EventHandler(this.emailMeButton_Click);
			// 
			// reportBugButton
			// 
			this.reportBugButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
			this.reportBugButton.BorderRadius = 10;
			this.reportBugButton.centerIcon = false;
			this.reportBugButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.reportBugButton.FlatAppearance.BorderSize = 0;
			this.reportBugButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.reportBugButton.Font = new System.Drawing.Font("Segoe UI", 8.25F);
			this.reportBugButton.ForeColor = System.Drawing.Color.Black;
			this.reportBugButton.hoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(229)))), ((int)(((byte)(236)))));
			this.reportBugButton.iconChar = null;
			this.reportBugButton.iconColor = System.Drawing.Color.Black;
			this.reportBugButton.iconFont = AutoCaptivePortalLogin.CustomUI.IconFont.solid;
			this.reportBugButton.IconHeight = 20;
			this.reportBugButton.IconWidth = 20;
			this.reportBugButton.Location = new System.Drawing.Point(757, 14);
			this.reportBugButton.Margin = new System.Windows.Forms.Padding(12);
			this.reportBugButton.Name = "reportBugButton";
			this.reportBugButton.normalColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
			this.reportBugButton.Padding = new System.Windows.Forms.Padding(2);
			this.reportBugButton.Size = new System.Drawing.Size(28, 28);
			this.reportBugButton.TabIndex = 0;
			this.reportBugButton.Text = " ";
			this.reportBugButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.reportBugButton.UseVisualStyleBackColor = false;
			this.reportBugButton.Click += new System.EventHandler(this.reportBugButton_Click);
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
			this.refreshButton.centerIcon = false;
			this.refreshButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.refreshButton.FlatAppearance.BorderSize = 0;
			this.refreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.refreshButton.Font = new System.Drawing.Font("Segoe UI", 8.25F);
			this.refreshButton.ForeColor = System.Drawing.Color.Black;
			this.refreshButton.hoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(229)))), ((int)(((byte)(236)))));
			this.refreshButton.iconChar = null;
			this.refreshButton.iconColor = System.Drawing.Color.Black;
			this.refreshButton.iconFont = AutoCaptivePortalLogin.CustomUI.IconFont.solid;
			this.refreshButton.IconHeight = 20;
			this.refreshButton.IconWidth = 20;
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
			this.manageProfilesButton.centerIcon = false;
			this.manageProfilesButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.manageProfilesButton.FlatAppearance.BorderSize = 0;
			this.manageProfilesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.manageProfilesButton.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.manageProfilesButton.ForeColor = System.Drawing.Color.Black;
			this.manageProfilesButton.hoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(229)))), ((int)(((byte)(236)))));
			this.manageProfilesButton.iconChar = null;
			this.manageProfilesButton.iconColor = System.Drawing.Color.Black;
			this.manageProfilesButton.iconFont = AutoCaptivePortalLogin.CustomUI.IconFont.solid;
			this.manageProfilesButton.IconHeight = 20;
			this.manageProfilesButton.IconWidth = 20;
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
			this.Controls.Add(this.footerRoundedPanel);
			this.Controls.Add(this.roundedPanel1);
			this.DoubleBuffered = true;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.Text = "AutoCaptivePortal";
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
			this.footerRoundedPanel.ResumeLayout(false);
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
		private AutoCaptivePortalLogin.CustomUI.RoundedPanel footerRoundedPanel;
		private AutoCaptivePortalLogin.CustomUI.ModernButton reportBugButton;
		private AutoCaptivePortalLogin.CustomUI.ModernButton emailMeButton;
		private AutoCaptivePortalLogin.CustomUI.ModernButton instagramButton;
		private AutoCaptivePortalLogin.CustomUI.ModernButton githubButton;
		private AutoCaptivePortalLogin.CustomUI.ModernButton linkedinButton;
	}
}

