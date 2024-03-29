﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace COVID_19_Vaccination_System.Models
{
    public class CreateAppointmentViewModel
    {
        public AppointmentModel Appointment { get; set; }
        public List<VaccineModel> VaccineList { get; set; }
        public List<String> AvailableVaccineNameList { get; set; }
        public List<DateTime> AvailableDays { get; set; }
        public bool CanAppoint { get; set; }

        public CreateAppointmentViewModel()
        {
            Appointment = new AppointmentModel();
        }
    }
}