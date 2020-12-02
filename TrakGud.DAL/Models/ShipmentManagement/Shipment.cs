using System;
using System.Collections.Generic;
using System.Text;

namespace TrakGud.DAL.Models.ShipmentManagement
{
	public class Shipment
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
		public DateTime modTS { get; set; }

		public Shipment(int id_, int sourceId_, int destinationId_, int sourceItemBatchId_, int destinationItemBatchId_, int suppervisorId_, DateTime addTS_, int adderId_, bool? isShipmentComplete_ = default, int? modderId_ = default, bool? isRemoved_ = default, DateTime modTS_ = default)		{
			this.id = id_;
			this.sourceId = sourceId_;
			this.destinationId = destinationId_;
			this.sourceItemBatchId = sourceItemBatchId_;
			this.destinationItemBatchId = destinationItemBatchId_;
			this.suppervisorId = suppervisorId_;
			this.addTS = addTS_;
			this.adderId = adderId_;
			this.isShipmentComplete = isShipmentComplete_;
			this.modderId = modderId_;
			this.isRemoved = isRemoved_;
			this.modTS = modTS_;
		}
	}
}