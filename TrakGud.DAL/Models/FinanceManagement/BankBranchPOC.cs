using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TrakGud.DAL.Models.FinanceManagement
{
[Table("fim__BankBranchPOC")]	public class BankBranchPOC
	{
		public int bankBranchId { get; set; }
		public int contactId { get; set; }

		public BankBranchPOC() { }


		public BankBranchPOC(int bankBranchId, int contactId)		{
			this.bankBranchId = bankBranchId;
			this.contactId = contactId;
		}
	}
}