using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TrakGud.DAL.Models.ShipmentManagement
{
[Table("sm__Shipment")]	public class Shipment
	{
		public int id { get; set; }
		public int sourceId { get; set; }
		public int destinationId { get; set; }
		public int sourceItemBatchId { get; set; }
		public int destinationItemBatchId { get; set; }
		public int suppervisorId { get; set; }
		public DateTime addTS { get; set; }
		public int adderId { get; set; }
		public bool? isShipmentComplete { get; set; }
		public int? modderId { get; set; }
		public bool? isRemoved { get; set; }
		public DateTime? modTS { get; set; }

		public Shipment() { }


		public Shipment(int id, int sourceId, int destinationId, int sourceItemBatchId, int destinationItemBatchId, int suppervisorId, DateTime addTS, int adderId, bool? isShipmentComplete = default, int? modderId = default, bool? isRemoved = default, DateTime? modTS = default)		{
			this.id = id;
			this.sourceId = sourceId;
			this.destinationId = destinationId;
			this.sourceItemBatchId = sourceItemBatchId;
			this.destinationItemBatchId = destinationItemBatchId;
			this.suppervisorId = suppervisorId;
			this.addTS = addTS;
			this.adderId = adderId;
			this.isShipmentComplete = isShipmentComplete;
			this.modderId = modderId;
			this.isRemoved = isRemoved;
			this.modTS = modTS;
		}
	}
}