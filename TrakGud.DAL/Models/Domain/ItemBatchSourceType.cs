using System;
using System.Collections.Generic;
using System.Text;

namespace TrakGud.DAL.Models.Domain
{
	public class ItemBatchSourceType
	{
		public string value { get; set; }
		public string text { get; set; }

		public ItemBatchSourceType(string value_, string text_)		{
			this.value = value_;
			this.text = text_;
		}
	}
}