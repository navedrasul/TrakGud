using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TrakGud.DAL.Models.ShipmentManagement
{
[Table("sm__Shipment_Vehicle")]	public class Shipment_Vehicle
	{
		public int shipmentId { get; set; }
		public int vehicleId { get; set; }
		public DateTime? assignmentTS { get; set; }

		public Shipment_Vehicle() { }


		public Shipment_Vehicle(int shipmentId, int vehicleId, DateTime? assignmentTS = default)		{
			this.shipmentId = shipmentId;
			this.vehicleId = vehicleId;
			this.assignmentTS = assignmentTS;
		}
	}
}