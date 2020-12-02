using System;
using System.Collections.Generic;
using System.Text;

namespace TrakGud.DAL.Models.Domain
{
	public class Product
	{
		public int id { get; set; }
		public string name { get; set; }
		public DateTime addTS { get; set; }
		public int adderId { get; set; }
		public string desc { get; set; }
		public int? productCategoryId { get; set; }
		public string barCode { get; set; }
		public int? modderId { get; set; }
		public bool? isRemoved { get; set; }
		public DateTime modTS { get; set; }

		public Product(int id_, string name_, DateTime addTS_, int adderId_, string desc_ = default, int? productCategoryId_ = default, string barCode_ = default, int? modderId_ = default, bool? isRemoved_ = default, DateTime modTS_ = default)		{
			this.id = id_;
			this.name = name_;
			this.addTS = addTS_;
			this.adderId = adderId_;
			this.desc = desc_;
			this.productCategoryId = productCategoryId_;
			this.barCode = barCode_;
			this.modderId = modderId_;
			this.isRemoved = isRemoved_;
			this.modTS = modTS_;
		}
	}
}