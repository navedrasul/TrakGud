using System;
using System.Collections.Generic;
using System.Text;

namespace TrakGud.DAL.Models.FinanceManagement
{
	public class BankBranch
	{
		public int id { get; set; }
		public int bankId { get; set; }
		public int addressId { get; set; }

		public BankBranch(int id_, int bankId_, int addressId_)		{
			this.id = id_;
			this.bankId = bankId_;
			this.addressId = addressId_;
		}
	}
}