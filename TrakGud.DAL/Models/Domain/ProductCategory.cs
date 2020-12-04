using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TrakGud.DAL.Models.Domain
{
[Table("d__ProductCategory")]	public class ProductCategory
	{
		public int id { get; set; }
		public string name { get; set; }
		public DateTime addTS { get; set; }
		public int adderId { get; set; }
		public int? prodCount { get; set; }
		public int? modderId { get; set; }
		public bool? isRemoved { get; set; }
		public DateTime? modTS { get; set; }

		public ProductCategory() { }


		public ProductCategory(int id, string name, DateTime addTS, int adderId, int? prodCount = default, int? modderId = default, bool? isRemoved = default, DateTime? modTS = default)		{
			this.id = id;
			this.name = name;
			this.addTS = addTS;
			this.adderId = adderId;
			this.prodCount = prodCount;
			this.modderId = modderId;
			this.isRemoved = isRemoved;
			this.modTS = modTS;
		}
	}
}