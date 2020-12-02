using System;
using System.Collections.Generic;
using System.Text;

namespace TrakGud.DAL.Models.ContactManagement
{
	public class Note
	{
		public int id { get; set; }
		public string text { get; set; }

		public Note(int id_, string text_ = default)		{
			this.id = id_;
			this.text = text_;
		}
	}
}