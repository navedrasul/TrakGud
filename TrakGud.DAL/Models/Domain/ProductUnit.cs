using System;
using System.Collections.Generic;
using System.Text;

namespace TrakGud.DAL.Models.Domain
{
	public class ProductUnit
	{
		public int id { get; set; }
		public string name { get; set; }
		public int productId { get; set; }
		public DateTime addTS { get; set; }
		public int adderId { get; set; }
		public int? modderId { get; set; }
		public bool? isDefault { get; set; }
		public DateTime modTS { get; set; }

		public ProductUnit(int id_, string name_, int productId_, DateTime addTS_, int adderId_, int? modderId_ = default, bool? isDefault_ = default, DateTime modTS_ = default)		{
			this.id = id_;
			this.name = name_;
			this.productId = productId_;
			this.addTS = addTS_;
			this.adderId = adderId_;
			this.modderId = modderId_;
			this.isDefault = isDefault_;
			this.modTS = modTS_;
		}
	}
}