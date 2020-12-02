using System;
using System.Collections.Generic;
using System.Text;

namespace TrakGud.DAL.Models.ShipmentManagement
{
	public class ShipmentLocation
	{
		public int id { get; set; }
		public string typeId { get; set; }

		public ShipmentLocation(int id_, string typeId_)		{
			this.id = id_;
			this.typeId = typeId_;
		}
	}
}