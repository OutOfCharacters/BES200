using System;

namespace LibraryApi.Domain
{
    public enum ReservationStatus {  Pending, Approved, Cancelled };
    public class Reservation
    {
        public int Id { get; set; }
        public string For { get; set; }
        public DateTime ReservationCreated { get; set; }
        public string Books { get; set; } // "1,2,3"... for books they want
        public ReservationStatus Status { get; set; }
    }
}
