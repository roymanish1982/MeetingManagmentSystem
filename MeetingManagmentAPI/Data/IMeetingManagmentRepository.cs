using MeetingManagmentAPI.Data.Entities;
using MeetingManagmentAPI.Models;
using System.Collections.Generic;

namespace MeetingManagmentAPI.Data
{
	public interface IMeetingManagmentRepository
	{
		/// <summary>
		/// </summary>
		/// <returns></returns>
		IEnumerable<Attendee> GetAttendees();

		/// <summary>
		/// </summary>
		/// <returns></returns>
		IEnumerable<MeetingInformation> GetAllMeetingDetails();

		/// <summary>
		/// </summary>
		/// <returns></returns>
		MeetingInformation GetMeetingDetailsByMeetingId(int id);

		/// <summary>
		/// </summary>
		/// <param name="meetingInformation"></param>
		/// <returns></returns>
		bool Add(MeetingInformation meetingInformation);

		/// <summary>
		/// </summary>
		/// <param name="meetingInformation"></param>
		/// <returns></returns>
		bool Update(MeetingInformation meetingInformation);
	}
}