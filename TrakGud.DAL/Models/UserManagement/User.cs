using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TrakGud.DAL.Models.UserManagement
{
[Table("um__User")]	public class User
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
		public DateTime? modTS { get; set; }

		public User() { }


		public User(int id, string username, string passwordHash, DateTime addTS, int adderId, bool? isDisabled = default, string fullName = default, int? employeeId = default, int? modderId = default, bool? isRemoved = default, DateTime? modTS = default)		{
			this.id = id;
			this.username = username;
			this.passwordHash = passwordHash;
			this.addTS = addTS;
			this.adderId = adderId;
			this.isDisabled = isDisabled;
			this.fullName = fullName;
			this.employeeId = employeeId;
			this.modderId = modderId;
			this.isRemoved = isRemoved;
			this.modTS = modTS;
		}
	}
}