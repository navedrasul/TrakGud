using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TrakGud.DAL.Models.FleetManagement
{
[Table("fm__VehicleCapacityUnitConvertion")]	public class VehicleCapacityUnitConvertion
	{
		public int sourceUnitId { get; set; }
		public int destinationUnitId { get; set; }
		public float multiplier { get; set; }
		public DateTime addTS { get; set; }
		public int adderId { get; set; }
		public int? modderId { get; set; }
		public DateTime? modTS { get; set; }

		public VehicleCapacityUnitConvertion() { }


		public VehicleCapacityUnitConvertion(int sourceUnitId, int destinationUnitId, float multiplier, DateTime addTS, int adderId, int? modderId = default, DateTime? modTS = default)		{
			this.sourceUnitId = sourceUnitId;
			this.destinationUnitId = destinationUnitId;
			this.multiplier = multiplier;
			this.addTS = addTS;
			this.adderId = adderId;
			this.modderId = modderId;
			this.modTS = modTS;
		}
	}
}