using System;
using System.Collections.Generic;
using System.Text;

namespace TrakGud.DAL.Models.Domain
{
	public class ReceivedItemBatch: ItemBatch
	{
		public int? supplierId { get; set; }
		public int? transactionId { get; set; }
		public DateTime receptionTS { get; set; }

		public ReceivedItemBatch(int id_, string itemBatchType_, int productId_, DateTime addTS_, int adderId_, int? supplierId_ = default, int? transactionId_ = default, DateTime receptionTS_ = default, string sourceType_ = default, int? sourceId_ = default, int? modderId_ = default, bool? isRemoved_ = default, DateTime modTS_ = default): base(id_, itemBatchType_, productId_, addTS_, adderId_, sourceType_, sourceId_, modderId_, isRemoved_, modTS_)
		{
			this.supplierId = supplierId_;
			this.transactionId = transactionId_;
			this.receptionTS = receptionTS_;
		}
	}
}