using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;
using System.Drawing;

namespace Homework7.Entities {
    [Serializable]
    public class ShapesDocument {
        public List<Shape> Shapes { get; set; }
        private Font font;
        public Font Font {
            get { return font; }
            set { font = value; Dirty = true; }
        }
        private Color fontColor;
        public Color FontColor {
            get { return fontColor; }
            set { fontColor = value; Dirty = true; }
        }
        [NonSerialized]
        public bool Dirty = false;
        
        public ShapesDocument() {
            Font = SystemFonts.DefaultFont;
            FontColor = SystemColors.InfoText;
            Shapes = new List<Shape>();
            Dirty = false;
        }
        public void AddShape(Shape shape) {
            Shapes.Add(shape);
            shape.PropertyChanged += Shape_PropertyChanged;
            Dirty = true;
        }
        public void RemoveShape(Shape shape) {
            Shapes.Remove(shape);
            shape.PropertyChanged -= Shape_PropertyChanged;
            Dirty = true;
        }

        public void Draw(Graphics g) {
            foreach (var shape in Shapes) {
                var path = shape.getGraphicsPath();
                using (Brush brush = shape.GetBrush()) {
                    g.FillPath(brush, path);
                }
                using (Pen pen = shape.GetPen()) {
                    g.DrawPath(pen, path);
                }
                using (Brush textBrush = new SolidBrush(FontColor)) {
                    g.DrawString(shape.Type.ToString(), this.Font,
                        textBrush, new PointF(
                            shape.Location.X + shape.Size.Width/2,
                            shape.Location.Y + shape.Size.Height/2));
                }
            }
        }

        private void Shape_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e) {
            Dirty = true;
        }
    }
}
