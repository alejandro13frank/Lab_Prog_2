﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PlanetaEventArgs : EventArgs
    {
        short avance;
        short radioRespectoSol;

        public short Avance
        {
            get
            {
                return this.avance;
            }
        }

        public short RadioRespectoSol
        {
            get
            {
                return this.radioRespectoSol;
            }
        }

        public PlanetaEventArgs(short avance, short radio)
        {
            this.avance = avance;
            this.radioRespectoSol = radio;
        }
    }
}
