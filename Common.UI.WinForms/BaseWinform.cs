﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Common.UI.WinForms
{
    public abstract class BaseWinform : Form
    {
        public BaseWinform()
        {
            this.TopLevel = false;
        }
    }
}
