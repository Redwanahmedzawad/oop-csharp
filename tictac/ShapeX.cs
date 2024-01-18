using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SplashKitSDK;

namespace tictac
{
    public class ShapeX:Shape
    {
        public ShapeX(float x, float y):base(x, y) 
        {

        }
        public ShapeX() :this(0,0) { }
        public override void Draw()
        {
            SplashKit.FillRectangle(Color.Yellow, X, Y, 250, 250);
            SplashKit.DrawLine(Color.Black, X, Y, X + 250, Y + 250);
            SplashKit.DrawLine(Color.Black, X + 250, Y, X, Y + 250);
        }
        public override int Occupy
        {
            get
            {
                return -1;
            }
            set { }
        }
        
    }
}
