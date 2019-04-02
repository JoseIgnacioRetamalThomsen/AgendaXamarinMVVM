using Agenda.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Agenda.ViewModel
{
    public class PersonViewModel : BaseViewModel
    {

        #region Public fields

        private string _name;
        public string Name
        {
            get { return _name; }
            set { SetValue(ref _name, value); }
        }

        private DateTime _dOB;
        public DateTime DOB
        {
            get { return _dOB; }
            set { SetValue(ref _dOB, value); }
        }

        private GenderType _gender;
        public GenderType Gender
        {
            get { return _gender; }
            set { SetValue(ref _gender, value); }
        }

        private int _phone;
        public int Phone
        {
            get { return _phone; }
            set { SetValue(ref _phone, value); }
        }


        private float _height;
        public float Height
        {
            get { return _height; }
            set { SetValue(ref _height, value); }

        }

        private bool _isFryend;
        public bool IsFryend
        {
            get { return _isFryend; }
            set { SetValue(ref _isFryend, value); }

        }

        private string _photo;
        public string Photo
        {
            get { return _photo; }
            set { SetValue(ref _photo, value); }

        }
        #endregion


    }
}
