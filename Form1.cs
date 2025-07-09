using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoCaptivePortalLogin;
using AutoCaptivePortalLogin.CustomUI;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using Svg;

namespace Login
{
	public partial class Form1 : Form
	{
		#region URLs
		string emailUrl = "mailto:mfurkanyuce5@gmail.com?subject=Auto%20Captive%20Login";
		string githubIssues = "https://github.com/RedLighterr/AutoCaptivePortal/issues";
		string instagramUrl = "https://www.instagram.com/mfurkanyuce_/";
		string githubUrl = "https://github.com/RedLighterr";
		string linkedinUrl = "https://www.linkedin.com/in/muhammedfurkanyuce/";
		#endregion

		private ProfileCreator profileForm;
		IWebDriver driver;

		public Form1()
		{
			this.FormBorderStyle = FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = true;
			this.ControlBox = true;

			this.BackColor = Color.FromArgb(18, 18, 18);

			panelProfiles = new FlowLayoutPanel
			{
				Location = new Point(75, 100),
				Height = 325,
				Width = 700,
				AutoScroll = true
			};

			this.Controls.Add(panelProfiles);

			LoadProfileButtons();

			this.Invalidate();

			InitializeComponent();
		}

		public void LoadProfileButtons()
		{
			panelProfiles.Controls.Clear();

			string folder = "Profiles";
			if (!Directory.Exists(folder))
				Directory.CreateDirectory(folder);

			var files = Directory.GetFiles(folder, "*.json");
			foreach (var file in files)
			{
				string fileName = Path.GetFileNameWithoutExtension(file);
				var btn = new ModernButton
				{
					Text = fileName,
					Width = 200,
					Height = 40,
					Font = new Font("Segoe UI", 12f, FontStyle.Regular),
					Tag = file // tam yol
				};
				btn.Click += ProfileButton_Click;
				GetAdjustedFont(btn, btn.Text, btn.Font);
				panelProfiles.Controls.Add(btn);
			}
		}

		private Font GetAdjustedFont(Control control, string text, Font originalFont)
		{
			Size proposedSize = control.ClientSize;
			int fontSize = (int)originalFont.Size;

			using (Graphics g = control.CreateGraphics())
			{
				while (fontSize > 6)
				{
					Font testFont = new Font(originalFont.FontFamily, fontSize, originalFont.Style);
					SizeF textSize = g.MeasureString(text, testFont);

					if (textSize.Width <= proposedSize.Width && textSize.Height <= proposedSize.Height)
						return testFont;

					fontSize--;
				}
			}

			return new Font(originalFont.FontFamily, 6);
		}

		private void ProfileButton_Click(object sender, EventArgs e)
		{
			var btn = sender as ModernButton;
			this.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular);
			btn.Padding = new Padding(20, 10, 20, 10);
			string filePath = btn.Tag as string;
			if (!File.Exists(filePath)) return;

			string json = File.ReadAllText(filePath);
			LoginProfile profile = JsonSerializer.Deserialize<LoginProfile>(json);

			LoginCaptive(profile);
		}

		async void LoginCaptive(LoginProfile profile)
		{
			FirefoxDriverService service = FirefoxDriverService.CreateDefaultService();
			service.HideCommandPromptWindow = true; // 🔹 Konsol penceresini gizle

			FirefoxOptions options = new FirefoxOptions();

			driver = new FirefoxDriver(service, options);  // Firefox kullanımı

			driver.Manage().Window.Maximize();

			if (IsCaptivePortal())
			{
				driver.Navigate().GoToUrl("http://neverssl.com");

				await Task.Delay(1000);
			}
			else
			{
				driver.Navigate().GoToUrl(profile.LoginUrl);
			}

			if (!profile.AutoDetectLoginUrl)
				driver.Navigate().GoToUrl(profile.LoginUrl);

			await Task.Delay(1000);

			foreach (var inputField in profile.InputFields)
			{
				IWebElement inputFieldElement;

				if (inputField.IsId)
				{
					inputFieldElement = driver.FindElement(By.Id(inputField.Selector.ToString()));
				}
				else
				{
					inputFieldElement = driver.FindElement(By.Name(inputField.Selector.ToString()));
				}

				inputFieldElement.SendKeys(inputField.Value.ToString());
			}

			foreach (var checkBoxes in profile.CheckBoxes)
			{
				IWebElement checkboxElement;

				if (checkBoxes.IsId)
				{
					checkboxElement = driver.FindElement(By.Id(checkBoxes.Selector.ToString()));
				}
				else
				{
					checkboxElement = driver.FindElement(By.Name(checkBoxes.Selector.ToString()));
				}

				IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
				js.ExecuteScript("arguments[0].click();", checkboxElement);
			}

			IWebElement submitBtn;

			try
			{
				switch (profile.SubmitButtonSelectorType)
				{
					case SelectorType.Id:
						submitBtn = driver.FindElement(By.Id(profile.SubmitButtonSelector.ToString()));
						submitBtn.Click();
						break;
					case SelectorType.Name:
						submitBtn = driver.FindElement(By.Name(profile.SubmitButtonSelector.ToString().Trim()));
						submitBtn.Click();
						break;
					case SelectorType.XPath:
						string xpath = profile.SubmitButtonSelector.ToString();
						submitBtn = driver.FindElement(By.XPath(xpath));
						submitBtn.Click();
						break;
					default:
						submitBtn = driver.FindElement(By.Id(profile.SubmitButtonSelector.ToString()));
						break;
				}
			}
			catch (Exception)
			{
				try
				{
					var allButtons = driver.FindElements(By.TagName("button"));
					if (allButtons.Count == 1)
						allButtons[0].Click(); // Sayfada zaten tek buton varsa
					else
					{
						// Belki text'e göre filtrele
						var loginButton = allButtons.FirstOrDefault(b => b.Text.Contains("Bağlan") || b.Text.Contains("Giriş") || b.Text.Contains("Login"));
						loginButton?.Click();
					}
				}
				catch (Exception)
				{
					var allButtons = driver.FindElements(By.TagName("button"));
					if (allButtons.Count == 1)
						allButtons[0].Click(); // Sayfada zaten tek buton varsa
					else
					{
						// Belki text'e göre filtrele
						var loginButton = allButtons.FirstOrDefault(b => b.Text.Contains("Bağlan") || b.Text.Contains("Giriş") || b.Text.Contains("Login"));
						loginButton?.Click();
					}
				}
			}

			await Task.Delay(10000);

			driver.Quit();
		}

		private void manageProfilesButton_Click(object sender, EventArgs e)
		{
			if (profileForm == null || profileForm.IsDisposed)
			{
				profileForm = new ProfileCreator();
				profileForm.FormClosed += (s, args) => profileForm = null; // pencere kapanınca null'a çek
				profileForm.Show();
			}
			else
			{
				profileForm.Close(); // açıksa kapat
			}
		}

		public bool IsCaptivePortal()
		{
			try
			{
				var client = new WebClient();
				string html = client.DownloadString("http://clients3.google.com/generate_204");
				return !string.IsNullOrEmpty(html);
			}
			catch
			{
				return true;
			}
		}

		private void refreshButton_Click(object sender, EventArgs e)
		{
			LoadProfileButtons();
		}

		private void Form1_Paint(object sender, PaintEventArgs e)
		{
			reportBugButton.Text = " ";
			reportBugButton.Font = new Font("Segoe UI", 10f, FontStyle.Regular);
			reportBugButton.iconFont = IconFont.solid;
			reportBugButton.iconColor = Color.FromArgb(0, 0, 0);
			reportBugButton.iconChar = "bug";
			reportBugButton.centerIcon = true;
			reportBugButton.IconWidth = 22;
			reportBugButton.IconHeight = 22;

			instagramButton.iconFont = IconFont.brands;
			instagramButton.iconChar = "instagram";
			instagramButton.centerIcon = true;
			instagramButton.IconWidth = 22;
			instagramButton.IconHeight = 22;

			githubButton.iconFont = IconFont.brands;
			githubButton.iconChar = "github";
			githubButton.centerIcon = true;
			githubButton.IconWidth = 22;
			githubButton.IconHeight = 22;

			linkedinButton.iconFont = IconFont.brands;
			linkedinButton.iconChar = "linkedin";
			linkedinButton.centerIcon = true;
			linkedinButton.IconWidth = 22;
			linkedinButton.IconHeight = 22;

			emailMeButton.iconChar = "envelope";

			footerRoundedPanel.Controls.Add(reportBugButton);
		}

		private void reportBugButton_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start(githubIssues);
		}

		private void emailMeButton_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start(emailUrl);
		}

		private void instagramButton_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start(instagramUrl);
		}

		private void githubButton_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start(githubUrl);
		}

		private void linkedinButton_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start(linkedinUrl);
		}
	}
}
