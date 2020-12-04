using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TrakGud.DAL.Models.FleetManagement
{
[Table("fm__VehicleCapacity")]	public class VehicleCapacity
	{
		public int vehicleId { get; set; }
		public int capacityUnitId { get; set; }
		public float capacity { get; set; }

		public VehicleCapacity() { }


		public VehicleCapacity(int vehicleId, int capacityUnitId, float capacity)		{
			this.vehicleId = vehicleId;
			this.capacityUnitId = capacityUnitId;
			this.capacity = capacity;
		}
	}
}