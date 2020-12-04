using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TrakGud.DAL.Models.Domain
{
[Table("d__RemovedItemBatch")]	public class RemovedItemBatch: ItemBatch
	{
		public string removalReason { get; set; }
		public DateTime? removalTS { get; set; }

		public RemovedItemBatch() { }


		public RemovedItemBatch(string removalReason, int id, string itemBatchType, int productId, DateTime addTS, int adderId, DateTime? removalTS = default, string sourceType = default, int? sourceId = default, int? modderId = default, bool? isRemoved = default, DateTime? modTS = default): base(id, itemBatchType, productId, addTS, adderId, sourceType, sourceId, modderId, isRemoved, modTS)
		{
			this.removalReason = removalReason;
			this.removalTS = removalTS;
		}
	}
}