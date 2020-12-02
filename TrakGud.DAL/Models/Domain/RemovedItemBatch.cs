using System;
using System.Collections.Generic;
using System.Text;

namespace TrakGud.DAL.Models.Domain
{
	public class RemovedItemBatch: ItemBatch
	{
		public string removalReason { get; set; }
		public DateTime removalTS { get; set; }

		public RemovedItemBatch(int id_, string itemBatchType_, int productId_, DateTime addTS_, int adderId_, string sourceType_ = default, int? sourceId_ = default, int? modderId_ = default, bool? isRemoved_ = default, DateTime modTS_ = default, string removalReason_, DateTime removalTS_ = default): base(id_, itemBatchType_, productId_, addTS_, adderId_, sourceType_, sourceId_, modderId_, isRemoved_, modTS_)
		{
			this.removalReason = removalReason_;
			this.removalTS = removalTS_;
		}
	}
}