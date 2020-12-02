using System;
using System.Collections.Generic;
using System.Text;

namespace TrakGud.DAL.Models.Domain
{
	public class ItemBatchType
	{
		public string value { get; set; }
		public string text { get; set; }

		public ItemBatchType(string value_, string text_)		{
			this.value = value_;
			this.text = text_;
		}
	}
}