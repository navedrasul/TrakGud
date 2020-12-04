using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TrakGud.DAL.Models.Domain
{
[Table("d__ItemRemovalHistory")]	public class ItemRemovalHistory
	{
		public int batchId { get; set; }
		public int removerId { get; set; }
		public DateTime? TS { get; set; }

		public ItemRemovalHistory() { }


		public ItemRemovalHistory(int batchId, int removerId, DateTime? TS = default)		{
			this.batchId = batchId;
			this.removerId = removerId;
			this.TS = TS;
		}
	}
}