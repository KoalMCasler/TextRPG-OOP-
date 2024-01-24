﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG_OOP_
{
    internal abstract class Character
    {
        public HealthSystem healthSystem;
        public Position position;
        public Character()
        {
            healthSystem = new HealthSystem();
            position.x = 0;
            position.y = 0;
        }
        public struct Position
        {
            public int x;
            public int y;
        }
    }
}
