using System.Collections.Generic;

namespace AutoCaptivePortalLogin
{
	public class LoginProfile
	{
		public string ProfileName { get; set; }
		public List<InputField> InputFields { get; set; } = new List<InputField>();
		public List<CheckBoxField> CheckBoxes { get; set; } = new List<CheckBoxField>();

		public string SubmitButtonSelector { get; set; }
		public SelectorType SubmitButtonSelectorType { get; set; }
		public bool IsIdButton { get; set; }

		public string LoginUrl { get; set; }
		public bool AutoDetectLoginUrl { get; set; }
	}

	public class InputField
	{
		public string Selector { get; set; } // ID veya Name
		public bool IsId { get; set; }
		public string Value { get; set; }
	}

	public class CheckBoxField
	{
		public string Selector { get; set; }
		public bool IsId { get; set; }
		public bool Checked { get; set; }
	}

	public enum SelectorType
	{
		Id,
		Name,
		XPath
	}
}
