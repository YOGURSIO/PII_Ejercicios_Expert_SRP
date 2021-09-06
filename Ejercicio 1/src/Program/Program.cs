using System;


namespace SRP
{
    
    public class Program
    {

        static void Main(string[] args)
        {
            Libro libro1 = new Libro("Design Patterns","Erich Gamma & Others","001-034");
            Libro libro2 = new Libro("Pro C#","Troelsen","001-035");
            
            /* Aca queria buscar una forma de no tener que hacer un Almacenar X = new Almacenar() no lo logre*/
            Almacenar SectorA = new Almacenar("A","7",libro1) ;
            Almacenar SectorB = new Almacenar("B","3",libro2) ;

        }
        
    }
}
