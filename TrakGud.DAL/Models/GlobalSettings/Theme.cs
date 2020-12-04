using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TrakGud.DAL.Models.GlobalSettings
{
[Table("gs__Theme")]	public class Theme
	{
		public int id { get; set; }
		public string title { get; set; }
		public string themePath { get; set; }
		public string desc { get; set; }

		public Theme() { }


		public Theme(int id, string title, string themePath, string desc = default)		{
			this.id = id;
			this.title = title;
			this.themePath = themePath;
			this.desc = desc;
		}
	}
}