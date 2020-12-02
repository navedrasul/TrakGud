using System;
using System.Collections.Generic;
using System.Text;

namespace TrakGud.DAL.Models.UserManagement
{
	public class Role
	{
		public int id { get; set; }
		public string title { get; set; }
		public DateTime addTS { get; set; }
		public int adderId { get; set; }
		public int? modderId { get; set; }
		public bool? isRemoved { get; set; }
		public DateTime modTS { get; set; }

		public Role(int id_, string title_, DateTime addTS_, int adderId_, int? modderId_ = default, bool? isRemoved_ = default, DateTime modTS_ = default)		{
			this.id = id_;
			this.title = title_;
			this.addTS = addTS_;
			this.adderId = adderId_;
			this.modderId = modderId_;
			this.isRemoved = isRemoved_;
			this.modTS = modTS_;
		}
	}
}