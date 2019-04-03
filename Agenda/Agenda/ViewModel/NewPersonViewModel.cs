using Agenda.Data;
using Agenda.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Agenda.ViewModel
{
    public class NewPersonViewModel:BaseViewModel
    {

        public ObservableCollection<GenderType> Genders { get; set; } = new ObservableCollection<GenderType> { GenderType.Male, GenderType.Female,
        GenderType.Other};//"Male", "Female", "None" };

        private GenderType _selectedGender;
        public GenderType SelectedGender
        {
            get { return _selectedGender; }
            set { SetValue(ref _selectedGender, value); }
        }

        public ObservableCollection<int> Heigth_Meter { get; set; } = new ObservableCollection<int>();
        public ObservableCollection<int> Heigth_Cm { get; set; } = new ObservableCollection<int>();

        private int _selectMeter =1 ;
        public int SelectMeter
        {
            get { return _selectMeter; }
            set { SetValue(ref _selectMeter, value); }
        }


        private int _selectCM = 60;
        public int SelectCM
        {
            get { return _selectCM; }
            set { SetValue(ref _selectCM, value); }
        }

        private PersonViewModel _person = new PersonViewModel();

        public PersonViewModel Person
        {
            get { return _person; }
            set { SetValue(ref _person, value); }
        }

        public ICommand AddPersonCommand { get; private set; }

        private IPageService _pageService;

        public NewPersonViewModel(IPageService ps)
        {
            AddPersonCommand = new Command(AddPerson);
            _pageService = ps;

            PopulateHeigthCol();
            
        }

        private void PopulateHeigthCol()
        {
            for(int i =1;i<100;i++)
            {
                Heigth_Cm.Add(i);
            }
            for (int i = 1; i < 3; i++)
            {
                Heigth_Meter.Add(i);
            }
        }

        private void AddPerson(object obj)
        {
            ObservableCollection<PersonViewModel> temp = Local.ReadPersons();
            float height = (float)Convert.ToDouble(_selectMeter + "." + _selectCM);
            temp.Add(Person);
            Local.SavePersons(temp);

            _pageService.DisplayAlert("Well Done", "New person created!!!", "ok", "cancel");

            _pageService.PushAsnyc(new MainPage());
        }
    }
}
