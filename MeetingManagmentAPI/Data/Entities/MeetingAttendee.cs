using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MeetingManagmentAPI.Data.Entities
{
	public class MeetingAttendee
	{
		public int MeetingAttendeeID { get; set; }
		public int MeetingDetailsID { get; set; }
		public int AttendeeID { get; set; }
	}
}
