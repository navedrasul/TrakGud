using System;
using System.Collections.Generic;
using System.Text;

namespace TrakGud.DAL.Models.FinanceManagement
{
	public class Cheque
	{
		public int id { get; set; }
		public string chequeNo { get; set; }
		public string accNo { get; set; }
		public float amount { get; set; }
		public int bankId { get; set; }
		public string sourceNo { get; set; }
		public string footerNo { get; set; }
		public string accTitle { get; set; }
		public DateTime chequeDate { get; set; }
		public int? issuerContactId { get; set; }

		public Cheque(int id_, string chequeNo_, string accNo_, float amount_, int bankId_, string sourceNo_ = default, string footerNo_ = default, string accTitle_ = default, DateTime chequeDate_ = default, int? issuerContactId_ = default)		{
			this.id = id_;
			this.chequeNo = chequeNo_;
			this.accNo = accNo_;
			this.amount = amount_;
			this.bankId = bankId_;
			this.sourceNo = sourceNo_;
			this.footerNo = footerNo_;
			this.accTitle = accTitle_;
			this.chequeDate = chequeDate_;
			this.issuerContactId = issuerContactId_;
		}
	}
}