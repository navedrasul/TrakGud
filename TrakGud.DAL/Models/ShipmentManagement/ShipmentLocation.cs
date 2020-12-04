using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TrakGud.DAL.Models.ShipmentManagement
{
[Table("sm__ShipmentLocation")]	public class ShipmentLocation
	{
		public int id { get; set; }
		public string typeId { get; set; }

		public ShipmentLocation() { }


		public ShipmentLocation(int id, string typeId)		{
			this.id = id;
			this.typeId = typeId;
		}
	}
}