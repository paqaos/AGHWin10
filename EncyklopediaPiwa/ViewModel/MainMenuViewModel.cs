using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EncyklopediaPiwa.Base;
using EncyklopediaPiwa.Interfaces.ViewModel;

namespace EncyklopediaPiwa.ViewModel
{
	public class MainMenuViewModel : ViewModelBase, IMainMenuViewModel
	{
		private bool _isPaneOpen;

		public bool IsPaneOpen
		{
			get
			{
				return _isPaneOpen;
			} 
			set
			{
				if ( _isPaneOpen != value )
				{
					_isPaneOpen = value;
					OnPropertyChanged();
				}
			}
		}


		public RelayCommand NavigateToBeerList
		{
			get; set;
		}

		public string Title
		{
			get; set;
		}
	}
}
