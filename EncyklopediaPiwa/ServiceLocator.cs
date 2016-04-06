using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EncyklopediaPiwa.Interfaces.Repository;
using EncyklopediaPiwa.Interfaces.ViewModel;
using EncyklopediaPiwa.Model;
using EncyklopediaPiwa.Repository;
using EncyklopediaPiwa.ViewModel;
using EncyklopediaPiwa.ViewModel.BeerList;

namespace EncyklopediaPiwa
{
    public class ServiceLocator
    {
        public ServiceLocator()
        {
            MainMenuViewModel = new MainMenuViewModel();
            BeerRepository = new BeerRepository();
            BeerListViewModel = new BeerListViewModel();
        }

        public static IMainMenuViewModel MainMenuViewModel { get; set; }

        public static IRepository<Beer> BeerRepository { get; set; } 
        
        public static IBeerListViewModel BeerListViewModel
        {
            get;
            set;
        }
    }
}
