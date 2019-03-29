using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ArquivoApp
{
    public partial class MainPage : ContentPage
    {
        ArrayList lista = new ArrayList();

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            string nome = Path.GetRandomFileName() + ".txt";
            string nomeArquivo = Path.Combine(App.PastaDiretorio, $"{nome}");

            File.Create(nomeArquivo);
            label_inicial.Text = "Adicionando...";
            lista.Add(nomeArquivo);
        }

        void checarLista(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new PageListaArquivo());
        }

        public MainPage()
        {
            InitializeComponent();
            label_inicial.Text = App.ValorContexto;
        }

        void quebrarString(object sender, System.EventArgs e)
        {
            string conteudoEditor = editor_valor.Text;
            //var arrayConteudo = conteudoEditor.Split('_');
            //label_inicial.Text = arrayConteudo[arrayConteudo.Count()-1];

            int indice = conteudoEditor.LastIndexOf('_');
            label_inicial.Text = conteudoEditor.Substring(indice+1);
        }
    }
}
