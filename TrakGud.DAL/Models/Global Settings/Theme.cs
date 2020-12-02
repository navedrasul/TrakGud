using System;
using System.Collections.Generic;
using System.Text;

namespace TrakGud.DAL.Models.Global Settings
{
	public class Theme
	{
		public int id { get; set; }
		public string title { get; set; }
		public string themePath { get; set; }
		public string desc { get; set; }

		public Theme(int id_, string title_, string themePath_, string desc_ = default)		{
			this.id = id_;
			this.title = title_;
			this.themePath = themePath_;
			this.desc = desc_;
		}
	}
}