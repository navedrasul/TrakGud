using System;
using System.Collections.Generic;
using System.Text;

namespace TrakGud.DAL.Models.Domain
{
	public class ItemRemovalHistory
	{
		public int batchId { get; set; }
		public int removerId { get; set; }
		public DateTime TS { get; set; }

		public ItemRemovalHistory(int batchId_, int removerId_, DateTime TS_ = default)		{
			this.batchId = batchId_;
			this.removerId = removerId_;
			this.TS = TS_;
		}
	}
}