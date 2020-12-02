using System;
using System.Collections.Generic;
using System.Text;

namespace TrakGud.DAL.Models.ContactManagement
{
	public class ContactMerger
	{
		public int mainContactId { get; set; }
		public int mergedContactId { get; set; }
		public DateTime addTS { get; set; }
		public int adderId { get; set; }
		public int? modderId { get; set; }
		public bool? isRemoved { get; set; }
		public DateTime modTS { get; set; }

		public ContactMerger(int mainContactId_, int mergedContactId_, DateTime addTS_, int adderId_, int? modderId_ = default, bool? isRemoved_ = default, DateTime modTS_ = default)		{
			this.mainContactId = mainContactId_;
			this.mergedContactId = mergedContactId_;
			this.addTS = addTS_;
			this.adderId = adderId_;
			this.modderId = modderId_;
			this.isRemoved = isRemoved_;
			this.modTS = modTS_;
		}
	}
}