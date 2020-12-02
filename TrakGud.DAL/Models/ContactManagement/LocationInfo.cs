using System;
using System.Collections.Generic;
using System.Text;

namespace TrakGud.DAL.Models.ContactManagement
{
	public class LocationInfo
	{
		public int id { get; set; }
		public string name { get; set; }
		public int addressId { get; set; }

		public LocationInfo(int id_, string name_, int addressId_)		{
			this.id = id_;
			this.name = name_;
			this.addressId = addressId_;
		}
	}
}