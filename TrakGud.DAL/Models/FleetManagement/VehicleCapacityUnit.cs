using System;
using System.Collections.Generic;
using System.Text;

namespace TrakGud.DAL.Models.FleetManagement
{
	public class VehicleCapacityUnit
	{
		public int id { get; set; }
		public string name { get; set; }
		public int vehicleUnitTypeId { get; set; }
		public DateTime addTS { get; set; }
		public int adderId { get; set; }
		public int? vehicleTypeId { get; set; }
		public int? modderId { get; set; }
		public bool? isDefault { get; set; }
		public DateTime modTS { get; set; }

		public VehicleCapacityUnit(int id_, string name_, int vehicleUnitTypeId_, DateTime addTS_, int adderId_, int? vehicleTypeId_ = default, int? modderId_ = default, bool? isDefault_ = default, DateTime modTS_ = default)		{
			this.id = id_;
			this.name = name_;
			this.vehicleUnitTypeId = vehicleUnitTypeId_;
			this.addTS = addTS_;
			this.adderId = adderId_;
			this.vehicleTypeId = vehicleTypeId_;
			this.modderId = modderId_;
			this.isDefault = isDefault_;
			this.modTS = modTS_;
		}
	}
}