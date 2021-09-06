using System;
using System.Text;

namespace Library
{
    public class Doctor
    {
        private string appointmentPlace;
        private string doctorName;


        public string AppointmentPlace
        {
            get
            {
                return this.appointmentPlace;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                    {
                        Console.WriteLine($"Unable to schedule appointment, {value} is an invalid Place of the Appointment\n");
                        AppointmentService.isValid = false;
                    }
                    else
                    {
                        this.appointmentPlace=value;
                    }
            }
        }

        public string DoctorName
        {
            get
            {
                return this.doctorName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                    {
                        Console.WriteLine($"Unable to schedule appointment, {value} is an invalid Name\n");
                        AppointmentService.isValid = false;
                    }
                    else
                    {
                        this.doctorName=value;
                    }
            }
        }

        public Doctor(string appointmentPlace, string doctorName)
        {
            this.AppointmentPlace = appointmentPlace;
            this.DoctorName = doctorName;
        }
    }
}
