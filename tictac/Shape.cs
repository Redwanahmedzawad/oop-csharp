using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tictac
{
    public abstract class Shape
    {
        private float _x, _y;
        private bool todraw;
        public Shape(float x, float y)
        {
            _x = x;
            _y = y;
            todraw = false;
        }
        public abstract void Draw();
        public float X { get { return _x;} set { _x = value; } }
        public float Y { get { return _y; } set { _y = value; } }
        public abstract int Occupy { get; set; }
        public bool Todraw { get {  return todraw; } set {  todraw = value; } }
    }
    
}
