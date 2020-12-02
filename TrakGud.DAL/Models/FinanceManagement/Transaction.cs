using System;
using System.Collections.Generic;
using System.Text;

namespace TrakGud.DAL.Models.FinanceManagement
{
	public class Transaction
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
		public DateTime TS { get; set; }
		public DateTime modTS { get; set; }

		public Transaction(int id_, string type_, int paymentId_, DateTime addTS_, int adderId_, string RCT_ = default, string RST_ = default, int? modderId_ = default, bool? isRemoved_ = default, DateTime TS_ = default, DateTime modTS_ = default)		{
			this.id = id_;
			this.type = type_;
			this.paymentId = paymentId_;
			this.addTS = addTS_;
			this.adderId = adderId_;
			this.RCT = RCT_;
			this.RST = RST_;
			this.modderId = modderId_;
			this.isRemoved = isRemoved_;
			this.TS = TS_;
			this.modTS = modTS_;
		}
	}
}