using System;
using System.Collections.Generic;
using System.Text;

namespace TrakGud.DAL.Models.Domain
{
	public class Comment
	{
		public int id { get; set; }
		public int commentsThreadId { get; set; }
		public DateTime addTS { get; set; }
		public int adderId { get; set; }
		public int? parentCommentId { get; set; }
		public int? modderId { get; set; }
		public bool? isRemoved { get; set; }
		public DateTime modTS { get; set; }
		public DateTime TS { get; set; }

		public Comment(int id_, int commentsThreadId_, DateTime addTS_, int adderId_, int? parentCommentId_ = default, int? modderId_ = default, bool? isRemoved_ = default, DateTime modTS_ = default, DateTime TS_ = default)		{
			this.id = id_;
			this.commentsThreadId = commentsThreadId_;
			this.addTS = addTS_;
			this.adderId = adderId_;
			this.parentCommentId = parentCommentId_;
			this.modderId = modderId_;
			this.isRemoved = isRemoved_;
			this.modTS = modTS_;
			this.TS = TS_;
		}
	}
}