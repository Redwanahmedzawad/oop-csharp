using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SplashKitSDK;
namespace ShapeDrawer
{
    class Myrectangle : Shape
    {
        private int _width, _height;
        public Myrectangle(Color clr, float x, float y, int width, int height) : base(clr)
        {
            X = x;
            Y = y;
            _width = width;
            _height = height;
        }
        public Myrectangle() : this(Color.Green, 0, 0, 100, 100)
        {

        }
        public override void Draw()
        {
            if (Selected)
            {
                DrawOutline();
            }
            SplashKit.FillRectangle(Color, X, Y, _width, _height);
        }
        public override void DrawOutline()
        {
            SplashKit.FillRectangle(Color.Black, X - 2, Y - 2, Width, Height);
        }
        public override bool IsAt(Point2D pt)
        {
            if (pt.X >= X && pt.X <= (X + _width) && pt.Y <= (Y + _height) && pt.Y >= Y)
            {
                return true;
            }
            else
            {
                return false;
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
            get
            {
                return _height;
            }
        }
    }
}
