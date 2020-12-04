using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TrakGud.DAL.Models.Domain
{
[Table("d__ItemBatchType")]	public class ItemBatchType
	{
		public string value { get; set; }
		public string text { get; set; }

		public ItemBatchType() { }


		public ItemBatchType(string value, string text)		{
			this.value = value;
			this.text = text;
		}
	}
}