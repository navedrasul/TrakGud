using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TrakGud.DAL.Models.Domain
{
[Table("d__ReceivedItemBatch")]	public class ReceivedItemBatch: ItemBatch
	{
		public int? supplierId { get; set; }
		public int? transactionId { get; set; }
		public DateTime? receptionTS { get; set; }

		public ReceivedItemBatch() { }


		public ReceivedItemBatch(int id, string itemBatchType, int productId, DateTime addTS, int adderId, int? supplierId = default, int? transactionId = default, DateTime? receptionTS = default, string sourceType = default, int? sourceId = default, int? modderId = default, bool? isRemoved = default, DateTime? modTS = default): base(id, itemBatchType, productId, addTS, adderId, sourceType, sourceId, modderId, isRemoved, modTS)
		{
			this.supplierId = supplierId;
			this.transactionId = transactionId;
			this.receptionTS = receptionTS;
		}
	}
}