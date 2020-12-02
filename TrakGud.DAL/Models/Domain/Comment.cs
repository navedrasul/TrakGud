using System;
using System.Collections.Generic;
using System.Text;

namespace TrakGud.DAL.Models.Domain
{
	public class Comment
	{
		public int id { get; set; }
		public int commentsThreadId { get; set; }
		public  TS { get; set; }
		public DateTime addTS { get; set; }
		public int adderId { get; set; }
		public int? parentCommentId { get; set; }
		public int? modderId { get; set; }
		public bool? isRemoved { get; set; }
		public DateTime modTS { get; set; }

		public Comment(int id_, int commentsThreadId_,  TS_, DateTime addTS_, int adderId_, int? parentCommentId_ = default, int? modderId_ = default, bool? isRemoved_ = default, DateTime modTS_ = default)		{
			this.id = id_;
			this.commentsThreadId = commentsThreadId_;
			this.TS = TS_;
			this.addTS = addTS_;
			this.adderId = adderId_;
			this.parentCommentId = parentCommentId_;
			this.modderId = modderId_;
			this.isRemoved = isRemoved_;
			this.modTS = modTS_;
		}
	}
}