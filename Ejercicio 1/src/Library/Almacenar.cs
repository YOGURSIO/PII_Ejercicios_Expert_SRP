using System;


namespace SRP
{
    public class Almacenar
    {

        public string SectorBiblioteca { get ; set; }
        public string EstanteBiblioteca { get ; set; }
        public Libro Libro { get ; set; }


        public Almacenar(String sector, String estante, Libro libro)
        {
            this.SectorBiblioteca = sector;
            this.EstanteBiblioteca = estante;
            this.Libro = libro;

            string DondeLibro = $"El libro {Libro.Titulo} se en cuentra en el {this.SectorBiblioteca} en el estante {this.EstanteBiblioteca}";
            Console.WriteLine(DondeLibro);
        }
        

    }
}