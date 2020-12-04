using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using TrakGud.DAL.Models.Domain;

namespace TrakGud.DAL.Models.ShipmentManagement
{
[Table("sm__MovingItemBatch")]	public class MovingItemBatch: ItemBatch
	{
		public int shipmentId { get; set; }

		public MovingItemBatch() { }


		public MovingItemBatch(int shipmentId, int id, string itemBatchType, int productId, DateTime addTS, int adderId, string sourceType = default, int? sourceId = default, int? modderId = default, bool? isRemoved = default, DateTime? modTS = default): base(id, itemBatchType, productId, addTS, adderId, sourceType, sourceId, modderId, isRemoved, modTS)
		{
			this.shipmentId = shipmentId;
		}
	}
}