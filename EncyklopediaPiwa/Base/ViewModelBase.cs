using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EncyklopediaPiwa.Base
{
	public abstract class ViewModelBase : INotifyPropertyChanged
	{
		protected void OnPropertyChanged( [CallerMemberName] string name = null )
		{
			if ( PropertyChanged != null )
			{
				PropertyChanged(this, new PropertyChangedEventArgs(name));
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;
	}
}
