using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SplashKitSDK;
using static System.Formats.Asn1.AsnWriter;
namespace tictac
{
    public class Monitor
    {
        
        Draw board;
        List<Rectangle> list;
        public Monitor(Draw draw) 
        {
            
            board = draw;
            list = new List<Rectangle>(draw.Rectangles);

        }
        public int Winner()
        {
            
            
            for(int i = 0; i < 9; i+=3)
            {
                if (board.Rectangles[i].Occupy == board.Rectangles[i+1].Occupy && board.Rectangles[i + 1].Occupy==board.Rectangles[i+2].Occupy&& board.Rectangles[i + 2].Occupy!=0)
                {
                    return board.Rectangles[i].Occupy;
                }
            }
            for(int i=0;i<3;i++)
            {
                if(board.Rectangles[i].Occupy == board.Rectangles[i + 3].Occupy && board.Rectangles[i + 3].Occupy == board.Rectangles[i + 6].Occupy&& board.Rectangles[i + 3].Occupy!=0)
                {
                    return board.Rectangles[i].Occupy;
                }
            }
            if (board.Rectangles[0].Occupy == board.Rectangles[4].Occupy && board.Rectangles[4].Occupy== board.Rectangles[8].Occupy && board.Rectangles[8].Occupy!=0)
            {
                return board.Rectangles[0].Occupy;
            }
            if(board.Rectangles[2].Occupy == board.Rectangles[4].Occupy && board.Rectangles[4].Occupy == board.Rectangles[6].Occupy&& board.Rectangles[6].Occupy!=0)
            {
               return board.Rectangles[4].Occupy;
            }
            if(AvaiLength==0)
            {
                return 0;
            }
            return 9;



        }

        public void AddShape()
        {
            int bestscore = -24444;
            int move,score=0;
            Rectangle rady = new Rectangle();
            foreach (var rect in AvailRect)
            {
                if(rect.Available == true)
                {
                    rect.Occupy = 1;
                    rect.Todraw = true;
                    score = MiniMax(AvailRect,0, false);
                    rect.Occupy = 0;
                    rect.Todraw = false;
                    if (score>bestscore)
                    {
                        bestscore = score;
                        rady = rect;
                    }
                    
                    
                }
            }
            rady.Todraw = true;
            rady.Occupy = 1;
            board.AddShape(new ShapeX(rady.X, rady.Y));


        }
        public int MiniMax(List<Rectangle>Arect, int depth, bool occupy)
        {
            int score=0;
            if(Winner()!=9)
            {
                return Winner();
            }
            
            if(occupy)
            {
                int bestscore = -24444;
                
                foreach(Rectangle rect in AvailRect)
                {
                    if(rect.Available)
                    {
                        rect.Occupy = 1;
                        rect.Todraw=true;
                        score = MiniMax(AvailRect,depth+1, false);
                        rect.Occupy = 0;
                        rect.Todraw = false;
                        if (bestscore<score)
                        {
                            bestscore = score;
                           
                        }
                    }
                }
                return bestscore;
            }
            else
            {
                int bestscore = 24444;
               
                foreach (Rectangle rect in AvailRect)
                {
                    if (rect.Available)
                    {
                        rect.Occupy = -1;
                        rect.Todraw = true;

                        score = MiniMax(AvailRect,depth + 1, true);
                        rect.Occupy = 0;
                        rect.Todraw = false;
                        if (bestscore > score)
                        {
                            bestscore = score;
                           
                        }
                    }
                }
                return bestscore;
            }


        }
        public List<Rectangle>AvailRect
        {
            get
            {
               
                return list;
              
            }
        }
       
        public int AvaiLength
        {
            get
            {
                int count = 0;
                foreach (var rect in board.Rectangles)
                {
                    if (rect.Available == true)
                    {
                        count++;
                    }
                }
                return count;
            }
        }
        public String Win
        {
            get
            {
                if (Winner() == 1)
                {
                    return "Computer Wins";
                }
                else
                {
                    return "Player Wins";
                }
            }
        }

    }
}
