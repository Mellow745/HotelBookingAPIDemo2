using Microsoft.EntityFrameworkCore;
using HotelBookingAPI2.Models;

namespace HotelBookingAPI2.Data
{
    public class ApiContext : DbContext
    {
        public ApiContext(DbContextOptions<ApiContext> options) : base(options)
        {
        }

        public DbSet<HotelBooking> Bookings { get; set; }
    }
}
