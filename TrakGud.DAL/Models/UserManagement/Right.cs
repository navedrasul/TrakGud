using System;
using System.Collections.Generic;
using System.Text;

namespace TrakGud.DAL.Models.UserManagement
{
	public class Right
	{
		public int id { get; set; }
		public string title { get; set; }
		public bool isActive { get; set; }
		public DateTime addTS { get; set; }
		public int adderId { get; set; }
		public string desc { get; set; }
		public int? modderId { get; set; }
		public bool? isRemoved { get; set; }
		public DateTime modTS { get; set; }

		public Right(int id_, string title_, bool isActive_, DateTime addTS_, int adderId_, string desc_ = default, int? modderId_ = default, bool? isRemoved_ = default, DateTime modTS_ = default)		{
			this.id = id_;
			this.title = title_;
			this.isActive = isActive_;
			this.addTS = addTS_;
			this.adderId = adderId_;
			this.desc = desc_;
			this.modderId = modderId_;
			this.isRemoved = isRemoved_;
			this.modTS = modTS_;
		}
	}
}