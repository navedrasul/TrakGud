using System;
using System.Collections.Generic;
using System.Text;

namespace TrakGud.DAL.Models.FinanceManagement
{
	public class BankBranchPOC
	{
		public int bankBranchId { get; set; }
		public int contactId { get; set; }

		public BankBranchPOC(int bankBranchId_, int contactId_)		{
			this.bankBranchId = bankBranchId_;
			this.contactId = contactId_;
		}
	}
}