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
        public  MainPage()
        {
            InitializeComponent();
            BindingContext = new MainPageViewModel(new PageService());


            Task.Run(() => { Move(); }); ;
                
            
        }

        private async void Move()
        {
            while (true)
            {
                await TitleLabel.TranslateTo(500, 0, 5000);
                await TitleLabel.TranslateTo(-500, 0, 5000);
            }
           // await TitleLabel.TranslateTo(500, 0, 1000);
        }

        //private void PersonsLV_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        //{
        //    ((MainPageViewModel)BindingContext).SelectOnePersons(e.SelectedItem as Person);
        //}

        private void MenuItem_Clicked(object sender, EventArgs e)
        {
            PersonViewModel person = (sender as MenuItem).CommandParameter as PersonViewModel;
            (BindingContext as MainPageViewModel).DeleteCommand.Execute(person);
        }

        private async void MenuItem_Clicked_1(object sender, EventArgs e)
        {
            PersonViewModel person = (sender as MenuItem).CommandParameter as PersonViewModel;
            Debug.WriteLine(person.Name);
           await (BindingContext as MainPageViewModel).SelectPerson(person);
        }
    }
}
