﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppAutoLAvado
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Resumen : ContentPage
    {
        public Resumen(string fecha,float precio, string mensaje)
        {
            InitializeComponent();
            lblFecha.Text = fecha;
            lblPrecio.Text = precio.ToString();
            lblServicios.Text = mensaje;
        }
    }
}