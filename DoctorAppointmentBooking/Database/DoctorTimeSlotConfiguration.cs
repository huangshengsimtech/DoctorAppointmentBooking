using DoctorAppointmentBooking.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DoctorAppointmentBooking.Database
{
    public class DoctorTimeSlotConfiguration : IEntityTypeConfiguration<DoctorTimeSlot>
    {
        public void Configure(EntityTypeBuilder<DoctorTimeSlot> builder)
        {
            builder.ToTable("DoctorTimeSlots");
            builder.HasKey(x => x.Id);
        }
    }
}
