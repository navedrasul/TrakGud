using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TrakGud.DAL.Models.Domain
{
[Table("d__Seller")]	public class Seller
	{
		public int id { get; set; }
		public string name { get; set; }
		public int sellerType { get; set; }
		public DateTime addTS { get; set; }
		public int adderId { get; set; }
		public int? commentsThreadId { get; set; }
		public int? contactId { get; set; }
		public int? modderId { get; set; }
		public string RCT { get; set; }
		public string RST { get; set; }
		public DateTime? modTS { get; set; }

		public Seller() { }


		public Seller(int id, string name, int sellerType, DateTime addTS, int adderId, int? commentsThreadId = default, int? contactId = default, int? modderId = default, string RCT = default, string RST = default, DateTime? modTS = default)		{
			this.id = id;
			this.name = name;
			this.sellerType = sellerType;
			this.addTS = addTS;
			this.adderId = adderId;
			this.commentsThreadId = commentsThreadId;
			this.contactId = contactId;
			this.modderId = modderId;
			this.RCT = RCT;
			this.RST = RST;
			this.modTS = modTS;
		}
	}
}