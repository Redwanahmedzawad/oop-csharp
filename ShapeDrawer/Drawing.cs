using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SplashKitSDK;
using System.IO;
namespace ShapeDrawer
{
    public class Drawing
    {
        private List<Shape> _shapes;
        private Color _background;
        public Drawing(Color background)
        {
            _shapes = new List<Shape>();
            _background = background;
        }
        public Drawing(): this(Color.White)
        {
           
        }
        public void Draw()
        {
            SplashKit.ClearScreen(_background);
            foreach(Shape s in _shapes)
            {
                s.Draw();
            }
        }
        public void SelectShapesAt(Point2D pt)
        {
            foreach (Shape s in _shapes)
            {
                s.Selected = s.IsAt(pt);

            }
            
        }
        public List<Shape> SelectedShapes
        {
            get
            {
                List<Shape> result = new List<Shape>();
                foreach (Shape s in _shapes)
                {
                    if (s.Selected == true)
                    {
                        result.Add(s);
                    }
                }
                return result;

            }
        }
        public int ShapeCount
        {
            get { return _shapes.Count; }
        }
        public void AddShape(Shape s)
        {
            _shapes.Add(s) ;
        }
        public void RemoveShape(Shape s)
        {
             _shapes.Remove(s);

        }
        public Color Background
        {
            get
            {
                return _background;
            }
            set
            {
                _background = value;
            }
        }
        public void Save(string filename)
        {
            StreamWriter writer;
            
            writer = new StreamWriter(filename);

            writer.WriteColor(Background);
            writer.WriteLine(ShapeCount);

            foreach (Shape s in _shapes)
            {
                s.SaveTo(writer);
            }
            try
            {

            }
            finally
            {
                writer.Close();
            }
        }
        public void Load(string filename)
        {
            StreamReader reader;
            int count;
            Shape s = new MyCircle();
            string kind;
            reader = new StreamReader(filename);

            Background = reader.ReadColor();
            count = reader.ReadInteger();
            _shapes.Clear();
            for(int i =0; i < count; i++)
            {
                kind = reader.ReadLine();
                switch (kind) {
                    case "Rectangle":
                        s = new Myrectangle();
                        break;
                    case "Circle":
                        s = new MyCircle();
                        break;
                    case "Line":
                        s = new MyLine();
                        break;
                    default:
                        throw new InvalidDataException("Unknon shape kind: " + kind);

               
                   
                }
                s.LoadFrom(reader);
                AddShape(s);
            }
            try
            {

            }
            finally
            {
                reader.Close();
            }

        }
    }
}
