using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TrakGud.DAL.Models.Domain
{
[Table("d__CommentsThread")]	public class CommentsThread
	{
		public int id { get; set; }
		public bool? isVisible { get; set; }
		public bool? isBlocked { get; set; }

		public CommentsThread() { }


		public CommentsThread(int id, bool? isVisible = default, bool? isBlocked = default)		{
			this.id = id;
			this.isVisible = isVisible;
			this.isBlocked = isBlocked;
		}
	}
}