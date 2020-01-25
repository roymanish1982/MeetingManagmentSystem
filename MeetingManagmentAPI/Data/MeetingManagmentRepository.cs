using MeetingManagmentAPI.Data.DataContext;
using MeetingManagmentAPI.Data.Entities;
using MeetingManagmentAPI.Models;
using System.Collections.Generic;
using System.Linq;

namespace MeetingManagmentAPI.Data
{
	public class MeetingManagmentRepository : IMeetingManagmentRepository
	{
		/// <summary>
		/// </summary>
		private readonly MeetingManagmentDbContext dbCntx;

		/// <summary>
		/// </summary>
		/// <param name="meetingManagmentDbContext"></param>
		public MeetingManagmentRepository(MeetingManagmentDbContext meetingManagmentDbContext)
		{
			this.dbCntx = meetingManagmentDbContext;
		}

		/// <summary>
		/// </summary>
		/// <returns></returns>
		public IEnumerable<Attendee> GetAttendees()
		{
			return dbCntx
					.Attendees
					.OrderBy(x => x.AttendeeEmail)
					.ToList();
		}

		/// <summary>
		/// </summary>
		/// <returns></returns>
		public IEnumerable<MeetingInformation> GetAllMeetingDetails()
		{
			List<MeetingInformation> mInformation = new List<MeetingInformation>();
			List<MeetingDetail> meetings = dbCntx.MeetingDetails.ToList();

			meetings.ForEach(meeting =>
			{
				mInformation.Add(new MeetingInformation
				{
					MeetingDetailID = meeting.MeetingDetailID,
					MeetingAgenda = meeting.MeetingAgenda,
					MeetingDate = meeting.MeetingDate,
					MeetingSubject = meeting.MeetingSubject,
					Attendees = (from a in dbCntx.Attendees
								 join ma in dbCntx.MeetingAttendeDetails
								 on a.AttendeeID equals ma.AttendeeID
								 where ma.MeetingDetailsID == meeting.MeetingDetailID
								 select new Attendee
								 {
									 AttendeeID = ma.AttendeeID,
									 AttendeeEmail = a.AttendeeEmail
								 })
				});
			});

			return mInformation;
		}

		/// <summary>
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		public MeetingInformation GetMeetingDetailsByMeetingId(int id)
		{
			List<MeetingInformation> mInformation = new List<MeetingInformation>();
			MeetingDetail meetings = dbCntx.MeetingDetails.FirstOrDefault(x => x.MeetingDetailID == id);

			if (meetings == null)
			{
				return null;
			}

			return new MeetingInformation
			{
				MeetingDetailID = meetings.MeetingDetailID,
				MeetingAgenda = meetings.MeetingAgenda,
				MeetingDate = meetings.MeetingDate,
				MeetingSubject = meetings.MeetingSubject,
				Attendees = (from a in dbCntx.Attendees
							 join ma in dbCntx.MeetingAttendeDetails
							 on a.AttendeeID equals ma.AttendeeID
							 where ma.MeetingDetailsID == meetings.MeetingDetailID
							 select new Attendee
							 {
								 AttendeeID = ma.AttendeeID,
								 AttendeeEmail = a.AttendeeEmail
							 })
			};
		}

		public bool Update(MeetingInformation meetingInformation)
		{
			throw new System.NotImplementedException();
		}

		public bool Add(MeetingInformation meetingInformation)
		{
			throw new System.NotImplementedException();
		}
	}
}