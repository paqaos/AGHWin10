using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EncyklopediaPiwa.Base;

namespace EncyklopediaPiwa.Interfaces.ViewModel
{
	public interface IMainMenuViewModel
	{
		bool IsPaneOpen { get; set; }

		RelayCommand NavigateToBeerList { get; set; }

		string Title { get; set; }
	}
}
