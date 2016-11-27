using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsProgramingHomework8.Entities
{
    [Serializable]
    public class Text : INotifyPropertyChanged, ICloneable
    {
        private string textToDraw;
        private PointF location;
        private Font font;
        private double rotation;
        private int zOrder;

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnChange(string propName)
        {
            PropertyChanged?.Invoke
                (this, new PropertyChangedEventArgs(propName));
        }

        public Text(string text, PointF location, Font font, double rotation, int zOrder)
        {
            this.textToDraw = text;
            this.location = location;
            this.font = font;
            this.rotation = rotation;
            this.zOrder = zOrder;
        }
        public int ZOrder {
            get {
                return zOrder;
            }
            set {
                zOrder = value;
                OnChange(nameof(ZOrder));
            }
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
                OnChange(nameof(TextToDraw));
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
                OnChange(nameof(Location));
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
                OnChange(nameof(Font));
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
                OnChange(nameof(Rotation));
            }
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
