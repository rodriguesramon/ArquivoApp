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
        public PageListaArquivo(){
            InitializeComponent();
            NavigationPage.SetHasBackButton(this, false);
        }

        void voltar(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }

        async void Handle_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            //await DisplayAlert("Titulo", e.SelectedItem.ToString(), "Ok");
            //Path.Combine(App.PastaDiretorio, $"{nome}");

            var resposta = await DisplayAlert("Tittulo", 
                                              "Deseja Excluir", 
                                              "Sim", "Naum");

            if (resposta == true) { 
                File.Delete(Path.Combine(
                    App.PastaDiretorio, $"{e.SelectedItem.ToString()}")
                           );
                await Navigation.PushAsync(new PageListaArquivo());
            }
        }

        protected override void OnAppearing()
        {

            var meusarquivos = new List<Arquivo>();

            var arquivos = Directory.EnumerateFiles(
                App.PastaDiretorio, "*.txt"
            );

            foreach(var nomedoarquivo in arquivos){
                //int indice = nomedoarquivo.LastIndexOf('/');
                //listadearquivos.Add(nomedoarquivo.Substring(indice+1));

                meusarquivos.Add(new Arquivo { Conteudo = "Teste..." });
            }

            listView_listaArquivo.ItemsSource = meusarquivos;
        }
    }
}
