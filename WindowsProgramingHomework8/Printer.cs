using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsProgramingHomework8.Entities;

namespace Homework10 {
    public class Printer : IDisposable {

        TextsDocument document;
        private PrintPreviewDialog printPreviewDialog;
        private PrintDocument pd;
        Form parent;

        public Printer(TextsDocument document, Form parent) {
            this.document = document;
            this.parent = parent;
            printPreviewDialog = new PrintPreviewDialog();

            // Create new PrintDocument 
            pd = new PrintDocument();
            printPreviewDialog.Document = pd;

            // Add a PrintPageEventHandler for the document 
            pd.PrintPage += pd_PrintPage;
        }

        private void pd_PrintPage(object sender, PrintPageEventArgs ev) {
            Graphics g = ev.Graphics;
            int numberOfItems = document.Texts.Count;

            bool isFromDoc = true;
            float x = 0;
            float y = 2;
            PointF def = new PointF(0, 0);
            float lineCount = 0;

            foreach (var item in document.Texts)
            {
                if (item.Location != def)
                {
                    isFromDoc = false;
                    break;
                }
            }

            List<Text> zorderedTexts = new List<Text>(document.Texts);
            zorderedTexts.Sort((one, two) => (one.ZOrder < two.ZOrder) ? -1 : 1);
            for (int i = 0; i < numberOfItems; i++)
            {
                //location:
                if (isFromDoc)
                {
                    if (i != 0)
                    {
                        var fontType = zorderedTexts[i - 1].Font;
                        SizeF wordSize = g.MeasureString(zorderedTexts[i - 1].TextToDraw, fontType);
                        SizeF currentWordSize = g.MeasureString(zorderedTexts[i - 1].TextToDraw, fontType);

                        x = x + wordSize.Width + 1;
                        y = lineCount;

                        if ((x + currentWordSize.Width + 2) > parent.ClientSize.Width)
                        {
                            lineCount = lineCount + wordSize.Height + 1;
                            x = 0;
                            y = lineCount;
                        }
                    }
                }
                else
                {
                    x = zorderedTexts[i].Location.X;
                    y = zorderedTexts[i].Location.Y;
                }
                zorderedTexts[i].Location = new PointF(x, y);
                //size:
                float size = zorderedTexts[i].Font.Size;

                //Font:
                var font = zorderedTexts[i].Font;

                //text that will be displayed:
                string toDraw = "test draw";
                toDraw = zorderedTexts[i].TextToDraw;

                //color:
                Brush brush = new SolidBrush(Color.Black);

                float rotation = (float)zorderedTexts[i].Rotation;
                SizeF textSize = g.MeasureString(zorderedTexts[i].TextToDraw, font);

                if (zorderedTexts[i].Highlighted)
                {
                    var rectangle = new RectangleF(zorderedTexts[i].Location.X, zorderedTexts[i].Location.Y, textSize.Width, textSize.Height);

                    //Filling a rectangle before drawing the string.
                    g.FillRectangle(Brushes.Yellow, rectangle);

                }

                //move rotation point to center of image
                g.TranslateTransform(textSize.Width / 2 + x, textSize.Height / 2 + y);
                //rotate
                g.RotateTransform(rotation);
                //move image back
                g.DrawString(toDraw, font, brush, -(textSize.Width / 2), -(textSize.Height / 2));
                g.ResetTransform();




            }//end forloop
             //try {


            //    foreach (Text t in document.Texts)
            //    {
            //        // Create and initialize print font 
            //        using (Font printFont = t.Font)
            //        {
            //            // Draw a line of text, followed by the chart 
            //            ev.Graphics.DrawString(t.TextToDraw, printFont, Brushes.Black, 10, 10);
            //        }
            //    }

            //    // Create and initialize print font 
            //    using (Font printFont = new Font("Arial", 10)) {
            //        // Draw a line of text, followed by the chart 
            //        ev.Graphics.DrawString("Line before chart", printFont, Brushes.Black, 10, 10);
            //    }
            //    // Create Rectangle structure, used to set the position of the chart Rectangle 
            //    //var myRec = new Rectangle(100, 100, chart.Bounds.Right, chart.Bounds.Bottom);
            //    //chart.Printing.PrintPaint(ev.Graphics, myRec);
        //} catch (Exception e) {
        //        Console.WriteLine(e.Message);
        //    }
        }

        public void ShowDialog() {
            printPreviewDialog.ShowDialog();
        }

        public void Dispose() {
            pd?.Dispose();            
        }
    }
}

