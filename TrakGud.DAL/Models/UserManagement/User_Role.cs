using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TrakGud.DAL.Models.UserManagement
{
[Table("um__User_Role")]	public class User_Role
	{
		public int userId { get; set; }
		public int roleId { get; set; }
		public DateTime addTS { get; set; }
		public int adderId { get; set; }
		public int? modderId { get; set; }
		public bool? isRemoved { get; set; }
		public DateTime? modTS { get; set; }

		public User_Role() { }


		public User_Role(int userId, int roleId, DateTime addTS, int adderId, int? modderId = default, bool? isRemoved = default, DateTime? modTS = default)		{
			this.userId = userId;
			this.roleId = roleId;
			this.addTS = addTS;
			this.adderId = adderId;
			this.modderId = modderId;
			this.isRemoved = isRemoved;
			this.modTS = modTS;
		}
	}
}