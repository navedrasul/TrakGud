using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TrakGud.DAL.Models.Domain
{
[Table("d__ItemBatch")]	public class ItemBatch
	{
		public int id { get; set; }
		public string itemBatchType { get; set; }
		public int productId { get; set; }
		public DateTime addTS { get; set; }
		public int adderId { get; set; }
		public string sourceType { get; set; }
		public int? sourceId { get; set; }
		public int? modderId { get; set; }
		public bool? isRemoved { get; set; }
		public DateTime? modTS { get; set; }

		public ItemBatch() { }


		public ItemBatch(int id, string itemBatchType, int productId, DateTime addTS, int adderId, string sourceType = default, int? sourceId = default, int? modderId = default, bool? isRemoved = default, DateTime? modTS = default)		{
			this.id = id;
			this.itemBatchType = itemBatchType;
			this.productId = productId;
			this.addTS = addTS;
			this.adderId = adderId;
			this.sourceType = sourceType;
			this.sourceId = sourceId;
			this.modderId = modderId;
			this.isRemoved = isRemoved;
			this.modTS = modTS;
		}
	}
}