using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TrakGud.DAL.Models.Domain
{
[Table("d__Item_ItemBatch")]	public class Item_ItemBatch
	{
		public int itemId { get; set; }
		public int batchId { get; set; }

		public Item_ItemBatch() { }


		public Item_ItemBatch(int itemId, int batchId)		{
			this.itemId = itemId;
			this.batchId = batchId;
		}
	}
}