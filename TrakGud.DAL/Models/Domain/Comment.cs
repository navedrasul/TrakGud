using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TrakGud.DAL.Models.Domain
{
[Table("d__Comment")]	public class Comment
	{
		public int id { get; set; }
		public int commentsThreadId { get; set; }
		public DateTime addTS { get; set; }
		public int adderId { get; set; }
		public int? parentCommentId { get; set; }
		public int? modderId { get; set; }
		public bool? isRemoved { get; set; }
		public DateTime? modTS { get; set; }
		public DateTime? TS { get; set; }

		public Comment() { }


		public Comment(int id, int commentsThreadId, DateTime addTS, int adderId, int? parentCommentId = default, int? modderId = default, bool? isRemoved = default, DateTime? modTS = default, DateTime? TS = default)		{
			this.id = id;
			this.commentsThreadId = commentsThreadId;
			this.addTS = addTS;
			this.adderId = adderId;
			this.parentCommentId = parentCommentId;
			this.modderId = modderId;
			this.isRemoved = isRemoved;
			this.modTS = modTS;
			this.TS = TS;
		}
	}
}