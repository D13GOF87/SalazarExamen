using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SalazarExamen
{
	public partial class Login : ContentPage
	{
		public Login()
		{
			InitializeComponent();
		}

		private async void btnIngresar_Clicked(object sender, EventArgs e)
		{
			String user = txtUsuario.Text;

			try{
				if (txtUsuario.Text.Equals("estudiante2021") && txtClave.Text.Equals("uisrael2021"))
					await Navigation.PushAsync(new Registro(user));
				else
				{
					await DisplayAlert("Error datos de usuario", "Usuario y/o Contraseña incorrecta", "Ok");
					LimpiarCampos();
				}
					
			}
			catch (NullReferenceException)
			{
				await DisplayAlert("Alerta","Ingrese los datos solicitados", "ok");
			}
			catch (Exception ex)
			{
				await DisplayAlert("Mensaje de alerta", ex.Message, "ok");
			}
		}

		private void LimpiarCampos()
		{
			txtUsuario.Text = "";
			txtClave.Text = "";
		}
	}
}
