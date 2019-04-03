using Agenda.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Agenda.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class NewPersonView : ContentPage
	{
		public NewPersonView ()
		{
			InitializeComponent ();
            BindingContext = new NewPersonViewModel();
		}
	}
}