using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace ArquivoApp
{
    public partial class App : Application
    {
        public static string ValorContexto { get; set ; }
        public static string PastaDiretorio { get; set; }

        public App()
        {
            InitializeComponent();

            ValorContexto = "Nosso Valor";
            PastaDiretorio = Path.Combine(Environment.GetFolderPath
                ( Environment.SpecialFolder.LocalApplicationData )
            );

            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
