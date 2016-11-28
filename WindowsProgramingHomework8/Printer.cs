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
        private PrintDialog printDialog;
        private PrintDocument pd;
        Form parent;
        int pageNumber;

        public Printer(TextsDocument document, Form parent) {
            this.document = document;
            this.parent = parent;
            printDialog = new PrintDialog();

            // Create new PrintDocument 
            pd = new PrintDocument();
            printDialog.Document = pd;
            printDialog.UseEXDialog = true;
            pageNumber = 1;


            // Add a PrintPageEventHandler for the document 
            pd.PrintPage += pd_PrintPage;

            
        }

        private void pd_PrintPage(object sender, PrintPageEventArgs ev)
        {          
            Graphics g = ev.Graphics;
            Rectangle rec = ev.MarginBounds;


            g.DrawString("Group 2", new Font("Times New Roman", 8), new SolidBrush(Color.Black), new Point(100, 50));
            string h = "Homework Assignment 10";
            var m = g.MeasureString(h, new Font("Times New Roman", 8));
            g.DrawString(h, new Font("Times New Roman", 8), new SolidBrush(Color.Black), new Point(rec.Width + 100 - (int)m.Width, 50));
            g.DrawLine(new Pen(Color.Black), new Point(100, 80), new Point(rec.Width + 100, 80));
            g.DrawLine(new Pen(Color.Black), new Point(100, rec.Height + 120), new Point(rec.Width + 100, rec.Height + 120));
            DateTime date = DateTime.Today;
            g.DrawString(date.ToShortDateString(), new Font("Times New Roman", 8), new SolidBrush(Color.Black), new Point(100, rec.Height + 150));
            g.DrawString(pageNumber.ToString(), new Font("Times New Roman", 8), new SolidBrush(Color.Black), new Point(rec.Width/2 + 100, rec.Height + 150));



            int numberOfItems = document.Texts.Count;

            float x = 0;
            float y = 2;
            PointF def = new PointF(0, 0);

            List<Text> zorderedTexts = new List<Text>(document.Texts);
            zorderedTexts.Sort((one, two) => (one.ZOrder < two.ZOrder) ? -1 : 1);
            for (int i = 0; i < numberOfItems; i++)
            {
                x = zorderedTexts[i].Location.X;
                y = zorderedTexts[i].Location.Y + 100;
                
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

                //move rotation point to center of image
                g.TranslateTransform(textSize.Width / 2 + x, textSize.Height / 2 + y);
                //rotate
                g.RotateTransform(rotation);

               
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
            pageNumber++;
        }

        public void ShowDialog() {
            if (DialogResult.OK == printDialog.ShowDialog())
            {
                pd.Print();
            }
        }

        public void Dispose() {
            pd?.Dispose();            
        }
    }
}

