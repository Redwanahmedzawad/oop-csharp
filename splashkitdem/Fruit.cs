using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SplashKitSDK;

namespace splashkitdem
{
    public class Fruit
    {
        private FruitKind _kind;
        private Point2D _position;
        private Vector2D _velocity;

        public Fruit()
        {
            _position.X = 0;
            _position.Y = SplashKit.ScreenHeight();

            _velocity.X = 3.0;
            _velocity.Y = -7.0 + SplashKit.Rnd(2) - 1;

            _kind = (FruitKind)SplashKit.Rnd(9);
        }

        public void Update()
        {
            _position.X += _velocity.X;
            _position.Y += _velocity.Y;

            _velocity = SplashKit.VectorAdd(_velocity, SplashKit.VectorTo(0, 0.05));
        }

        public void Draw()
        {
            SplashKit.DrawBitmap(Mybitmap(), _position.X, _position.Y);
        }
        public bool IsAt(Point2D pt)
        {
            return SplashKit.BitmapPointCollision(Mybitmap(), _position, pt);

        }
        private Bitmap Mybitmap()
        {
            switch (_kind)
            {
                case FruitKind.Cherry:
                    return SplashKit.BitmapNamed("Cherry");
                case FruitKind.Gooseberry:
                    return SplashKit.BitmapNamed("Gooseberry");
                case FruitKind.Blueberry:
                    return SplashKit.BitmapNamed("Blueberry");
                case FruitKind.Pomegranate:
                    return SplashKit.BitmapNamed("Pomegranate");
                case FruitKind.Apricot:
                    return SplashKit.BitmapNamed("Apricot");
                case FruitKind.Raspberry:
                    return SplashKit.BitmapNamed("Raspberry");
                case FruitKind.Blackberry:
                    return SplashKit.BitmapNamed("Blackberry");
                case FruitKind.Strawberry:
                    return SplashKit.BitmapNamed("Strawberry");
                default:
                    return SplashKit.BitmapNamed("Currant");
            }
        }

    }
}
