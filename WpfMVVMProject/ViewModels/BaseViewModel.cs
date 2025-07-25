using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfMVVMProject.Commands;
using WpfMVVMProject.Models;
using Haley.MVVM;
using Haley.Models;
using Haley.Abstractions;

namespace WpfMVVMProject.ViewModels
{
    public class BaseViewModel : ChangeNotifier
    {
        private Person? person;

        public Person TargetPerson
        {
            get { return person!; }
            set { person = value; OnPropertyChanged(nameof(TargetPerson)); }
        }
        private ObservableCollection<Person>? _person;

        public ObservableCollection<Person> Persons
        {
            get { return _person!; }
            set { _person = value; }
        }

        public void AddPerson()
        {
            Persons.Add(TargetPerson); // Add item to the collection
            TargetPerson = new Person(); // Resetting the class
        }
        public void DeletePerson(Person per)
        {
            if (per == null) return;
            if (!Persons.Contains(per)) return;
            
            Persons.Remove(per);
        }
        public ICommand AddItem => new DelegateCommand(AddPerson); //{ get; set; }
        public ICommand DeleteItem => new DelegateCommand<Person>(DeletePerson);
        public BaseViewModel() 
        {
            //AddItem = new AddCommand(this);
            Persons = new ObservableCollection<Person>();
            TargetPerson = new Person();
        }

    }
}
