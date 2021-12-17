using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1030FinalProject.Core;

namespace _1030FinalProject.MVVM.ViewModel
{
    //Code associated with the main window. 
    class MainViewModel : ObservableObject
    {
        //Command to go to the HomeView
        public RelayCommand HomeViewCommand { get; set; }

        //Holding an instance of the Home view model
        public HomeViewModel HomeVM { get; set; }

        //Current view displayed
        private object _currentView;
        public object CurrentView
        {
            get { return _currentView; }
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }


        public MainViewModel()
        {
            HomeVM = new HomeViewModel();
            CurrentView = HomeVM;

            //Set command for button to use to change the current view
            HomeViewCommand = new RelayCommand(o =>
            {
                CurrentView = HomeVM;
            });
        }
    }
}
