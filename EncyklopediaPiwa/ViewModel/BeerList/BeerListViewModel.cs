﻿using EncyklopediaPiwa.Base;
using EncyklopediaPiwa.Interfaces.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace EncyklopediaPiwa.ViewModel.BeerList
{
    public class BeerListViewModel : ViewModelBase, IBeerListViewModel
    {
        public BeerListViewModel()
        {
            Beers = new ObservableCollection<IBeerListViewItem>();
        }

        private ObservableCollection<IBeerListViewItem> _beers;

        public ObservableCollection<IBeerListViewItem> Beers
        {
            get
            {
                return _beers;
            }
            set
            {
                if ( _beers != value )
                {
                    _beers = value;
                    OnPropertyChanged();
                }
            }
        }

        public void OnPageLoaded()
        {
            Beers.Clear();

            var beerRepository = ServiceLocator.BeerRepository;

            var beers = beerRepository.GetAll();

            foreach ( var beer in beers )
            {
                var beerItem = new BeerListViewItem();
                beerItem.BeerId = beer.Id;
                beerItem.Name = beer.Name;
                Beers.Add( beerItem );
            }
        }
    }
}
