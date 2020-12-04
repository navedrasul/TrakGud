using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TrakGud.DAL.Models.ContactManagement
{
[Table("cm__Contact")]	public class Contact
	{
		public int id { get; set; }
		public int type { get; set; }
		public DateTime addTS { get; set; }
		public int adderId { get; set; }
		public bool? isMerged { get; set; }
		public int? modderId { get; set; }
		public bool? isRemoved { get; set; }
		public DateTime? modTS { get; set; }

		public Contact() { }


		public Contact(int id, int type, DateTime addTS, int adderId, bool? isMerged = default, int? modderId = default, bool? isRemoved = default, DateTime? modTS = default)		{
			this.id = id;
			this.type = type;
			this.addTS = addTS;
			this.adderId = adderId;
			this.isMerged = isMerged;
			this.modderId = modderId;
			this.isRemoved = isRemoved;
			this.modTS = modTS;
		}
	}
}