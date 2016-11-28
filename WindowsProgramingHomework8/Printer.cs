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
        int lastIndex;

        public Printer(TextsDocument document, Form parent) {
            this.document = document;
            this.parent = parent;
            printDialog = new PrintDialog();

            // Create new PrintDocument 
            pd = new PrintDocument();
            printDialog.Document = pd;
            printDialog.UseEXDialog = true;
            pageNumber = 1;
            lastIndex = 0;


            // Add a PrintPageEventHandler for the document 
            pd.PrintPage += pd_PrintPage;

            
        }

        private void pd_PrintPage(object sender, PrintPageEventArgs ev)
        {          
            Graphics g = ev.Graphics;
            Rectangle rec = ev.MarginBounds;
            var font = new Font("Times New Roman", 8);


            g.DrawString("Group 2", font, new SolidBrush(Color.Black), new Point(100, 50));
            string h = "Homework Assignment 10";
            var m = g.MeasureString(h, new Font("Times New Roman", 8));
            g.DrawString(h,font , new SolidBrush(Color.Black), new Point(rec.Width + 100 - (int)m.Width, 50));
            g.DrawLine(new Pen(Color.Black), new Point(100, 80), new Point(rec.Width + 100, 80));
            g.DrawLine(new Pen(Color.Black), new Point(100, rec.Height + 120), new Point(rec.Width + 100, rec.Height + 120));
            DateTime date = DateTime.Today;
            g.DrawString(date.ToShortDateString(), font, new SolidBrush(Color.Black), new Point(100, rec.Height + 150));
            g.DrawString(pageNumber.ToString(), font, new SolidBrush(Color.Black), new Point(rec.Width/2 + 100, rec.Height + 150));

            int col = 0;
            int row = 0;
            font = new Font("Times New Roman", 14);
            g.DrawString("Text", font, new SolidBrush(Color.Black), new Point((rec.Width / 5) * col++ + 100, 110));
            g.DrawString("Font", font, new SolidBrush(Color.Black), new Point((rec.Width / 5) * col++ + 100, 110));
            g.DrawString("Location", font, new SolidBrush(Color.Black), new Point((rec.Width / 5) * col++ + 100, 110));
            g.DrawString("Rotation", font, new SolidBrush(Color.Black), new Point((rec.Width / 5) * col++ + 100, 110));
            g.DrawString("ZOrder", font, new SolidBrush(Color.Black), new Point((rec.Width / 5) * col++ + 100, 110));
            row++;

            var mes = g.MeasureString("Text", font);

            int numberOfItems = document.Texts.Count;

            float x = 100;
            float y = 100 + mes.Height + 5;            

            List<Text> zorderedTexts = new List<Text>(document.Texts);
            font = new Font("Times New Roman", 8);

            for (int i = lastIndex; i < numberOfItems; i++)
            {
                //text that will be displayed:
                string toDraw = zorderedTexts[i].TextToDraw;
                if (toDraw != "")
                {
                    col = 0;

                    //location:
                    PointF loc = zorderedTexts[i].Location;
                    //Font:
                    var fontName = zorderedTexts[i].Font.Name;
                    //rotation
                    float rotation = (float)zorderedTexts[i].Rotation;
                    //zOrder
                    int zorder = zorderedTexts[i].ZOrder;


                    //color:
                    Brush brush = new SolidBrush(Color.Black);

                    mes = g.MeasureString(toDraw, font);

                    x = (rec.Width / 5) * col++ + 100;
                    g.DrawString(toDraw, font, brush, x, y);
                    x = (rec.Width / 5) * col++ + 100;
                    g.DrawString(fontName, font, brush, x, y);
                    x = (rec.Width / 5) * col++ + 100;
                    g.DrawString(loc.ToString(), font, brush, x, y);
                    x = (rec.Width / 5) * col++ + 100;
                    g.DrawString(rotation.ToString(), font, brush, x, y);
                    x = (rec.Width / 5) * col++ + 100;
                    g.DrawString(zorder.ToString(), font, brush, x, y);


                    y = y + mes.Height + 5;
                    if (y >= rec.Height + 100)
                    {
                        ev.HasMorePages = true;
                        y = 0;
                        lastIndex = i;
                        pageNumber++;
                        return; // you need to return, then it will go into this function again
                    }
                    else
                    {
                        ev.HasMorePages = false;
                    }
                        

                    
                }
                
            }
            
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

