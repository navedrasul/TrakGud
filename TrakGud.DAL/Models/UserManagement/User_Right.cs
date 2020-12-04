using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TrakGud.DAL.Models.UserManagement
{
[Table("um__User_Right")]	public class User_Right: Right
	{
		public int userId { get; set; }

		public User_Right() { }


		public User_Right(int userId, int id, string title, bool isActive, DateTime addTS, int adderId, string desc = default, int? modderId = default, bool? isRemoved = default, DateTime? modTS = default): base(id, title, isActive, addTS, adderId, desc, modderId, isRemoved, modTS)
		{
			this.userId = userId;
		}
	}
}