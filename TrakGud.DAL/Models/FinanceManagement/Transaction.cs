using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TrakGud.DAL.Models.FinanceManagement
{
[Table("fim__Transaction")]	public class Transaction
	{
		public int id { get; set; }
		public string type { get; set; }
		public int paymentId { get; set; }
		public DateTime addTS { get; set; }
		public int adderId { get; set; }
		public string RCT { get; set; }
		public string RST { get; set; }
		public int? modderId { get; set; }
		public bool? isRemoved { get; set; }
		public DateTime? TS { get; set; }
		public DateTime? modTS { get; set; }

		public Transaction() { }


		public Transaction(int id, string type, int paymentId, DateTime addTS, int adderId, string RCT = default, string RST = default, int? modderId = default, bool? isRemoved = default, DateTime? TS = default, DateTime? modTS = default)		{
			this.id = id;
			this.type = type;
			this.paymentId = paymentId;
			this.addTS = addTS;
			this.adderId = adderId;
			this.RCT = RCT;
			this.RST = RST;
			this.modderId = modderId;
			this.isRemoved = isRemoved;
			this.TS = TS;
			this.modTS = modTS;
		}
	}
}