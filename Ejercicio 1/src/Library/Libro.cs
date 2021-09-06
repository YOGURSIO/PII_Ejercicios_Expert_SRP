using System;

namespace SRP
{
    public class Libro
    {

        public string Titulo { get ; }
        public string Autor { get ; }
        public string Codigo { get ;  }
        public string SectorBiblioteca { get ; set; }
        public string EstanteBiblioteca { get ; set; }

        public Libro(String titulo, String autor, String codigo)
        {
            this.Titulo = titulo;
            this.Autor = autor;
            this.Codigo = codigo;
        }

        public void AlmacenarLibro(String sector, String estante)
        {
            this.SectorBiblioteca = sector;
            this.EstanteBiblioteca = estante;
        }
        /* Esto no cumple con el SRP ya que el SectorBiblioteca y EstanteBiblioteca no tiene 
        sentido que formen parte de la Class Libro, para que cumpla el SRP tendria que haber 
        una clase Biblioteca, por ejemplo, donde este esta informacion 
        */
    }
}
