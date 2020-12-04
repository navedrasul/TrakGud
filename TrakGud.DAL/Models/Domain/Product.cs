using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TrakGud.DAL.Models.Domain
{
[Table("d__Product")]	public class Product
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
		public DateTime? modTS { get; set; }

		public Product() { }


		public Product(int id, string name, DateTime addTS, int adderId, string desc = default, int? productCategoryId = default, string barCode = default, int? modderId = default, bool? isRemoved = default, DateTime? modTS = default)		{
			this.id = id;
			this.name = name;
			this.addTS = addTS;
			this.adderId = adderId;
			this.desc = desc;
			this.productCategoryId = productCategoryId;
			this.barCode = barCode;
			this.modderId = modderId;
			this.isRemoved = isRemoved;
			this.modTS = modTS;
		}
	}
}