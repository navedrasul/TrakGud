using System;
using System.Collections.Generic;
using System.Text;

namespace TrakGud.DAL.Models.Domain
{
	public class Item_ItemBatch
	{
		public int itemId { get; set; }
		public int batchId { get; set; }

		public Item_ItemBatch(int itemId_, int batchId_)		{
			this.itemId = itemId_;
			this.batchId = batchId_;
		}
	}
}