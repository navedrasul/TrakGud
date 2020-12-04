using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TrakGud.DAL.Models.Domain
{
[Table("d__StoredItemBatch")]	public class StoredItemBatch: ItemBatch
	{
		public int productWarehouseStockId { get; set; }

		public StoredItemBatch() { }


		public StoredItemBatch(int productWarehouseStockId, int id, string itemBatchType, int productId, DateTime addTS, int adderId, string sourceType = default, int? sourceId = default, int? modderId = default, bool? isRemoved = default, DateTime? modTS = default): base(id, itemBatchType, productId, addTS, adderId, sourceType, sourceId, modderId, isRemoved, modTS)
		{
			this.productWarehouseStockId = productWarehouseStockId;
		}
	}
}