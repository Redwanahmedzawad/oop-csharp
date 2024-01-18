using System;
using System.Runtime.InteropServices;
using SplashKitSDK;

namespace tictac {
    public class Program
    {
        public static void Main()
        {
            new Window("tictac", 750, 750);
            Draw draw = new Draw();
            Shape newshape;
            bool playerturn = false;
            Monitor plai = new Monitor(draw);
            do
            {
                SplashKit.ClearScreen();
                SplashKit.ProcessEvents();
                /*  
                  SplashKit.DrawLine(Color.Black, 250, 0, 250, 600);
                  SplashKit.DrawLine(Color.Black, 500, 0, 500, 600);
                  SplashKit.DrawLine(Color.Black, 0, 200, 750, 200);
                  SplashKit.DrawLine(Color.Black, 0, 400, 750, 400);
               
                draw.DrawBoard();
                if (SplashKit.MouseClicked(MouseButton.LeftButton))
                {
                    draw.Selected(SplashKit.MousePosition());
                    if (SplashKit.KeyDown(KeyCode.XKey))
                    {
                        newshape = new ShapeX();
                        newshape.X = SplashKit.MouseX();
                        newshape.Y = SplashKit.MouseY();
                        newshape.Todraw = true;
                        draw.Add(newshape);

                    }
                }
               
                ////draw.DrawRect();
                draw.DrawShapes();
                */
                draw.Board();
                
                if(plai.Winner() == 9)
                {
                    if (SplashKit.MouseClicked(MouseButton.LeftButton) && playerturn)
                    {
                        draw.SelectedAt(SplashKit.MousePosition());
                        /*
                        /////////draw.AddShape(draw.SingRec);
                        if (SplashKit.KeyDown(KeyCode.XKey))
                        {

                            newshape = new ShapeX();
                            newshape.X = draw.SingRec.X;
                            newshape.Y = draw.SingRec.Y;
                            draw.SingRec.Todraw = true;
                            draw.SingRec.Occupy = 1;
                            playerturn = false;
                            draw.AddShape(newshape);
                        }
                        else if (
                         SplashKit.KeyDown(KeyCode.OKey))
                        {
                        */
                            newshape = new Circle();
                            newshape.X = draw.SingRec.X;
                            newshape.Y = draw.SingRec.Y;
                            draw.SingRec.Todraw = true;
                            playerturn = false;
                            draw.SingRec.Occupy = -1;
                            draw.AddShape(newshape);
                        


                    }
                    else if (!playerturn)
                    {
                        plai.AddShape();
                        playerturn = true;
                    }
                }
                draw.DrawShape();
                if (plai.Winner() ==1 || plai.Winner()==-1)
                {
                    SplashKit.DrawText(plai.Win, Color.Black, "ariel.ttf", 50, 340, 100);
                }
                else if (plai.Winner() == 0)
                {
                    SplashKit.DrawText("Draw", Color.Black, "ariel.ttf", 50, 340, 100);
                }

                SplashKit.RefreshScreen();
                
            } while (!SplashKit.WindowCloseRequested("tictac"));
            foreach (Rectangle rect in draw.Rectangles)
            {
                Console.WriteLine(rect.Occupy);
            }

        }
    }
}