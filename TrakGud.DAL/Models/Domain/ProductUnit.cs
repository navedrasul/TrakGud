using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TrakGud.DAL.Models.Domain
{
[Table("d__ProductUnit")]	public class ProductUnit
	{
		public int id { get; set; }
		public string name { get; set; }
		public int productId { get; set; }
		public DateTime addTS { get; set; }
		public int adderId { get; set; }
		public int? modderId { get; set; }
		public bool? isDefault { get; set; }
		public DateTime? modTS { get; set; }

		public ProductUnit() { }


		public ProductUnit(int id, string name, int productId, DateTime addTS, int adderId, int? modderId = default, bool? isDefault = default, DateTime? modTS = default)		{
			this.id = id;
			this.name = name;
			this.productId = productId;
			this.addTS = addTS;
			this.adderId = adderId;
			this.modderId = modderId;
			this.isDefault = isDefault;
			this.modTS = modTS;
		}
	}
}