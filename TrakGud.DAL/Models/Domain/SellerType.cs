using System;
using System.Collections.Generic;
using System.Text;

namespace TrakGud.DAL.Models.Domain
{
	public class SellerType
	{
		public string value { get; set; }
		public string text { get; set; }

		public SellerType(string value_, string text_)		{
			this.value = value_;
			this.text = text_;
		}
	}
}