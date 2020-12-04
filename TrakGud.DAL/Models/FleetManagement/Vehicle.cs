using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TrakGud.DAL.Models.FleetManagement
{
[Table("fm__Vehicle")]	public class Vehicle
	{
		public int id { get; set; }
		public string name { get; set; }
		public string regNumber { get; set; }
		public string status { get; set; }
		public DateTime addTS { get; set; }
		public int adderId { get; set; }
		public string desc { get; set; }
		public int? vehicleTypeId { get; set; }
		public int? currentDriverId { get; set; }
		public bool? isInService { get; set; }
		public int? modderId { get; set; }
		public bool? isRemoved { get; set; }
		public DateTime? driverAssignmentTS { get; set; }
		public DateTime? modTS { get; set; }

		public Vehicle() { }


		public Vehicle(int id, string name, string regNumber, string status, DateTime addTS, int adderId, string desc = default, int? vehicleTypeId = default, int? currentDriverId = default, bool? isInService = default, int? modderId = default, bool? isRemoved = default, DateTime? driverAssignmentTS = default, DateTime? modTS = default)		{
			this.id = id;
			this.name = name;
			this.regNumber = regNumber;
			this.status = status;
			this.addTS = addTS;
			this.adderId = adderId;
			this.desc = desc;
			this.vehicleTypeId = vehicleTypeId;
			this.currentDriverId = currentDriverId;
			this.isInService = isInService;
			this.modderId = modderId;
			this.isRemoved = isRemoved;
			this.driverAssignmentTS = driverAssignmentTS;
			this.modTS = modTS;
		}
	}
}