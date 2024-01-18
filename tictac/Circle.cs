using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SplashKitSDK;

namespace tictac
{
    public class Circle:ShapeX
    {
        public Circle(float x, float y):base(x,y) { }
        public Circle() :this(0,0) { }

        public override void Draw()
        {
            SplashKit.FillRectangle(Color.Green, X, Y, 250, 250);
            SplashKit.FillCircle(Color.Blue, X+125, Y+125, 125);
        }
        public override int Occupy
        {
            get
            {
                return 1;
            }
            set { }
        }

    }
}
