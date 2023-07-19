using Management.Application.UseCases;
using Management.Domain.Entities;
using Management.Shared;

namespace Management.API.Services
{
    public class ManagementModuleAPI : IManagementModuleAPI
    {
        private readonly GetDoctorTimeSlot _getDoctorTimeSlot;
        private readonly GetDoctorAvailableTimeSlots _getDoctorAvailableTimeSlots;
        private readonly BookDoctorTimeSlot _bookDoctorTimeSlot;

        public ManagementModuleAPI(GetDoctorTimeSlot getDoctorTimeSlot, GetDoctorAvailableTimeSlots getDoctorAvailableTimeSlots, BookDoctorTimeSlot bookDoctorTimeSlot)
        {
            _getDoctorTimeSlot = getDoctorTimeSlot;
            _getDoctorAvailableTimeSlots = getDoctorAvailableTimeSlots;
            _bookDoctorTimeSlot = bookDoctorTimeSlot;
        }

        public async Task<List<DoctorTimeSlot>> GetTimeSlotsByDoctorId(Guid doctorId)
        {
            var doctorTimeSlot = await _getDoctorTimeSlot.Execute(doctorId);
            return doctorTimeSlot;
        }

        public async Task<List<DoctorTimeSlot>> GetAvailableTimeSlots()
        {
            var doctorAvailableTimeSlot = await _getDoctorAvailableTimeSlots.Execute();
            return doctorAvailableTimeSlot;
        }

        public async Task ReserveTimeSlot(Guid id)
        {
            await _bookDoctorTimeSlot.Execute(id);
        }


    }
}
