using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using Xamarin.Forms;

namespace ArquivoApp
{
    public partial class PageListaArquivo : ContentPage
    {
        ArrayList listadearquivos = new ArrayList();
        public PageListaArquivo()
        {
            InitializeComponent();
        }

        async void Handle_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            await DisplayAlert("Titulo", e.SelectedItem.ToString(), "Ok");
        }

        protected override void OnAppearing()
        {
            var arquivos = Directory.EnumerateFiles(
                App.PastaDiretorio, "*.txt"
            );
            foreach(var nomedoarquivo in arquivos){
                int indice = nomedoarquivo.LastIndexOf('/');

                listadearquivos.Add(nomedoarquivo.Substring(indice+1));
            }

            listView_listaArquivo.ItemsSource = listadearquivos;
        }
    }
}
