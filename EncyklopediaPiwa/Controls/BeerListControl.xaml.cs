using EncyklopediaPiwa.Interfaces.ViewModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace EncyklopediaPiwa.Controls
{
    public sealed partial class BeerListControl : UserControl
    {
        private IBeerListViewModel _beerListViewModel; 

        public BeerListControl()
        {
            this.InitializeComponent();
            Loaded += BeerListControl_Loaded;
        }

        private void BeerListControl_Loaded( object sender, RoutedEventArgs e )
        {
            if ( _beerListViewModel != null )
            {
                _beerListViewModel.OnPageLoaded();
            }
        }

        private void UserControl_DataContextChanged( FrameworkElement sender, DataContextChangedEventArgs args )
        {
            _beerListViewModel = DataContext as IBeerListViewModel;
        }
    }
}
