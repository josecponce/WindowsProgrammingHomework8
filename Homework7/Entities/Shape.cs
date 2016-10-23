using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7.Entities {   
    
    [Serializable]
    public class Shape : INotifyPropertyChanged, ICloneable{
        private PointF location;
        private SizeF size;
        private Color penColor;
        private PenType penType;
        private Color brushColor;
        private BrushType brushType;
        private ShapeType type;

        public PointF Location {
            get { return location; }
            set { location = value; OnChange(nameof(Location)); }
        }
        public SizeF Size {
            get { return size; }
            set { size = value; OnChange(nameof(Size)); }
        }
        public Color PenColor {
            get { return penColor; }
            set { penColor = value; OnChange(nameof(PenColor)); }
        }
        public PenType PenType {
            get { return penType; }
            set { penType = value; OnChange(nameof(PenType)); }
        }
        public Color BrushColor {
            get { return brushColor; }
            set { brushColor = value; OnChange(nameof(BrushColor)); }
        }
        public BrushType BrushType {
            get { return brushType; }
            set { brushType = value; OnChange(nameof(BrushType)); }
        }
        public ShapeType Type {
            get { return type; }
            set { type = value; OnChange(nameof(Type)); }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnChange(string propName) {
            PropertyChanged?.Invoke
                (this, new PropertyChangedEventArgs(propName));
        }
        public GraphicsPath getGraphicsPath() {
            GraphicsPath path = new GraphicsPath();
            var rectangle = new RectangleF(Location, Size);
            switch (Type) {
                case ShapeType.Ellipse:
                    path.AddEllipse(rectangle);
                    break;
                case ShapeType.Rectangle:
                    path.AddRectangle(rectangle);
                    break;
                case ShapeType.Custom:
                    path.AddEllipse(rectangle);
                    path.AddRectangle(
                        new RectangleF(
                            new PointF(rectangle.X + rectangle.Width / 2,
                            rectangle.Y),
                            new SizeF(rectangle.Width / 2, rectangle.Height)));
                    break;
                default:
                    break;
            }
            return path;
        }
        public Brush GetBrush() {
            switch (BrushType) {
                case BrushType.Solid:
                    return new SolidBrush(BrushColor);
                case BrushType.Hatch:
                    return new HatchBrush(HatchStyle.Divot,
                        BrushColor, PenColor);
                case BrushType.LinearGradient:
                    return new LinearGradientBrush(
                        new RectangleF(Location, Size), BrushColor, 
                        PenColor, LinearGradientMode.ForwardDiagonal);
                default:
                    return null;
            }
        }
        public Pen GetPen() {
            Pen pen = new Pen(PenColor, 5);
            switch (PenType) {
                case PenType.Solid:
                    return pen;
                case PenType.CustomDashed:
                    pen.DashStyle = DashStyle.Custom;
                    pen.DashPattern = new[] { 0.5f, 1f };
                    return pen;
                case PenType.Compound:
                    pen.Alignment = PenAlignment.Center;
                    pen.CompoundArray = new float[] { 0.0f, 0.25f, 0.50f, 1.00f };
                    return pen;
                default:
                    pen.Dispose();
                    return null;
            }
        }
        public object Clone() {
            return this.MemberwiseClone();
        }
    }
    
    public enum ShapeType {
        Ellipse,
        Rectangle,
        Custom
    }
    public enum PenType {
        Solid,
        CustomDashed,
        Compound
    }
    public enum BrushType {
        Solid,
        Hatch,
        LinearGradient
    }
}
