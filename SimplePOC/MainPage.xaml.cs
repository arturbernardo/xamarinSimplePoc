using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace SimplePOC
{
	public partial class MainPage : ContentPage
	{
		public MainPage ()
		{
			InitializeComponent ();
		}

		public void AtualizaContador(Object sender, EventArgs e) {
			double valor = stpContador.Value;
			lblContador.Text = valor.ToString ();
		}

		public void salvaAlgo(Object sender, EventArgs e){
			string descricao = itemQualquer.Text;

			DisplayAlert ("alertando geral", descricao, "Ok");
		}

		public void IrPagna2(){
			PaginaDois tela = new PaginaDois ();
			Navigation.PushAsync (tela);
		}

		public void Clear(){
			lblContador.Text = "";
			stpContador.Value = 10;
		}
	}
}

