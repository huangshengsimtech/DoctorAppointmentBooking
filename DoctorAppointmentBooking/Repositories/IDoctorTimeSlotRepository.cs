﻿using DoctorAppointmentBooking.Entities;

namespace DoctorAppointmentBooking.Repositories
{
    public interface IDoctorTimeSlotRepository
    {
        public Task Add(DoctorTimeSlot doctorTimeSlot);
    }
}