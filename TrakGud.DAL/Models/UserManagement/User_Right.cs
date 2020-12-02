using System;
using System.Collections.Generic;
using System.Text;

namespace TrakGud.DAL.Models.UserManagement
{
	public class User_Right: Right
	{
		public int userId { get; set; }

		public User_Right(int id_, string title_, bool isActive_, DateTime addTS_, int adderId_, string desc_ = default, int? modderId_ = default, bool? isRemoved_ = default, DateTime modTS_ = default, int userId_): base(id_, title_, isActive_, addTS_, adderId_, desc_, modderId_, isRemoved_, modTS_)
		{
			this.userId = userId_;
		}
	}
}