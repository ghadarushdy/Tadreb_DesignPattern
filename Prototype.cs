using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tadreb_DesignPattern
{
    class Prototype
    {
       
    }

    abstract class ColorPrototype
    {
        public abstract ColorPrototype Clone();
    }
    
    class Color : ColorPrototype
    {
        private int _red;
        private int _green;
        private int _blue;

        // Constructor
        public Color(int red, int green, int blue)
        {
           _red = red;
            _green = green;
            _blue = blue;
        }

        // Create a shallow copy
        public override ColorPrototype Clone()
        {
            Console.WriteLine("Cloning color RGB: {0,3},{1,3},{2,3}",
              _red, _green, _blue);

            return this.MemberwiseClone() as ColorPrototype;
        }
    }


    class ColorManager
    {
        private Dictionary<string, ColorPrototype> _colors =
          new Dictionary<string, ColorPrototype>();
        
        public ColorPrototype this[string key]
        {
            get { return _colors[key]; }
            set { _colors.Add(key, value); }
        }
    }

}
