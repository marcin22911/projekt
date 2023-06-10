using Microsoft.AspNetCore.Identity;

namespace MoveMentor.Models
{
	public class Trening
	{
		public int Id { get; set; }
		public DateTime DateTimeStart { get; set; }
		public DateTime DateTimeEnd { get; set; }
		public int SportTypeId { get; set; }
		public virtual SportType? SportType { get; set; }
		public string? UserId { get; set; }
		public virtual IdentityUser? User { get; set; }
	}
}
