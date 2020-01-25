using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeetingManagmentAPI.Data.Entities
{
	public class MeetingDetail
	{
		public int MeetingDetailID { get; set; }
		public string MeetingSubject { get; set; }
		public string MeetingAgenda { get; set; }
		public DateTime MeetingDate { get; set; }
	}
}
