using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace Libreria
{
    public partial class PaginaDetalleLibro : PhoneApplicationPage
    {
        public PaginaDetalleLibro()
        {
            InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (NavigationContext.QueryString.ContainsKey("nombre"))
            {
                String nombre = NavigationContext.QueryString["nombre"];
                tituloPagina.Text = nombre;
            }
            if (NavigationContext.QueryString.ContainsKey("codigo"))
            {
                String codigo = NavigationContext.QueryString["codigo"];
                codigoLibro.Text = codigo;
            }
            if (NavigationContext.QueryString.ContainsKey("autor"))
            {
                String autor = NavigationContext.QueryString["autor"];
                autorLibro.Text = autor;
            }
            if (NavigationContext.QueryString.ContainsKey("genero"))
            {
                String genero = NavigationContext.QueryString["genero"];
                generoLibro.Text = genero;
            }
            if (NavigationContext.QueryString.ContainsKey("paginas"))
            {
                String paginas = NavigationContext.QueryString["paginas"];
                paginasLibro.Text = paginas;
            }
        }
    }
}