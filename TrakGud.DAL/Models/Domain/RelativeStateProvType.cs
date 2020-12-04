using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TrakGud.DAL.Models.Domain
{
[Table("d__RelativeStateProvType")]	public class RelativeStateProvType
	{
		public string value { get; set; }
		public string text { get; set; }

		public RelativeStateProvType() { }


		public RelativeStateProvType(string value, string text)		{
			this.value = value;
			this.text = text;
		}
	}
}