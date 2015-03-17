using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.Models
{
    public class Libros
    {
        private ObservableCollection<Libro> data;
        public ObservableCollection<Libro> Data
        {
            get
            {
                if (data == null)
                {
                    data = new ObservableCollection<Libro>();
                    Libro libro1 = new Libro()
                    {
                        Nombre = "Padre rico padre pobre",
                        Autor = "Robert",
                        Codigo = "A101",
                        Genero = "Economía",
                        Paginas = 300
                    };
                    Libro libro2 = new Libro()
                    {
                        Nombre = "El caballero de la armadura oxidada",
                        Autor = "Anónimo",
                        Codigo = "A102",
                        Genero = "Superación personal",
                        Paginas = 100
                    };
                    Libro libro3 = new Libro()
                    {
                        Nombre = "Cien años de soledad",
                        Autor = "Gabriel García Márquez",
                        Codigo = "A103",
                        Genero = "Novela",
                        Paginas = 500
                    };
                    data.Add(libro1);
                    data.Add(libro2);
                    data.Add(libro3);
                }
                return data;
            }
            set
            {

            }
        }
    }
}
