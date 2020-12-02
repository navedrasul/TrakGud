using System;
using System.Collections.Generic;
using System.Text;

namespace TrakGud.DAL.Models.ShipmentManagement
{
	public class Shipment_Vehicle
	{
		public int shipmentId { get; set; }
		public int vehicleId { get; set; }
		public DateTime assignmentTS { get; set; }

		public Shipment_Vehicle(int shipmentId_, int vehicleId_, DateTime assignmentTS_ = default)		{
			this.shipmentId = shipmentId_;
			this.vehicleId = vehicleId_;
			this.assignmentTS = assignmentTS_;
		}
	}
}