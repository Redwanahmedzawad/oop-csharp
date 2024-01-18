using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using SplashKitSDK;
namespace tictac
{
    public class Draw
    {
        private List<Shape> shapes;
        private List<Rectangle> rects;
        public Draw() 
        { 
            shapes = new List<Shape>();
            rects = new List<Rectangle>();
            for(int i = 0;i<3;i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    rects.Add(new Rectangle(i * 250, j * 250));
                }
            }
        }
        public void Board()
        {
            foreach(Rectangle rect in rects)
            {
                SplashKit.DrawRectangle(Color.Black,rect.X,rect.Y,rect.Width,rect.Height);
            }
        }
        public void AddShape(Shape shape)
        {
            foreach(Shape s in shapes)
            {
                if(s.X==shape.X && s.Y == shape.Y)
                {
                    return;
                }
            }
            shapes.Add(shape);
        }

        public void DrawShape()
        {
            if(SingRec.Selected)
            {
                SingRec.Draw();
            }
            foreach(Shape shape in shapes)
            {
                
                shape.Draw();
            }
            
        }

        public void SelectedAt(Point2D pt)
        {
            foreach(Rectangle rect in rects)
            {
                if(rect.isAt(pt))
                {
                    rect.Selected = true;
                }
                else
                {
                    rect.Selected= false;
                }
            }
        }

        public void Selected()
        {
            
                foreach(Rectangle rect in rects)
                {
                    if(rect.Todraw) { AddShape(rect); }
                }
               
        }
        public Rectangle SingRec
        {
            get
            {
                Rectangle result = new Rectangle();
                foreach(Rectangle rect in rects)
                {
                    if(rect.Selected)
                    {
                        return rect;
                    }
                }
                return result;
            }
        }
        public List<Rectangle> Rectangles
        {
            get
            {
                return rects;
            }
            set
            {
                rects = value;
            }
        }
      
   
        

    }
}
