﻿using Agenda.Data;
using Agenda.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Agenda.ViewModel
{
    public class MainPageViewModel :BaseViewModel
    {
        #region Fields
        private ObservableCollection<Person> _persons;

        public ObservableCollection<Person> Persons
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

        private Person _selectedPerson;

        public Person SelectedPerson
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
        #endregion
        public MainPageViewModel()
        {
            LoadItems();
            SaveListCommand = new Command(SaveList);
        }

        private void SaveList(object obj)
        {
            Local.SavePersons(Persons);
        }

        private void LoadItems()
        {
            Persons = Local.ReadPersons();
            
        }

       

        public void SelectOnePersons(Person p)
        {
            SelectedPerson = p;
        }
    }
}