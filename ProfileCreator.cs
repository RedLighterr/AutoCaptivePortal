using AutoCaptivePortalLogin.CustomUI;
using Login;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace AutoCaptivePortalLogin
{
	public partial class ProfileCreator : Form
	{
		private Form1 form1;
		private TextBox txtProfileName, txtLoginUrl, txtSubmitSelector;
		private CheckBox chkIsIdButton;
		private CheckBox chkAutoDetectUrl;
		private DataGridView dgvInputs, dgvCheckboxes;
		private ModernButton btnSaveProfile;
		private ComboBox cmbProfiles;
		private ComboBox cmbSubmitSelectorType;
		private ModernButton btnLoadProfile;

		public ProfileCreator()
		{
			this.BackColor = Color.FromArgb(18, 18, 18);
			this.ForeColor = Color.White;

			this.Width = 1000;
			this.Height = 900;

			this.FormBorderStyle = FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = true; // İsteğe bağlı
			this.ControlBox = true;  // Üstteki kapatma butonları için

			InitializeControls();

			InitializeComponent();
		}


		private void InitializeControls()
		{
			Label lblProfile = new Label { Text = "Profile Name:", Left = 20, Top = 40, Width = 100 };
			txtProfileName = new TextBox { Left = 130, Top = 40, Width = 200, BackColor = Color.FromArgb(40, 40, 40), ForeColor = Color.White };

			Label lblLoginUrl = new Label { Text = "Login URL:", Left = 20, Top = 80, Width = 100};
			txtLoginUrl = new TextBox { Left = 130, Top = 80, Width = 200, BackColor = Color.FromArgb(40, 40, 40), ForeColor = Color.White };

			chkAutoDetectUrl = new CheckBox
			{
				Text = "Auto Find Login URL",
				Left = 350,
				Top = 80,
				Width = 200
			};
			this.Controls.Add(chkAutoDetectUrl);

			Label lblSubmit = new Label { Text = "Submit Button ID/Name:", Left = 20, Top = 120, Width = 100 };
			txtSubmitSelector = new TextBox { Left = 130, Top = 120, Width = 200, BackColor = Color.FromArgb(40, 40, 40), ForeColor = Color.White };

			cmbSubmitSelectorType = new ComboBox
			{
				Left = 350,
				Top = 120,
				Width = 100,
				DropDownStyle = ComboBoxStyle.DropDownList
			};
			cmbSubmitSelectorType.DataSource = Enum.GetValues(typeof(SelectorType));
			this.Controls.Add(cmbSubmitSelectorType);

			Label lblInputs = new Label { Text = "Input Fields (Selector, IsId, Value):", Left = 20, Top = 150, Width = 300 };
			dgvInputs = new DataGridView
			{
				Left = 20,
				Top = 180,
				Width = 780,
				Height = 150,
				AllowUserToAddRows = true,
				ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize,
				ForeColor = Color.White,
				BackgroundColor = Color.FromArgb(40, 40, 40),
				GridColor = Color.FromArgb(87, 87, 87)
			};
			dgvInputs.DefaultCellStyle.SelectionForeColor = Color.White;
			dgvInputs.DefaultCellStyle.SelectionBackColor = Color.FromArgb(87, 87, 87);
			dgvInputs.DefaultCellStyle.BackColor = Color.FromArgb(40, 40, 40);
			dgvInputs.DefaultCellStyle.ForeColor = Color.White;

			// Başlık stilleri
			dgvInputs.EnableHeadersVisualStyles = false;
			dgvInputs.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(87, 87, 87);
			dgvInputs.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
			dgvInputs.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Regular);
			dgvInputs.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dgvInputs.ColumnHeadersHeight = 35;

			dgvInputs.Columns.Add("Selector", "Selector");
			dgvInputs.Columns.Add(new DataGridViewCheckBoxColumn { Name = "IsId", HeaderText = "Is ID" });
			dgvInputs.Columns.Add("Value", "Value");

			Label lblCheckboxes = new Label { Text = "Checkbox Fields (Selector, IsId, Checked):", Left = 20, Top = 350, Width = 300 };
			dgvCheckboxes = new DataGridView
			{
				Left = 20,
				Top = 380,
				Width = 780,
				Height = 150,
				AllowUserToAddRows = true,
				ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize,
				ForeColor = Color.White,
				BackgroundColor = Color.FromArgb(40, 40, 40),
				GridColor = Color.FromArgb(87, 87, 87)
			};
			dgvCheckboxes.Columns.Add("Selector", "Selector");
			dgvCheckboxes.Columns.Add(new DataGridViewCheckBoxColumn { Name = "IsId", HeaderText = "Is ID" });
			dgvCheckboxes.Columns.Add(new DataGridViewCheckBoxColumn { Name = "Checked", HeaderText = "Checked" });

			dgvCheckboxes.DefaultCellStyle.SelectionForeColor = Color.White;
			dgvCheckboxes.DefaultCellStyle.SelectionBackColor = Color.FromArgb(87, 87, 87);
			dgvCheckboxes.DefaultCellStyle.BackColor = Color.FromArgb(40, 40, 40);
			dgvCheckboxes.DefaultCellStyle.ForeColor = Color.White;

			// Başlık stilleri
			dgvCheckboxes.EnableHeadersVisualStyles = false;
			dgvCheckboxes.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(87, 87, 87);
			dgvCheckboxes.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
			dgvCheckboxes.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Regular);
			dgvCheckboxes.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dgvCheckboxes.ColumnHeadersHeight = 35;

			btnSaveProfile = new ModernButton
			{
				Text = "Save Profile",
				Left = 20,
				Top = 560,
				Width = 200,
				Height = 50,
				BorderRadius = 12,
				ForeColor = Color.Black,
				hoverColor = Color.FromArgb(29, 229, 236),
				normalColor = Color.FromArgb(116, 236, 240)
			};
			btnSaveProfile.Click += btnSaveProfile_Click;

			Label lblSelect = new Label { Text = "Saved Profiles:", Left = 20, Top = 10, Width = 100 };
			cmbProfiles = new ComboBox { Left = 130, Top = 10, Width = 200, BackColor = Color.FromArgb(40, 40, 40), ForeColor = Color.White };
			btnLoadProfile = new ModernButton { Text = "Load Profile", Left = 350, Top = 10, Width = 80, normalColor = Color.FromArgb(116, 236, 240), hoverColor = Color.FromArgb(29, 229, 236), BorderRadius = 12 };
			btnLoadProfile.Click += btnLoadProfile_Click;

			this.Controls.Add(lblSelect);
			this.Controls.Add(cmbProfiles);
			this.Controls.Add(btnLoadProfile);

			// Form açıldığında klasördeki profilleri yükle
			LoadProfilesFromFolder();

			// Form'a elemanları ekle
			this.Controls.Add(lblProfile);
			this.Controls.Add(txtProfileName);
			this.Controls.Add(lblLoginUrl);
			this.Controls.Add(txtLoginUrl);
			this.Controls.Add(lblSubmit);
			this.Controls.Add(txtSubmitSelector);
			this.Controls.Add(chkIsIdButton);
			this.Controls.Add(lblInputs);
			this.Controls.Add(dgvInputs);
			this.Controls.Add(lblCheckboxes);
			this.Controls.Add(dgvCheckboxes);
			this.Controls.Add(btnSaveProfile);
		}

		private void btnSaveProfile_Click(object sender, EventArgs e)
		{
			var profile = new LoginProfile
			{
				ProfileName = txtProfileName.Text.Trim(),
				LoginUrl = txtLoginUrl.Text.Trim(),
				SubmitButtonSelector = txtSubmitSelector.Text.Trim(),
				SubmitButtonSelectorType = (SelectorType)cmbSubmitSelectorType.SelectedItem,
				InputFields = new List<InputField>(),
				CheckBoxes = new List<CheckBoxField>(),
				AutoDetectLoginUrl = chkAutoDetectUrl.Checked
			};

			// INPUTS
			foreach (DataGridViewRow row in dgvInputs.Rows)
			{
				if (row.IsNewRow) continue;
				profile.InputFields.Add(new InputField
				{
					Selector = row.Cells["Selector"]?.Value?.ToString(),
					IsId = Convert.ToBoolean(row.Cells["IsId"]?.Value ?? false),
					Value = row.Cells["Value"]?.Value?.ToString()
				});
			}

			// CHECKBOXES
			foreach (DataGridViewRow row in dgvCheckboxes.Rows)
			{
				if (row.IsNewRow) continue;
				profile.CheckBoxes.Add(new CheckBoxField
				{
					Selector = row.Cells["Selector"]?.Value?.ToString(),
					IsId = Convert.ToBoolean(row.Cells["IsId"]?.Value ?? false),
					Checked = Convert.ToBoolean(row.Cells["Checked"]?.Value ?? false)
				});
			}

			SaveFileDialog save = new SaveFileDialog
			{
				Filter = "JSON File|*.json",
				FileName = profile.ProfileName + ".json"
			};

			if (save.ShowDialog() == DialogResult.OK)
			{
				string folder = "Profiles";
				if (!Directory.Exists(folder))
					Directory.CreateDirectory(folder);

				string json = JsonSerializer.Serialize(profile, new JsonSerializerOptions { WriteIndented = true });
				File.WriteAllText(Path.Combine(folder, profile.ProfileName + ".json"), json);

				MessageBox.Show("Profile saved succesfully!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void btnLoadProfile_Click(object sender, EventArgs e)
		{
			if (cmbProfiles.SelectedItem == null) return;

			string filePath = Path.Combine("Profiles", cmbProfiles.SelectedItem.ToString());
			if (!File.Exists(filePath)) return;

			string json = File.ReadAllText(filePath);
			var profile = JsonSerializer.Deserialize<LoginProfile>(json);

			// Form alanlarına yükle
			txtProfileName.Text = profile.ProfileName;
			txtLoginUrl.Text = profile.LoginUrl;
			txtSubmitSelector.Text = profile.SubmitButtonSelector;
			cmbSubmitSelectorType.SelectedItem = profile.SubmitButtonSelectorType;
			chkAutoDetectUrl.Checked = profile.AutoDetectLoginUrl;

			dgvInputs.Rows.Clear();
			foreach (var field in profile.InputFields)
			{
				dgvInputs.Rows.Add(field.Selector, field.IsId, field.Value);
			}

			dgvCheckboxes.Rows.Clear();
			foreach (var cb in profile.CheckBoxes)
			{
				dgvCheckboxes.Rows.Add(cb.Selector, cb.IsId, cb.Checked);
			}
		}

		public void LoadProfile(LoginProfile profile)
		{
			txtProfileName.Text = profile.ProfileName;
			txtLoginUrl.Text = profile.LoginUrl;
			txtSubmitSelector.Text = profile.SubmitButtonSelector;
			cmbSubmitSelectorType.SelectedItem = profile.SubmitButtonSelectorType;
			chkAutoDetectUrl.Checked = profile.AutoDetectLoginUrl;

			dgvInputs.Rows.Clear();
			foreach (var field in profile.InputFields)
				dgvInputs.Rows.Add(field.Selector, field.IsId, field.Value);

			dgvCheckboxes.Rows.Clear();
			foreach (var cb in profile.CheckBoxes)
				dgvCheckboxes.Rows.Add(cb.Selector, cb.IsId, cb.Checked);
		}

		public void LoadProfilesFromFolder()
		{
			cmbProfiles.Items.Clear();
			string folder = "Profiles";
			if (!Directory.Exists(folder))
				Directory.CreateDirectory(folder);

			var files = Directory.GetFiles(folder, "*.json");
			foreach (var file in files)
			{
				cmbProfiles.Items.Add(Path.GetFileName(file));
			}
		}
	}
}
