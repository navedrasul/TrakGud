using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TrakGud.DAL.Models.FinanceManagement
{
[Table("fim__BankBranch")]	public class BankBranch
	{
		public int id { get; set; }
		public int bankId { get; set; }
		public int addressId { get; set; }

		public BankBranch() { }


		public BankBranch(int id, int bankId, int addressId)		{
			this.id = id;
			this.bankId = bankId;
			this.addressId = addressId;
		}
	}
}