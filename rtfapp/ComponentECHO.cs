using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rtfapp
{
    public partial class ComponentECHO : Component
    {
        public ComponentECHO()
        {
            InitializeComponent();
        }

        public ComponentECHO(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
