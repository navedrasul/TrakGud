using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TrakGud.DAL.Models.GlobalSettings
{
[Table("gs__UserSettings")]	public class UserSettings
	{
		public int userId { get; set; }
		public int? currentThemeId { get; set; }

		public UserSettings() { }


		public UserSettings(int userId, int? currentThemeId = default)		{
			this.userId = userId;
			this.currentThemeId = currentThemeId;
		}
	}
}