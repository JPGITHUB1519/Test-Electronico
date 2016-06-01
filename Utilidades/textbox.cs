using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Utilidades
{
    public partial class textbox : TextBox
    {
        public Boolean validar
        {
            set;
            get;

        }

        public textbox()
        {
            InitializeComponent();
        }

        public textbox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
