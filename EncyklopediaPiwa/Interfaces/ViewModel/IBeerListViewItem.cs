﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncyklopediaPiwa.Interfaces.ViewModel
{
    public interface IBeerListViewItem
    {
        string Name
        {
            get;
        }

        long BeerId
        {
            get;
        }
    }
}
