using Management.Application.UseCases;
using Management.Shared;

namespace Management.API.Services
{
    public class ManagementModuleAPI : IManagementModuleAPI
    {
        private readonly BookDoctorTimeSlot _bookDoctorTimeSlot;
        private readonly GetDoctorTimeSlotById _getDoctorTimeSlotById;

        public ManagementModuleAPI(GetDoctorTimeSlotById getDoctorTimeSlotById, GetDoctorTimeSlot getDoctorTimeSlot, GetDoctorAvailableTimeSlots getDoctorAvailableTimeSlots, BookDoctorTimeSlot bookDoctorTimeSlot)
        {
            _bookDoctorTimeSlot = bookDoctorTimeSlot;
            _getDoctorTimeSlotById = getDoctorTimeSlotById;
        }

        public async Task ReserveTimeSlot(Guid id)
        {
            await _bookDoctorTimeSlot.Execute(id);
        }
        public async Task<DoctorTimeSlotDto?> GetTimeSlotById(Guid id)
        {
            var doctorTimeSlot = await _getDoctorTimeSlotById.Execute(id);
            if (doctorTimeSlot == null) return null;
            return new DoctorTimeSlotDto(
                doctorTimeSlot.Id,
                doctorTimeSlot.Time,
                doctorTimeSlot.DoctorId,
                doctorTimeSlot.DoctorName,
                doctorTimeSlot.IsReserved,
                doctorTimeSlot.Cost
            );
        }
    }
}
