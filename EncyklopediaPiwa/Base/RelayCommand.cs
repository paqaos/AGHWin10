using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace EncyklopediaPiwa.Base
{
	public class RelayCommand : ICommand
	{
		private Action<object> _action;

		public RelayCommand( Action<object> action )
		{
			_action = action;
		}

		public void Execute( object Object )
		{
			if ( _action != null )
			{
				_action(Object);
			}
		}

		public bool CanExecute( object Object )
		{
			return true;
		}

		public event EventHandler CanExecuteChanged;
	}
}
