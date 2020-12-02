using System;
using System.Collections.Generic;
using System.Text;

namespace TrakGud.DAL.Models.FleetManagement
{
	public class Vehicle
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
		public DateTime driverAssignmentTS { get; set; }
		public DateTime modTS { get; set; }

		public Vehicle(int id_, string name_, string regNumber_, string status_, DateTime addTS_, int adderId_, string desc_ = default, int? vehicleTypeId_ = default, int? currentDriverId_ = default, bool? isInService_ = default, int? modderId_ = default, bool? isRemoved_ = default, DateTime driverAssignmentTS_ = default, DateTime modTS_ = default)		{
			this.id = id_;
			this.name = name_;
			this.regNumber = regNumber_;
			this.status = status_;
			this.addTS = addTS_;
			this.adderId = adderId_;
			this.desc = desc_;
			this.vehicleTypeId = vehicleTypeId_;
			this.currentDriverId = currentDriverId_;
			this.isInService = isInService_;
			this.modderId = modderId_;
			this.isRemoved = isRemoved_;
			this.driverAssignmentTS = driverAssignmentTS_;
			this.modTS = modTS_;
		}
	}
}