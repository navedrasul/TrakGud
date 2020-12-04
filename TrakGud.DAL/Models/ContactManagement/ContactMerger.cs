using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TrakGud.DAL.Models.ContactManagement
{
[Table("cm__ContactMerger")]	public class ContactMerger
	{
		public int mainContactId { get; set; }
		public int mergedContactId { get; set; }
		public DateTime addTS { get; set; }
		public int adderId { get; set; }
		public int? modderId { get; set; }
		public bool? isRemoved { get; set; }
		public DateTime? modTS { get; set; }

		public ContactMerger() { }


		public ContactMerger(int mainContactId, int mergedContactId, DateTime addTS, int adderId, int? modderId = default, bool? isRemoved = default, DateTime? modTS = default)		{
			this.mainContactId = mainContactId;
			this.mergedContactId = mergedContactId;
			this.addTS = addTS;
			this.adderId = adderId;
			this.modderId = modderId;
			this.isRemoved = isRemoved;
			this.modTS = modTS;
		}
	}
}