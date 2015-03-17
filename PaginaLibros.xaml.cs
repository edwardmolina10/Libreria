using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Libreria.Resources;
using Libreria.Models;

namespace Libreria
{
    public partial class PaginaLibros : PhoneApplicationPage
    {
        public PaginaLibros()
        {
            InitializeComponent();
        }

        private void goToPage(object sender, System.Windows.Input.GestureEventArgs e)
        {
           var libroSeleccionado = lista.SelectedItem as Libro;

            var nombre = libroSeleccionado.Nombre;
            var codigo = libroSeleccionado.Codigo;
            var autor = libroSeleccionado.Autor;
            var genero = libroSeleccionado.Genero;
            var paginas = libroSeleccionado.Paginas;

            string direccion = "/PaginaDetalleLibro.xaml?nombre=" + nombre+"&codigo="+codigo+"&autor="+autor+"&genero="+genero+"&paginas="+paginas;
            
            NavigationService.Navigate(new Uri(direccion, UriKind.Relative));
        }
    }
}