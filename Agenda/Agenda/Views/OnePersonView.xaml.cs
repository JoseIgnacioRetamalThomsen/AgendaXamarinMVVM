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
	public partial class OnePersonView : ContentPage
	{
		public OnePersonView (PersonViewModel person)
		{
			InitializeComponent ();
            BindingContext = new OnePersonViewModel(person);
		}
	}
}