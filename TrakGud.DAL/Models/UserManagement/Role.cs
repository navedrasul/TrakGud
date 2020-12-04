using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TrakGud.DAL.Models.UserManagement
{
[Table("um__Role")]	public class Role
	{
		public int id { get; set; }
		public string title { get; set; }
		public DateTime addTS { get; set; }
		public int adderId { get; set; }
		public int? modderId { get; set; }
		public bool? isRemoved { get; set; }
		public DateTime? modTS { get; set; }

		public Role() { }


		public Role(int id, string title, DateTime addTS, int adderId, int? modderId = default, bool? isRemoved = default, DateTime? modTS = default)		{
			this.id = id;
			this.title = title;
			this.addTS = addTS;
			this.adderId = adderId;
			this.modderId = modderId;
			this.isRemoved = isRemoved;
			this.modTS = modTS;
		}
	}
}