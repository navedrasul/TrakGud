using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TrakGud.DAL.Models.FinanceManagement
{
[Table("fim__TransactionType")]	public class TransactionType
	{
		public string value { get; set; }
		public string text { get; set; }

		public TransactionType() { }


		public TransactionType(string value, string text)		{
			this.value = value;
			this.text = text;
		}
	}
}