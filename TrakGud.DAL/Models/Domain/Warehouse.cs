using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TrakGud.DAL.Models.Domain
{
[Table("d__Warehouse")]	public class Warehouse
	{
		public int id { get; set; }
		public int locationId { get; set; }
		public DateTime addTS { get; set; }
		public int adderId { get; set; }
		public int? modderId { get; set; }
		public DateTime? modTS { get; set; }

		public Warehouse() { }


		public Warehouse(int id, int locationId, DateTime addTS, int adderId, int? modderId = default, DateTime? modTS = default)		{
			this.id = id;
			this.locationId = locationId;
			this.addTS = addTS;
			this.adderId = adderId;
			this.modderId = modderId;
			this.modTS = modTS;
		}
	}
}