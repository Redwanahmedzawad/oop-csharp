using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SplashKitSDK;
namespace ShapeDrawer
{
    public class MyLine : Shape
    {
        private float _x, _y;
        public MyLine(Color clr) : base(clr)
        {
            _x = 0;
            _y = 0;

        }
        public MyLine() : this(Color.Red)
        {

        }
        public override void Draw()
        {
            if (Selected)
            {
                DrawOutline();
            }
            SplashKit.DrawLine(Color, X, Y, EndX, EndY);
        }
        public override void DrawOutline()
        {
            SplashKit.DrawCircle(Color.Black, X, Y, 20);
            SplashKit.DrawCircle(Color.Black, EndX, EndY, 20);
        }
        public override bool IsAt(Point2D pt)
        {
            return SplashKit.PointOnLine(pt, SplashKit.LineFrom(X, Y, EndX, EndY));
        }

        public float EndX
        {

            get
            {
                _x = X + 100;
                return _x;
            }
            set
            {
                _x = value;
            }


        }
        public float EndY
        {
            get
            {
                _y = Y;
                return _y;
            }
            set
            {
                _y = value;
            }
        }
    }
}
