using System;
using System.Collections.Generic;
using System.Text;

namespace TrakGud.DAL.Models.FinanceManagement
{
	public class PaymentType
	{
		public string value { get; set; }
		public string text { get; set; }

		public PaymentType(string value_, string text_)		{
			this.value = value_;
			this.text = text_;
		}
	}
}