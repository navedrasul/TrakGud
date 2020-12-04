using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TrakGud.DAL.Models.FinanceManagement
{
[Table("fim__PaymentType")]	public class PaymentType
	{
		public string value { get; set; }
		public string text { get; set; }

		public PaymentType() { }


		public PaymentType(string value, string text)		{
			this.value = value;
			this.text = text;
		}
	}
}