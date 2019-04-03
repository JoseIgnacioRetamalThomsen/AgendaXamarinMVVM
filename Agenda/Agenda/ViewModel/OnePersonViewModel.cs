using System;
using System.Collections.Generic;
using System.Text;

namespace Agenda.ViewModel
{
   public  class OnePersonViewModel
    {
        public PersonViewModel Person { get; set; } 

        public OnePersonViewModel(PersonViewModel person)
        {
            Person = person;
        }
    }
}
