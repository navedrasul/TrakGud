using System;
using System.Collections.Generic;
using System.Text;

namespace TrakGud.DAL.Models.Domain
{
	public class CommentsThread
	{
		public int id { get; set; }
		public bool? isVisible { get; set; }
		public bool? isBlocked { get; set; }

		public CommentsThread(int id_, bool? isVisible_ = default, bool? isBlocked_ = default)		{
			this.id = id_;
			this.isVisible = isVisible_;
			this.isBlocked = isBlocked_;
		}
	}
}