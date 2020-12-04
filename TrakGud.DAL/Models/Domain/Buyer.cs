using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TrakGud.DAL.Models.Domain
{
[Table("d__Buyer")]	public class Buyer
	{
		public int id { get; set; }
		public string name { get; set; }
		public string buyerType { get; set; }
		public DateTime addTS { get; set; }
		public int adderId { get; set; }
		public int? commentsThreadId { get; set; }
		public int? contactId { get; set; }
		public int? modderId { get; set; }
		public string RCT { get; set; }
		public string RST { get; set; }
		public DateTime? modTS { get; set; }

		public Buyer() { }


		public Buyer(int id, string name, string buyerType, DateTime addTS, int adderId, int? commentsThreadId = default, int? contactId = default, int? modderId = default, string RCT = default, string RST = default, DateTime? modTS = default)		{
			this.id = id;
			this.name = name;
			this.buyerType = buyerType;
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