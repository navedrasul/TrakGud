using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TrakGud.DAL.Models.UserManagement
{
[Table("um__Role_Right")]	public class Role_Right: Right
	{
		public int roleId { get; set; }

		public Role_Right() { }


		public Role_Right(int roleId, int id, string title, bool isActive, DateTime addTS, int adderId, string desc = default, int? modderId = default, bool? isRemoved = default, DateTime? modTS = default): base(id, title, isActive, addTS, adderId, desc, modderId, isRemoved, modTS)
		{
			this.roleId = roleId;
		}
	}
}