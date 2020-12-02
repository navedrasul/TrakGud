using System;
using System.Collections.Generic;
using System.Text;

namespace TrakGud.DAL.Models.UserManagement
{
	public class User
	{
		public int id { get; set; }
		public string username { get; set; }
		public string passwordHash { get; set; }
		public DateTime addTS { get; set; }
		public int adderId { get; set; }
		public bool? isDisabled { get; set; }
		public string fullName { get; set; }
		public int? employeeId { get; set; }
		public int? modderId { get; set; }
		public bool? isRemoved { get; set; }
		public DateTime modTS { get; set; }

		public User(int id_, string username_, string passwordHash_, DateTime addTS_, int adderId_, bool? isDisabled_ = default, string fullName_ = default, int? employeeId_ = default, int? modderId_ = default, bool? isRemoved_ = default, DateTime modTS_ = default)		{
			this.id = id_;
			this.username = username_;
			this.passwordHash = passwordHash_;
			this.addTS = addTS_;
			this.adderId = adderId_;
			this.isDisabled = isDisabled_;
			this.fullName = fullName_;
			this.employeeId = employeeId_;
			this.modderId = modderId_;
			this.isRemoved = isRemoved_;
			this.modTS = modTS_;
		}
	}
}