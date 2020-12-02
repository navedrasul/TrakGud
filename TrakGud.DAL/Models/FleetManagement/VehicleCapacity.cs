using System;
using System.Collections.Generic;
using System.Text;

namespace TrakGud.DAL.Models.FleetManagement
{
	public class VehicleCapacity
	{
		public int vehicleId { get; set; }
		public int capacityUnitId { get; set; }
		public float capacity { get; set; }

		public VehicleCapacity(int vehicleId_, int capacityUnitId_, float capacity_)		{
			this.vehicleId = vehicleId_;
			this.capacityUnitId = capacityUnitId_;
			this.capacity = capacity_;
		}
	}
}