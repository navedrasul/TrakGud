using System;
using System.Collections.Generic;
using System.Text;

namespace TrakGud.DAL.Models.GlobalSettings
{
	public class UserSettings
	{
		public int userId { get; set; }
		public int? currentThemeId { get; set; }

		public UserSettings(int userId_, int? currentThemeId_ = default)		{
			this.userId = userId_;
			this.currentThemeId = currentThemeId_;
		}
	}
}