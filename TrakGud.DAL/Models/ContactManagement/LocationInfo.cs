using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TrakGud.DAL.Models.ContactManagement
{
[Table("cm__LocationInfo")]	public class LocationInfo
	{
		public int id { get; set; }
		public string name { get; set; }
		public int addressId { get; set; }

		public LocationInfo() { }


		public LocationInfo(int id, string name, int addressId)		{
			this.id = id;
			this.name = name;
			this.addressId = addressId;
		}
	}
}