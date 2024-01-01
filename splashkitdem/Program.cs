using System;
using SplashKitSDK;

namespace splashkitdem
{ 
    public class Program

        {
            public static void LoadResources()
        {
            SplashKit.LoadBitmap("Cherry", "Cherry.png");
            SplashKit.LoadBitmap("Gooseberry", "Gooseberry.png");
            SplashKit.LoadBitmap("Blueberry", "Blueberry.png");
            SplashKit.LoadBitmap("Pomegranate", "Pomegranate.png");
            SplashKit.LoadBitmap("Apricot", "Apricot.png");
            SplashKit.LoadBitmap("Raspberry", "Raspberry.png");
            SplashKit.LoadBitmap("Blackberry", "Blackberry.png");
            SplashKit.LoadBitmap("Strawberry", "Strawberry.png");
            SplashKit.LoadBitmap("Currant", "Currant.png");
        }
            public static void Main()
        {
            LoadResources();
            FruitKarate _game = new FruitKarate();
            Window window = new Window("Fruit Karate", 800, 600);

            while (!window.CloseRequested)
            {
                
                SplashKit.ProcessEvents();

               if (SplashKit.KeyTyped(KeyCode.SpaceKey)){
                    _game.LaunchFruit();
                }

               if (SplashKit.MouseClicked(MouseButton.LeftButton))
                {
                    _game.Slash(SplashKit.MousePosition());
                }

                _game.Update();

                _game.Draw();
                SplashKit.RefreshScreen();


            }


        }
    }
}
