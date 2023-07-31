using DoctorAppointmentBookingLayered.Shared;
using Booking.Application.Dtos;

namespace Booking.Application.UseCases
{
    public class GetBookedDoctorTimeSlotByIdLayered
    {
        private readonly IManagementModuleAPILayered _managementModuleAPI;

        public GetBookedDoctorTimeSlotByIdLayered(IManagementModuleAPILayered managementModuleAPI)
        {
            _managementModuleAPI = managementModuleAPI;
        }
        public async Task<BookedDoctorTimeSlotDto?> Execute(Guid slotId)
        {
            var doctorTimeSlotDto = await _managementModuleAPI.GetTimeSlotById(slotId);
            if (doctorTimeSlotDto == null) return null;
            return new BookedDoctorTimeSlotDto(
                doctorTimeSlotDto.Id,
                doctorTimeSlotDto.Time,
                doctorTimeSlotDto.DoctorId,
                doctorTimeSlotDto.DoctorName,
                doctorTimeSlotDto.IsReserved,
                doctorTimeSlotDto.Cost
            );
        }
    }

}
