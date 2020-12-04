using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TrakGud.DAL.Models.ContactManagement
{
[Table("cm__Note")]	public class Note
	{
		public int id { get; set; }
		public string text { get; set; }

		public Note() { }


		public Note(int id, string text = default)		{
			this.id = id;
			this.text = text;
		}
	}
}