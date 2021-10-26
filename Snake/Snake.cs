using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Snake
{
    class Snake
    {
        public List<PointF> Tail {get; set;}
        public PointF Head {get; set;}
        public double Speed { get; set; }
        public double Direction { get; set; }

        public Snake()
        {
            Head = new PointF();
            Tail = new List<PointF>();
        }

        public void Forward()
        {
            Tail.Add(Head);
            var dx = Speed * Math.Cos(Direction);
            var dy = Speed * -Math.Sin(Direction);
            Head = new PointF(Convert.ToSingle(Tail[Tail.Count - 1].X + dx),Convert.ToSingle(Tail[Tail.Count - 1].Y + dy));
        }
        public void Left()
        {
            Direction += 0.3;
        }
        public void Right()
        {
            Direction += 0.3;
        }

        public List<PictureBox> GetPictureBoxes(Color color, int size)
        {
            List<PictureBox> pictureBoxes = new List<PictureBox>();
            var halfSize = size / 2F; /// To F za 2 slouží k převodu na číslo float  je to jako float halfSize = size / 2F
            foreach (var point in Tail)
            {
                //var pbox = new PictureBox();
                //pbox.Location = new Point();   tohle je to stejné jako ↓↓
                pictureBoxes.Add(new PictureBox() { Location = new Point(), BackColor = color});
            }
            return pictureBoxes;
        }
    }
}

/// Úkol ----- Oba hadi pojedou, třída nahradí prototajp, Tlačítko pause, pustit, restart - hadi se vrátí na začátek
/// Bonus ----- sražení hadů, reakce, 

