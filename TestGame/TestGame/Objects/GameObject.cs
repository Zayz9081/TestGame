﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestGame.Structures;

namespace TestGame.Objects
{
    abstract class GameObject
    {
        public double height;
        public double width;
        public Coords crd;
        public string name;

        public GameObject(double _height, double _width, Coords _crd, string _name)
        {
            height = _height;
            width = _width;            
            crd = _crd;
            name = _name;
        }


    }
}
