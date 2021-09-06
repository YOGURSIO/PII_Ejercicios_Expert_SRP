using System;
using System.Text;

namespace Library
{
    public class AppointmentService
    {
        
        public static Boolean isValid = true;
        public static int identificador = 0;
       
        public static void CreateAppointment(DateTime date, Doctor doctor, Persona persona)
        {
            if (isValid == true)
            {
                identificador++;
                Console.WriteLine($"Your appointment was successfully scheduled, your identification code is {identificador}");
                
            }
            else
            {
                Console.WriteLine($"Your appointment could not be scheduled");
            }
        }
        
    }
}
