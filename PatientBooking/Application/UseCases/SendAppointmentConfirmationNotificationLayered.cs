using Booking.Application.Dtos;
using Notification.Shared;

namespace Booking.Application.UseCases
{
    public class SendAppointmentConfirmationNotificationLayered
    {
        private readonly GetBookedDoctorTimeSlotByIdLayered _getBookedDoctorTimeSlotById;
        private readonly INotificationModuleAPI _notificationModuleAPI;

        public SendAppointmentConfirmationNotificationLayered(GetBookedDoctorTimeSlotByIdLayered getBookedDoctorTimeSlotById,
                                                        INotificationModuleAPI notificationModuleAPI)
        {
            _getBookedDoctorTimeSlotById = getBookedDoctorTimeSlotById;
            _notificationModuleAPI = notificationModuleAPI;
        }
        public async Task Execute(CreatePatientAppointmentRequest createPatientAppointmentRequest)
        {
            var bookedDoctorTimeSlotDto =
                await _getBookedDoctorTimeSlotById.Execute(createPatientAppointmentRequest.SlotId);
            if (bookedDoctorTimeSlotDto == null) return;

            AppointmentConfirmationDto appointmentConfirmationDto = new AppointmentConfirmationDto(
                createPatientAppointmentRequest.SlotId,
                bookedDoctorTimeSlotDto.DoctorId,
                createPatientAppointmentRequest.PatientId,
                bookedDoctorTimeSlotDto.DoctorName,
                createPatientAppointmentRequest.PatientName,
                bookedDoctorTimeSlotDto.Time
            );
            await _notificationModuleAPI.CreateNotification(appointmentConfirmationDto);
        }
    }

}
