using EncyklopediaPiwa.Base;
using EncyklopediaPiwa.Interfaces.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncyklopediaPiwa.ViewModel.BeerList
{
    public class BeerListViewItem : ViewModelBase, IBeerListViewItem
    {
        public long BeerId
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }
    }
}
