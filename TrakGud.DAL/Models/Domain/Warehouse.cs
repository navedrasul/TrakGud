using System;
using System.Collections.Generic;
using System.Text;

namespace TrakGud.DAL.Models.Domain
{
	public class Warehouse
	{
		public int id { get; set; }
		public int locationId { get; set; }
		public DateTime addTS { get; set; }
		public int adderId { get; set; }
		public int? modderId { get; set; }
		public DateTime modTS { get; set; }

		public Warehouse(int id_, int locationId_, DateTime addTS_, int adderId_, int? modderId_ = default, DateTime modTS_ = default)		{
			this.id = id_;
			this.locationId = locationId_;
			this.addTS = addTS_;
			this.adderId = adderId_;
			this.modderId = modderId_;
			this.modTS = modTS_;
		}
	}
}