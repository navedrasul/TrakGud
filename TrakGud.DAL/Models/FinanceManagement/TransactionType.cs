using System;
using System.Collections.Generic;
using System.Text;

namespace TrakGud.DAL.Models.FinanceManagement
{
	public class TransactionType
	{
		public string value { get; set; }
		public string text { get; set; }

		public TransactionType(string value_, string text_)		{
			this.value = value_;
			this.text = text_;
		}
	}
}