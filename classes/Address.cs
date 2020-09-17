using System;
using System.Collections.Generic;
using System.Text;

namespace LB_2.classes
{
    class Address
    {
        int _index;
        string _country;
        string _city;
        string _street;
        int _house;
        int _apartment;
        public int Index 
        {
            get { return _index; }
            set { _index = value; }
        }
        public string Country
        {
            get { return _country; }
            set { _country = value; }
        }
        public string City
        {
            get { return _city; }
            set { _city = value; }
        }
        public string Street
        {
            get { return _street; }
            set { _street = value; }
        }
        public int House
        {
            get { return _house; }
            set { _house = value; }
        }
        public int Apartment
        {
            get { return _apartment; }
            set { _apartment = value; }
        }
    }
}
