using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TrakGud.DAL.Models.Sales
{
[Table("s__ProductOffer")]	public class ProductOffer
	{
		public int id { get; set; }
		public string name { get; set; }
		public float price { get; set; }
		public DateTime addTS { get; set; }
		public int adderId { get; set; }
		public string desc { get; set; }
		public int? modderId { get; set; }
		public bool? isRemoved { get; set; }
		public DateTime? validFromTS { get; set; }
		public DateTime? validToTS { get; set; }
		public DateTime? modTS { get; set; }

		public ProductOffer() { }


		public ProductOffer(int id, string name, float price, DateTime addTS, int adderId, string desc = default, int? modderId = default, bool? isRemoved = default, DateTime? validFromTS = default, DateTime? validToTS = default, DateTime? modTS = default)		{
			this.id = id;
			this.name = name;
			this.price = price;
			this.addTS = addTS;
			this.adderId = adderId;
			this.desc = desc;
			this.modderId = modderId;
			this.isRemoved = isRemoved;
			this.validFromTS = validFromTS;
			this.validToTS = validToTS;
			this.modTS = modTS;
		}
	}
}