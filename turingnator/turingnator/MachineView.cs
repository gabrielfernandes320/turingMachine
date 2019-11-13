using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace turingnator
{

    public partial class MachineView : Form
    {

        public int currentState { get; set; }
        public int position { get; set;} 


        public MachineView()
        {

            InitializeComponent();
            
        }



    }

}
