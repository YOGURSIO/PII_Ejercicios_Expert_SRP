using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona persona1 = new Persona("Miguel","5555555-5","09999999", 38);
            Doctor doctorpersona1 = new Doctor("Su casa","Doctor Apitutao");

           AppointmentService.CreateAppointment(DateTime.Now, doctorpersona1, persona1);

            Persona persona2 = new Persona("","5555555-5","09999999", 38);
            Doctor doctorpersona2 = new Doctor("Su casa","Doctor Apitutao");

            AppointmentService.CreateAppointment(DateTime.Now, doctorpersona2, persona2);
        }
    }
}
