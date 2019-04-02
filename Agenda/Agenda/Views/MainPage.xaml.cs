using Agenda.Data;
using Agenda.Model;
using Agenda.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Agenda
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainPageViewModel();

            ObservableCollection<Person> p = Local.ReadPersons();
            Debug.WriteLine(p[0].DOB);
        }

        private void PersonsLV_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            ((MainPageViewModel)BindingContext).SelectOnePersons(e.SelectedItem as Person);
        }
    }
}
