using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.Models
{
    public class Libro: INotifyPropertyChanged
    {
        private String nombre;
        public String Nombre {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("Nombre"));
                }
            }
        }

        private String codigo;
        public String Codigo {
            get
            {
                return codigo;
            }
            set
            {
                codigo = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("Codigo"));
                }
            }
        }

        private String autor;
        public String Autor {
            get
            {
                return autor;
            }
            set
            {
                autor = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("Autor"));
                }
            }
        }

        private String genero;
        public String Genero {

            get
            {
                return genero;
            }
            set
            {
                genero = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("Genero"));
                }
            }
        }

        private int paginas;
        public int Paginas {

            get
            {
                return paginas;
            }
            set
            {
                paginas = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("Paginas"));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
