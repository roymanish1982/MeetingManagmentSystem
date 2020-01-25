using MeetingManagmentAPI.Data.Entities;
using System.Collections.Generic;

namespace MeetingManagmentAPI.Models
{
	public class MeetingInformation : MeetingDetail
	{
		public IEnumerable<Attendee> Attendees { get; set; }
	}
}