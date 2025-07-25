using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfMVVMProject.ViewModels;
using Haley.MVVM;
using Haley.Models;
using Haley.Abstractions;

namespace WpfMVVMProject.Models
{
    public class Person : ChangeNotifier
    {
        private string? _FirstName;

        public string FirstName
        {
            get { return _FirstName!; }
            set { _FirstName = value; OnPropertyChanged(nameof(FirstName)); }
        }

        private string? _LastName;

        public string LastName
        {
            get { return _LastName!; }
            set { _LastName = value; OnPropertyChanged(nameof(LastName)); }
        }

        private int _Age;

        public int Age
        {
            get { return _Age; }
            set { _Age = value; OnPropertyChanged(nameof(Age)); }
        }

        public Person() { }
    }
}
