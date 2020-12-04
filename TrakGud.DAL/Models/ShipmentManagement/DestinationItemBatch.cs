using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using TrakGud.DAL.Models.Domain;

namespace TrakGud.DAL.Models.ShipmentManagement
{
[Table("sm__DestinationItemBatch")]	public class DestinationItemBatch: ItemBatch
	{
		public float? receivedQty { get; set; }
		public int? receivedUnitId { get; set; }

		public DestinationItemBatch() { }


		public DestinationItemBatch(int id, string itemBatchType, int productId, DateTime addTS, int adderId, float? receivedQty = default, int? receivedUnitId = default, string sourceType = default, int? sourceId = default, int? modderId = default, bool? isRemoved = default, DateTime? modTS = default): base(id, itemBatchType, productId, addTS, adderId, sourceType, sourceId, modderId, isRemoved, modTS)
		{
			this.receivedQty = receivedQty;
			this.receivedUnitId = receivedUnitId;
		}
	}
}