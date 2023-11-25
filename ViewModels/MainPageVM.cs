using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechnoServiceApp.Models;


namespace TechnoServiceApp.ViewModels
{
    public class MainPageVM : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        private int number1;
        private int number2;
        public int Number1 { get { return number1; } set { number1 = value; OnPropertyChanged("Number3"); } }
        public int Number2 { get { return number2; } set { number1 = value; OnPropertyChanged("Number3"); } }
        public int Number3 { get { return Calculations.GetSumOf(Number1, Number2); } set { } }
    }
}
