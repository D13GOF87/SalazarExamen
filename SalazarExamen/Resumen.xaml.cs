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
		public Resumen(string user, string name, string montoInicial, string pagoMensual)
		{
			InitializeComponent();
			lblUsuario.Text = user;
			txtNombre.Text = name;
			txtMonto.Text = montoInicial;
			CalcularMonto(pagoMensual);
		}

		private void CalcularMonto(string PagoMensual)
		{
			double pagoMensual = 0;
			try
			{
				pagoMensual = Math.Round(3 * Convert.ToDouble(PagoMensual),2);
				txtPago.Text = pagoMensual.ToString();

			}
			catch (Exception ex)
			{
				DisplayAlert("Mensaje de alerta", ex.Message, "ok");
			}
		}
	}
}