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
            string nome = Path.GetRandomFileName() + ".json";
            string nomeArquivo = Path.Combine(App.PastaDiretorio, $"{nome}");

            string conteudoTexto = editor_valor.Text;

            //File.Create(nomeArquivo);
            File.WriteAllText(nomeArquivo, conteudoTexto);

            label_inicial.Text = "Adicionando...";
            lista.Add(nomeArquivo);

            editor_valor.Text = string.Empty;

        }

        void checarLista(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new PageListaArquivo());
        }

        public MainPage()
        {
            InitializeComponent();
            label_inicial.Text = App.ValorContexto;
            NavigationPage.SetHasBackButton(this, false);
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
