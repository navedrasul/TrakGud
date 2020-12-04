using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using TrakGud.DAL.Models.Domain;

namespace TrakGud.DAL.Models.ShipmentManagement
{
[Table("sm__ShippedItemBatch")]	public class ShippedItemBatch: ItemBatch
	{
		public int? vehicleId { get; set; }

		public ShippedItemBatch() { }


		public ShippedItemBatch(int id, string itemBatchType, int productId, DateTime addTS, int adderId, int? vehicleId = default, string sourceType = default, int? sourceId = default, int? modderId = default, bool? isRemoved = default, DateTime? modTS = default): base(id, itemBatchType, productId, addTS, adderId, sourceType, sourceId, modderId, isRemoved, modTS)
		{
			this.vehicleId = vehicleId;
		}
	}
}