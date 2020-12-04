using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TrakGud.DAL.Models.FinanceManagement
{
[Table("fim__Cheque")]	public class Cheque
	{
		public int id { get; set; }
		public string chequeNo { get; set; }
		public string accNo { get; set; }
		public float amount { get; set; }
		public int bankId { get; set; }
		public string sourceNo { get; set; }
		public string footerNo { get; set; }
		public string accTitle { get; set; }
		public DateTime? chequeDate { get; set; }
		public int? issuerContactId { get; set; }

		public Cheque() { }


		public Cheque(int id, string chequeNo, string accNo, float amount, int bankId, string sourceNo = default, string footerNo = default, string accTitle = default, DateTime? chequeDate = default, int? issuerContactId = default)		{
			this.id = id;
			this.chequeNo = chequeNo;
			this.accNo = accNo;
			this.amount = amount;
			this.bankId = bankId;
			this.sourceNo = sourceNo;
			this.footerNo = footerNo;
			this.accTitle = accTitle;
			this.chequeDate = chequeDate;
			this.issuerContactId = issuerContactId;
		}
	}
}