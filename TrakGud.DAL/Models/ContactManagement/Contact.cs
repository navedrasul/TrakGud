using System;
using System.Collections.Generic;
using System.Text;

namespace TrakGud.DAL.Models.ContactManagement
{
	public class Contact
	{
		public int id { get; set; }
		public int type { get; set; }
		public DateTime addTS { get; set; }
		public int adderId { get; set; }
		public bool? isMerged { get; set; }
		public int? modderId { get; set; }
		public bool? isRemoved { get; set; }
		public DateTime modTS { get; set; }

		public Contact(int id_, int type_, DateTime addTS_, int adderId_, bool? isMerged_ = default, int? modderId_ = default, bool? isRemoved_ = default, DateTime modTS_ = default)		{
			this.id = id_;
			this.type = type_;
			this.addTS = addTS_;
			this.adderId = adderId_;
			this.isMerged = isMerged_;
			this.modderId = modderId_;
			this.isRemoved = isRemoved_;
			this.modTS = modTS_;
		}
	}
}