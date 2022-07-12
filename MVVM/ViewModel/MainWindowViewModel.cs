using cardsv2.Core;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cardsv2.MVVM.ViewModel
{
    internal class MainWindowViewModel : ObservableObject
    {
        private ObservableCollection<CardPlateViewModel> _cardsList;

        public ObservableCollection<CardPlateViewModel> CardsList
        {
            get { return _cardsList; }
            set { _cardsList = value; NotifyPropertyChanged(); }
        }



        public MainWindowViewModel()
        {
            CardsList = new ObservableCollection<CardPlateViewModel>(); // init all cards list

            // for test
            CardsList.Add(new CardPlateViewModel());
            CardsList.Add(new CardPlateViewModel());
            CardsList.Add(new CardPlateViewModel());
        }
    }
}
