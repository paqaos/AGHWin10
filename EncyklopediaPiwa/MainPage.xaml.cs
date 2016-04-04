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
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Navigation;
using EncyklopediaPiwa.Base;
using EncyklopediaPiwa.Interfaces.ViewModel;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace EncyklopediaPiwa
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private IMainMenuViewModel _mainMenuVm;

        public MainPage()
        {
            this.InitializeComponent();
        }

        private void MainPage_OnDataContextChanged(FrameworkElement sender, DataContextChangedEventArgs args)
        {
            _mainMenuVm = DataContext as IMainMenuViewModel;

            if ( _mainMenuVm != null )
            {
                _mainMenuVm.NavigateToBeerList = new RelayCommand( NavigateToBeerList );
            }
        }

        private void NavigateToBeerList(object obj)
        {
            ContentFrame.Navigate(typeof (BeerList),1, new SuppressNavigationTransitionInfo());
        }

        private void HamburgerButton_OnClick(object sender, RoutedEventArgs e)
        {
            if ( _mainMenuVm != null )
            {
                _mainMenuVm.IsPaneOpen = !_mainMenuVm.IsPaneOpen;
            }
        }
    }
}
