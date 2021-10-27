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
	public partial class Registro : ContentPage
	{
		private const string V = " ";

		public Registro(String user)
		{
			InitializeComponent();
			lblUsuario.Text += V + user;
		}

		private void btnCalcular_Clicked(object sender, EventArgs e)
		{
			try {
				double Monto = Convert.ToDouble(txtMonto.Text);
				double PagoMensual = 0;

				if (Monto < 1)
				{
					DisplayAlert("Mensaje de alerta", "Por favor ingrese valores mayores a $1", "OK");
				}
				else
				{
					PagoMensual = Math.Round((1800 - Monto) / 3 + (1800 * 0.05),2);
					txtPago.Text = PagoMensual.ToString();
				}
			}
			catch (Exception ex)
			{
				DisplayAlert("Mensaje de alerta", ex.Message, "ok");
			}

		}

		private async void btnGuardar_Clicked(object sender, EventArgs e)
		{
			try
			{
				string User, Name, PagoMensual;

				if (txtNombre.Text.Equals(""))
				{
					await DisplayAlert("Alerta", "Ingrese Nombre", "ok");
				}
				else 
				{
					User = lblUsuario.Text;
					Name = txtNombre.Text;
					PagoMensual = txtPago.Text;
					await DisplayAlert("Mensaje", "Elemento guardado con exito", "OK");
					await Navigation.PushAsync(new Resumen(User, Name, PagoMensual));
				}

			}
			catch (NullReferenceException)
			{
				await DisplayAlert("Alerta", "Ingrese los datos solicitados", "ok");
			}
			catch (Exception ex)
			{
				await DisplayAlert("Mensaje de alerta", ex.Message, "ok");
			}
		}

		private void LimpiarCampos()
		{
			txtMonto.Text = "";
			txtNombre.Text = "";
			txtPago.Text = "";
		}
	}
}