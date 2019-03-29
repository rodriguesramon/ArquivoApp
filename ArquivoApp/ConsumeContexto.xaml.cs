using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ArquivoApp
{
    public partial class ConsumeContexto : ContentPage
    {
        public ConsumeContexto()
        {

            InitializeComponent();

            label_secundario.Text = App.ValorContexto;
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
