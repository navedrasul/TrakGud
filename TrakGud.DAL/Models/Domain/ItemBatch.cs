using System;
using System.Collections.Generic;
using System.Text;

namespace TrakGud.DAL.Models.Domain
{
	public class ItemBatch
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
		public DateTime modTS { get; set; }

		public ItemBatch(int id_, string itemBatchType_, int productId_, DateTime addTS_, int adderId_, string sourceType_ = default, int? sourceId_ = default, int? modderId_ = default, bool? isRemoved_ = default, DateTime modTS_ = default)		{
			this.id = id_;
			this.itemBatchType = itemBatchType_;
			this.productId = productId_;
			this.addTS = addTS_;
			this.adderId = adderId_;
			this.sourceType = sourceType_;
			this.sourceId = sourceId_;
			this.modderId = modderId_;
			this.isRemoved = isRemoved_;
			this.modTS = modTS_;
		}
	}
}