using System;
using System.Text;

namespace Library
{
    public class Persona
    {
        private string name;
        private string id;
        private string phoneNumber;
        private int edad;

        public string Name
        {
            get
            {
                return this.name;
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
                        this.name=value;
                    }
            }
        }

        public string Id
        {
            get
            {
                return this.id;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                    {
                        Console.WriteLine($"Unable to schedule appointment, {value} is an invalid Id\n");
                        AppointmentService.isValid = false;
                    }
                    else
                    {
                        this.id=value;
                    }
            }
        }

        public string PhoneNumber
        {
            get
            {
                return this.phoneNumber;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                    {
                        Console.WriteLine($"Unable to schedule appointment, {value} is an invalid Phone Number\n");
                        AppointmentService.isValid = false;
                    }
                    else
                    {
                        this.phoneNumber=value;
                    }
            }
        }

        public int Edad
        {
            get
            {
                return this.edad;
            }
            set
            {
                if (value < 0)
                    {
                        Console.WriteLine($"Unable to schedule appointment, {value} is an invalid Age\n");
                        AppointmentService.isValid = false;
                    }
                    else
                    {
                        this.edad= value;
                    }
            }
        }

        public Persona (string name, string id, string phoneNumber, int edad)
        {
            this.Name=name;
            this.Id=id;
            this.PhoneNumber=phoneNumber;
            this.Edad=edad;
        }
    }
}
