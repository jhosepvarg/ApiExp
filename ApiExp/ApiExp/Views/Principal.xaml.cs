using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ApiExp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Principals : MasterDetailPage
    {
        public Principals()
        {
            InitializeComponent();
            this.Master = new master();
            this.Detail = new NavigationPage(new detail());

            App.MasterD = this;
        }
    }
}