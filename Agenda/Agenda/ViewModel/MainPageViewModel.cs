using Agenda.Data;
using Agenda.Model;
using Agenda.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Agenda.ViewModel
{
    public class MainPageViewModel : BaseViewModel
    {
        #region Fields
        private ObservableCollection<PersonViewModel> _persons;

        public ObservableCollection<PersonViewModel> Persons
        {
            get
            {
                return _persons;
            }
            set
            {
                SetValue(ref _persons, value);
            }
        }

        private PersonViewModel _selectedPerson;

        public PersonViewModel SelectedPerson
        {
            get
            {
                return _selectedPerson;
            }
            set
            {
                SetValue(ref _selectedPerson, value);
            }
        }

        #endregion

        #region
        public ICommand SaveListCommand { get; private set; }
        public ICommand NavigateToNewCommand { get; private set; }
        public ICommand ViewAcctionCommand { get; private set; }
        public ICommand DeleteCommand { get; private set; }

        private IPageService _pageService;
        #endregion
        public MainPageViewModel(IPageService ps)
        {
            LoadItems();
            _pageService = ps;
            SaveListCommand = new Command(SaveList);
            NavigateToNewCommand = new Command(NavigateToNew);
            ViewAcctionCommand = new Command(ViewAction);
            DeleteCommand = new Command<PersonViewModel>(Delete);
        }

        public async Task SelectPerson(PersonViewModel person)
        {
            // can't use a command directly as there is only a commandRefresh
            // attribute

            if (_persons == null)
                return;
            //await Navigation.PushAsync(new DogDetailsPage(dog));
            /*
             * select a dog, go to the page
             * no Navigation property in the view model
             * member of the page class - same as the DisplayAlert
             * Use an interface
             */
            Debug.WriteLine("here");
            await _pageService.PushAsnyc(new OnePersonView(person));

        }

        private void Delete(PersonViewModel p)
        {
            Persons.Remove(p);
        }

        private void ViewAction(object obj)
        {
            throw new NotImplementedException();
        }

        private async void NavigateToNew(object obj)
        {
            await _pageService.PushAsnyc(new NewPersonView());
        }

        private void SaveList(object obj)
        {
            Local.SavePersons(Persons);
        }

        private void LoadItems()
        {
            Persons = Local.ReadPersons();

        }



        public void SelectOnePersons(PersonViewModel p)
        {
            SelectedPerson = p;
        }
    }
}
