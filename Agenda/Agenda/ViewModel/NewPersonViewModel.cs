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

        private PersonViewModel _person = new PersonViewModel();

        public PersonViewModel Person
        {
            get { return _person; }
            set { SetValue(ref _person, value); }
        }

        public ICommand AddPersonCommand { get; private set; }

        public NewPersonViewModel()
        {
            AddPersonCommand = new Command(AddPerson);
            
        }

        private void AddPerson(object obj)
        {
            ObservableCollection<Person> temp = Local.ReadPersons();

            temp.Add(new Person(Person.Name,Person.DOB,Person.Gender,Person.Phone,Person.Height,Person.IsFryend, "female.png"));
            Local.SavePersons(temp);
        }
    }
}
