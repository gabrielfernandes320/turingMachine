using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace turingnator
{
    class State
    {

        private int id { get; set; }

        MachineView Machine = new MachineView();

        IDictionary<char, string> actions = new Dictionary<char, string>();


        public State(int id, IDictionary<char, string> actions, MachineView Machine)
        {

            this.Machine = Machine;
            this.id = id;
            this.actions = actions;           

        }

        public string read(string strip)
        {

            strip = write(strip);

            

            return strip;

        }

        private void move()
        {



        }

        private string write(string strip)
        {

            char towrite = actions[strip[Machine.position]][1];

            StringBuilder head = new StringBuilder(strip);
            head.Remove(Machine.position, 1);
            head.Insert(Machine.position, towrite);
            return strip;

        }

    }
}
