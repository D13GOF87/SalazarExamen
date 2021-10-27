using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SalazarExamen
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Resumen : ContentPage
	{
		public Resumen(String user, String name, String pagoMensual)
		{
			InitializeComponent();
			lblUsuario.Text = user;
			txtNombre.Text = name;
			calcularMonto(pagoMensual);
		}

		private void calcularMonto(String PagoMensual)
		{
			double pagoMensual = 0;
			try
			{
				pagoMensual = 3 * Convert.ToDouble(PagoMensual);
				txtMonto.Text = pagoMensual.ToString();

			}
			catch (Exception ex)
			{
				DisplayAlert("Mensaje de alerta", ex.Message, "ok");
			}
		}
	}
}