using SplashKitSDK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tictac
{
    public class Rectangle:Shape

    {
        private int _width, _height,occupy;
        private bool _selected;
        
        public Rectangle(float x, float y ):base(x,  y)
        {
            _width = 250;
            _height = 250;
            _selected = false;
            occupy = 0; 
            
        }
       
        public Rectangle() : this(0, 0) { }
        public bool isAt(Point2D pt)
        {
            return (pt.X>X&&pt.Y>Y&&pt.X<(X+Width)&&pt.Y<(Y+Height));
        }
        public override void Draw()
        {

            if (Selected)
            {
                SplashKit.FillRectangle(Color.Pink, X, Y, _width, _height);
            }
        }

        public int Width
        {
            get
            {
                return _width;
            }
           
        }
        public int Height
        {
            get { return _height;}
        }
        public bool Selected
        {
            get
            {
                return _selected;
            }
            set
            {
                _selected = value;
            }
        }
        public bool Available 
        { 
            get
            {
                return !Todraw;
            }
        }
        public override int Occupy
        {
            get
            {
                return occupy;
            }
            set
            {
                occupy = value;
            }
        }

    }
}
