using System;
using System.Collections.Generic;
using System.Text;

namespace TrakGud.DAL.Models.Domain
{
	public class StoredItemBatch: ItemBatch
	{
		public int productWarehouseStockId { get; set; }

		public StoredItemBatch(int productWarehouseStockId_, int id_, string itemBatchType_, int productId_, DateTime addTS_, int adderId_, string sourceType_ = default, int? sourceId_ = default, int? modderId_ = default, bool? isRemoved_ = default, DateTime modTS_ = default): base(id_, itemBatchType_, productId_, addTS_, adderId_, sourceType_, sourceId_, modderId_, isRemoved_, modTS_)
		{
			this.productWarehouseStockId = productWarehouseStockId_;
		}
	}
}