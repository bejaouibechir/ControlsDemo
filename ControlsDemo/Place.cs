using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlsDemo
{
    internal class Place :BindableObject, INotifyPropertyChanged
    {

        public int Classement
        {
            get { return (int)GetValue(ClassementProperty); }
            set { SetValue(ClassementProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Classement.  This enables animation, styling, binding, etc...
        public static readonly BindableProperty ClassementProperty =
            BindableProperty.Create("Classement", typeof(int), typeof(Place), 0,
                propertyChanged:OnClassementChanged, 
                coerceValue:OnCoerceChanged,validateValue:OnValidationChanged);

        private static bool OnValidationChanged(BindableObject bindable, object value)
        {
            int input = (int)value;
            if (input == 10) return false;
            return true;
        }

        private static object OnCoerceChanged(BindableObject bindable, object value)
        {
            int input = (int)value;
            
            if(input<0) input= 0;
            else if(input>100) input= 100;

            return input;
        }

        private static void OnClassementChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if((int)newValue<0)
            {
               
            }
        }






        string _name;
        double _longitude;
        double _latitude;
        int _population;
        string _continent;



        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        public double Longitude
        {
            get { return _longitude; }
            set
            {
                _longitude = value;
                OnPropertyChanged(nameof(Longitude));
            }
        }

        public double Latitude
        {
            get { return _latitude; }
            set
            {
                _latitude = value;
                OnPropertyChanged(nameof(Latitude));
            }
        }

        public int Population
        {
            get { return _population; }
            set
            {
                _population = value;
                OnPropertyChanged(nameof(Population));
            }
        }

        public string Continent
        {
            get { return _continent; }
            set
            {
                _continent = value;
                OnPropertyChanged(nameof(Continent));
            }
        }


       

        public override string ToString()
        {
            return $"Nom: {Name} Longitude:{Longitude}" +
                $" Latitude: {Latitude} Population: {Population} Continent: {Continent}";
        }


        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

    }
}
