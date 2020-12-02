using System;
using System.Collections.Generic;
using System.Text;

namespace TrakGud.DAL.Models.Sales
{
	public class ProductOffer
	{
		public int id { get; set; }
		public string name { get; set; }
		public float price { get; set; }
		public DateTime addTS { get; set; }
		public int adderId { get; set; }
		public string desc { get; set; }
		public int? modderId { get; set; }
		public bool? isRemoved { get; set; }
		public DateTime validFromTS { get; set; }
		public DateTime validToTS { get; set; }
		public DateTime modTS { get; set; }

		public ProductOffer(int id_, string name_, float price_, DateTime addTS_, int adderId_, string desc_ = default, int? modderId_ = default, bool? isRemoved_ = default, DateTime validFromTS_ = default, DateTime validToTS_ = default, DateTime modTS_ = default)		{
			this.id = id_;
			this.name = name_;
			this.price = price_;
			this.addTS = addTS_;
			this.adderId = adderId_;
			this.desc = desc_;
			this.modderId = modderId_;
			this.isRemoved = isRemoved_;
			this.validFromTS = validFromTS_;
			this.validToTS = validToTS_;
			this.modTS = modTS_;
		}
	}
}