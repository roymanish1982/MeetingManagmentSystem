using MeetingManagmentAPI.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace MeetingManagmentAPI.Data.DataContext
{
	public class MeetingManagmentDbContext : DbContext
	{
		public DbSet<User> Users { get; set; }
		public DbSet<Attendee> Attendees { get; set; }
		public DbSet<MeetingDetail> MeetingDetails { get; set; }
		public DbSet<MeetingAttendee> MeetingAttendeDetails { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(@"data source = MANSIH-LAPTOP\SQLEXPRESS; 
									initial catalog=MeetingManagment;
									persist security info=True;user id=manish;password=HD720p$$;");
		}
	}
}
