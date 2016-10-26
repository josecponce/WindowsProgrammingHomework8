using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsProgramingHomework8.Entities
{
    public class Text
    {
        private string textToDraw;
        private PointF location;
        private Font font;
        private double rotation;

        public Text(string text, PointF location, Font font, double rotation)
        {
            this.textToDraw = text;
            this.location = location;
            this.font = font;
            this.rotation = rotation;
        }

        public string TextToDraw
        {
            get
            {
                return textToDraw;
            }

            set
            {
                textToDraw = value;
            }
        }

        public PointF Location
        {
            get
            {
                return location;
            }

            set
            {
                location = value;
            }
        }

        public Font Font
        {
            get
            {
                return font;
            }

            set
            {
                font = value;
            }
        }

        public double Rotation
        {
            get
            {
                return rotation;
            }

            set
            {
                rotation = value;
            }
        }
    }
}
