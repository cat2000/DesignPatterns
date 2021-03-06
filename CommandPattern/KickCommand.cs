﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class KickCommand:Command
    {
        public KickCommand(Receiver machine) : base(machine)
        {
        }

        public override void Execute()
        {
            Machine.Kick();
        }
    }
}
