using System;
using System.Collections.Generic;
using System.Text;

namespace Agenda.Model
{
    public enum GenderType
    {
        Male=0,Female=1,Other=2
    }
    public class Person
    {
        public string Name { get; set; }
        public DateTime DOB { get; set; }
        public GenderType Gender { get; set; }
        public int Phone { get; set; }
        public float Height { get; set; }
        public bool IsFryend { get; set; }
        public string Photo { get; set; }

        public Person(string name, DateTime dOB, GenderType gender, int phone, float height, bool isFryend, string photo)
        {
            Name = name;
            DOB = dOB;
            Gender = gender;
            Phone = phone;
            Height = height;
            IsFryend = isFryend;
            Photo = photo;
        }
    }
}
