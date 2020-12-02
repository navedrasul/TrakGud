using System;
using System.Collections.Generic;
using System.Text;

namespace TrakGud.DAL.Models.FleetManagement
{
	public class VehicleCapacityUnitConvertion
	{
		public int sourceUnitId { get; set; }
		public int destinationUnitId { get; set; }
		public float multiplier { get; set; }
		public DateTime addTS { get; set; }
		public int adderId { get; set; }
		public int? modderId { get; set; }
		public DateTime modTS { get; set; }

		public VehicleCapacityUnitConvertion(int sourceUnitId_, int destinationUnitId_, float multiplier_, DateTime addTS_, int adderId_, int? modderId_ = default, DateTime modTS_ = default)		{
			this.sourceUnitId = sourceUnitId_;
			this.destinationUnitId = destinationUnitId_;
			this.multiplier = multiplier_;
			this.addTS = addTS_;
			this.adderId = adderId_;
			this.modderId = modderId_;
			this.modTS = modTS_;
		}
	}
}