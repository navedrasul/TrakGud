using System;
using System.Collections.Generic;
using System.Text;

namespace TrakGud.DAL.Models.FinanceManagement
{
	public class ChequePayment: Payment
	{
		public bool? isBounced { get; set; }
		public int chequeId { get; set; }

		public ChequePayment(int chequeId_, int id_, string type_, bool? isBounced_ = default): base(id_, type_)
		{
			this.isBounced = isBounced_;
			this.chequeId = chequeId_;
		}
	}
}