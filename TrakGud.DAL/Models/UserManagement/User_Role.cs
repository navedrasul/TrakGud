using System;
using System.Collections.Generic;
using System.Text;

namespace TrakGud.DAL.Models.UserManagement
{
	public class User_Role
	{
		public int userId { get; set; }
		public int roleId { get; set; }
		public DateTime addTS { get; set; }
		public int adderId { get; set; }
		public int? modderId { get; set; }
		public bool? isRemoved { get; set; }
		public DateTime modTS { get; set; }

		public User_Role(int userId_, int roleId_, DateTime addTS_, int adderId_, int? modderId_ = default, bool? isRemoved_ = default, DateTime modTS_ = default)		{
			this.userId = userId_;
			this.roleId = roleId_;
			this.addTS = addTS_;
			this.adderId = adderId_;
			this.modderId = modderId_;
			this.isRemoved = isRemoved_;
			this.modTS = modTS_;
		}
	}
}