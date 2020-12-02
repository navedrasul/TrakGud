using System;
using System.Collections.Generic;
using System.Text;

namespace TrakGud.DAL.Models.Domain
{
	public class Buyer
	{
		public int id { get; set; }
		public string name { get; set; }
		public string buyerType { get; set; }
		public DateTime addTS { get; set; }
		public int adderId { get; set; }
		public int? commentsThreadId { get; set; }
		public int? contactId { get; set; }
		public int? modderId { get; set; }
		public string RCT { get; set; }
		public string RST { get; set; }
		public DateTime modTS { get; set; }

		public Buyer(int id_, string name_, string buyerType_, DateTime addTS_, int adderId_, int? commentsThreadId_ = default, int? contactId_ = default, int? modderId_ = default, string RCT_ = default, string RST_ = default, DateTime modTS_ = default)		{
			this.id = id_;
			this.name = name_;
			this.buyerType = buyerType_;
			this.addTS = addTS_;
			this.adderId = adderId_;
			this.commentsThreadId = commentsThreadId_;
			this.contactId = contactId_;
			this.modderId = modderId_;
			this.RCT = RCT_;
			this.RST = RST_;
			this.modTS = modTS_;
		}
	}
}