using System;
using System.Windows;
using SplashKitSDK;

namespace ShapeDrawer 
{ 
    public class Program
    {
        public static void Main()
        {
            new Window("Shape Drawer", 800, 600);
            Drawing draw = new Drawing();
            
            do
            {
                SplashKit.ClearScreen();
                SplashKit.ProcessEvents();
                if (SplashKit.MouseClicked(MouseButton.LeftButton))
                {
                    draw.AddShape(new Shape(SplashKit.MouseX(), SplashKit.MouseY()));
                }
                if (SplashKit.MouseClicked(MouseButton.RightButton))
                {
                    draw.SelectShapesAt(SplashKit.MousePosition());
                }
                if (SplashKit.KeyDown(KeyCode.SpaceKey))
                {
                    draw.Background = Color.RandomRGB(255);

                }
                if (SplashKit.KeyDown(KeyCode.DeleteKey)|| SplashKit.KeyDown(KeyCode.BackspaceKey))
                {
                    draw.RemoveShape();
                }
                draw.Draw();
                
                SplashKit.RefreshScreen();
            } while (!SplashKit.WindowCloseRequested("Shape Drawer")); 
        }
    }
}
