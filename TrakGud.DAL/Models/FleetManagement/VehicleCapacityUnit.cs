using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TrakGud.DAL.Models.FleetManagement
{
[Table("fm__VehicleCapacityUnit")]	public class VehicleCapacityUnit
	{
		public int id { get; set; }
		public string name { get; set; }
		public int vehicleUnitTypeId { get; set; }
		public DateTime addTS { get; set; }
		public int adderId { get; set; }
		public int? vehicleTypeId { get; set; }
		public int? modderId { get; set; }
		public bool? isDefault { get; set; }
		public DateTime? modTS { get; set; }

		public VehicleCapacityUnit() { }


		public VehicleCapacityUnit(int id, string name, int vehicleUnitTypeId, DateTime addTS, int adderId, int? vehicleTypeId = default, int? modderId = default, bool? isDefault = default, DateTime? modTS = default)		{
			this.id = id;
			this.name = name;
			this.vehicleUnitTypeId = vehicleUnitTypeId;
			this.addTS = addTS;
			this.adderId = adderId;
			this.vehicleTypeId = vehicleTypeId;
			this.modderId = modderId;
			this.isDefault = isDefault;
			this.modTS = modTS;
		}
	}
}