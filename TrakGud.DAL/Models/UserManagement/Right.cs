using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TrakGud.DAL.Models.UserManagement
{
[Table("um__Right")]	public class Right
	{
		public int id { get; set; }
		public string title { get; set; }
		public bool isActive { get; set; }
		public DateTime addTS { get; set; }
		public int adderId { get; set; }
		public string desc { get; set; }
		public int? modderId { get; set; }
		public bool? isRemoved { get; set; }
		public DateTime? modTS { get; set; }

		public Right() { }


		public Right(int id, string title, bool isActive, DateTime addTS, int adderId, string desc = default, int? modderId = default, bool? isRemoved = default, DateTime? modTS = default)		{
			this.id = id;
			this.title = title;
			this.isActive = isActive;
			this.addTS = addTS;
			this.adderId = adderId;
			this.desc = desc;
			this.modderId = modderId;
			this.isRemoved = isRemoved;
			this.modTS = modTS;
		}
	}
}