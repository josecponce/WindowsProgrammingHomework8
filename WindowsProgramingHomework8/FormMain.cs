using Homework10;
using Homework3ControlLib;
using Homework7.Dialogs;
using Microsoft.Practices.Unity;
using SingleInstanceApplicationLib;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsProgramingHomework8.Dialogs;
using WindowsProgramingHomework8.Entities;

namespace WindowsProgramingHomework8 {
    public partial class FormMain : TopLevelForm<TextsDocument> {

        private AboutDialog aboutDialog;

        public override ToolStripMenuItem WindowsMenu =>
            windowsToolStripMenuItem;
        protected override bool unsavedChanges => document.Dirty;

        public FormMain(IUnityContainer container, IDocumentRepository<TextsDocument> repository)
            : base(container, repository) {
            InitializeComponent();
        }
        protected override void Initialize(string fileName) {
            base.Initialize(fileName);

            //setting handlers from parent class because designer won't do it for some unamusing reason
            newToolStripMenuItem.Click += newToolStripMenuItem_Click;
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            saveAsToolStripMenuItem.Click += saveAsToolStripMenuItem_Click;
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
        }

        protected override void saveFile(bool promptUser) {
            base.saveFile(promptUser);
            document.Dirty = false;
        }

        private void textOptionsToolStripMenuItem_Click(object sender, EventArgs e) {
            if (bringToFrontIfExists<TextOptionsDialog>()) {
                return;
            }
            TextOptionsDialog = new TextOptionsDialog(this.document);
            TextOptionsDialog.Show(this);

        }

    
        private TextOptionsDialog TextOptionsDialog;


        private void searchToolStripMenuItem_Click(object sender, EventArgs e) {
            if (bringToFrontIfExists<SearchDialog>()) {
                return;
            }
            SearchDialog searchDialog = new SearchDialog();
            searchDialog.Show(this);
        }

        private bool bringToFrontIfExists<Q>() where Q : Form {
            foreach (Form f in Application.OpenForms) {
                if (f is Q) {
                    if (f.WindowState == FormWindowState.Minimized)
                        f.WindowState = FormWindowState.Normal;
                    f.Focus();
                    f.BringToFront();
                    f.Focus();
                    return true;
                }
            }
            return false;
        }

        private void TextPanel_Paint(object sender, PaintEventArgs e) {
            Graphics g = e.Graphics;
            int numberOfItems = document.Texts.Count;

            bool isFromDoc = true;
            float x = 0;
            float y = 2;
            PointF def = new PointF(0, 0);
            float lineCount = 0;

            foreach (var item in document.Texts) {
                if (item.Location != def) {
                    isFromDoc = false;
                    break;
                }
            }

            List<Text> zorderedTexts = new List<Text>(document.Texts);
            zorderedTexts.Sort((one, two) => (one.ZOrder < two.ZOrder) ? -1 : 1);
            for (int i = 0; i < numberOfItems; i++) {
                //location:
                if (isFromDoc) {
                    if (i != 0) {
                        var fontType = zorderedTexts[i - 1].Font;
                        SizeF wordSize = g.MeasureString(zorderedTexts[i - 1].TextToDraw, fontType);
                        SizeF currentWordSize = g.MeasureString(zorderedTexts[i - 1].TextToDraw, fontType);

                        x = x + wordSize.Width + 1;
                        y = lineCount;

                        if ((x + currentWordSize.Width + 2) > this.ClientSize.Width) {
                            lineCount = lineCount + wordSize.Height + 1;
                            x = 0;
                            y = lineCount;
                        }
                    }
                } else {
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

                if(zorderedTexts[i].Highlighted)
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
        }
      

        private int StringindexToMove = -1;
        private Point MouseDownLocation = Point.Empty;
        //on key down move the string, get all rectanges from strings and see if the click is inside any of them
        private void TextPanel_MouseDown(object sender, MouseEventArgs e) {
            MouseDownLocation = e.Location;
            Graphics f = this.CreateGraphics();

            for (int i = 0; i < document.Texts.Count; i++) {
                if (Intersects(MouseDownLocation, document.Texts[i], f)) {
                    StringindexToMove = i;
                }
            }
        }

        private void TextPanel_MouseUp(object sender, MouseEventArgs e) {
            if (MouseDownLocation == e.Location) {
                return;//the mouse did not move so why move the text?
            }
            if (StringindexToMove != -1) {
                document.Texts.ElementAt(StringindexToMove).Location = new PointF(e.X, e.Y);
                //MessageBox.Show(e.X +" y:" + e.Y);
                this.Refresh();
                StringindexToMove = -1;
            }
        }

        private void TextPanel_DragEnter(object sender, DragEventArgs e) {
            if ((e.AllowedEffect & DragDropEffects.All) != 0 && e.Data.GetDataPresent(typeof(string))) {
                e.Effect = DragDropEffects.All;
            }
        }

        private void TextPanel_DragDrop(object sender, DragEventArgs e) {
            string stringData = e.Data.GetData(typeof(string)) as string;            
            AddText(stringData, this.PointToClient(new Point(e.X, e.Y)));
        }

        private void oathToolStripMenuItem_Click(object sender, EventArgs e) {
            using (var dialog = new OathDialog()) {
                dialog.StartPosition = FormStartPosition.Manual;
                dialog.Location = new Point(this.Location.X + this.Width,
                    this.Location.Y);
                dialog.ShowDialog();
            }

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e) {
            if (aboutDialog != null) {
                return;
            }
            aboutDialog = new AboutDialog();
            aboutDialog.StartPosition = FormStartPosition.Manual;
            aboutDialog.Location = new Point(this.Location.X,
                this.Location.Y + this.Height);
            aboutDialog.FormClosed += AboutDialog_FormClosed;
            aboutDialog.Show();

        }
        private void AboutDialog_FormClosed(object sender, FormClosedEventArgs e) {
            aboutDialog = null;
        }

        private void textPanel_MouseClick(object sender, MouseEventArgs e) {
            if (e.Button != MouseButtons.Right)
                return;
            Point Location = e.Location;
            Graphics g = textPanel.CreateGraphics();
            foreach (var text in document.Texts) {
                if (Intersects(Location, text, g)) {
                    textOptionsToolStripMenuItem_Click(null, null);
                    TextOptionsDialog.ChangeSelected(text);
                }
            }
        }

        private bool Intersects(Point p, Text text, Graphics g) {
            SizeF textSize = g.MeasureString(text.TextToDraw, text.Font);

            g.TranslateTransform(textSize.Width / 2 + text.Location.X, textSize.Height / 2 + text.Location.Y);
            g.RotateTransform((float)text.Rotation);
            Point[] points = new[] { p };
            g.TransformPoints(CoordinateSpace.World, CoordinateSpace.Page,
                points);
            g.ResetTransform();

            return new RectangleF(new PointF(-(textSize.Width / 2), -(textSize.Height / 2)), textSize).Contains(points[0]);
        }

        //prompt to enter a word to draw
        private void TextPanel_MouseDoubleClick(object sender, MouseEventArgs e) {
            string input = Microsoft.VisualBasic.Interaction.InputBox("Enter a Word to draw",
                        "Enter a Word to draw",
                        "Default",
                        e.X + 20,
                        e.Y + 20);
            AddText(input, e.Location);

        }
        private void AddText(string text, PointF p) {
            string[] words = text.Split(' ');
            float x = p.X;
            float y = p.Y;
            using (Graphics g = this.CreateGraphics()) {
                for (int i = 0; i < words.Length; i++) {
                    Font font = new Font("Arial", 16);
                    Size size = g.MeasureString(words[i], font).ToSize();
                    if (size.Width + x > textPanel.Width) {//if it doesnt fit in the current line
                        x = 0;//start at the beginning of a new line
                        y += (int)(font.GetHeight() + 1);//rounding up
                    }
                    Text t = new Text(words[i], new PointF(x, y), font, 0, document.NextZOrder(), false);
                    document.Texts.Add(t);

                    x += size.Width + 10;//10 is just some padding
                }
            }

            this.Refresh();
        }
        private void pasteToolStripMenuItem_Click(object sender, EventArgs e) {
            Random random = new Random(DateTime.Now.Millisecond);
            AddText(Clipboard.GetText(), new Point(random.Next(textPanel.Width - 50), random.Next(textPanel.Height - 50)));
        }

        private void saveAsImageToolStripMenuItem_Click(object sender, EventArgs e) {
            using(SaveFileDialog saveFileDialog = new SaveFileDialog()) {
                saveFileDialog.AddExtension = true;
                saveFileDialog.Filter = "Portable Network Graphics (*.png)|*.png" +
                    "|Bitmap File (*.bmp)|*.bmp" +
                    "|Joint Photographic Experts Group File (*.jpg)|*.jpg";
                if (saveFileDialog.ShowDialog() != DialogResult.OK) {
                    return;
                }
                Bitmap image = drawImage();
                ImageFormat format = ImageFormat.Png;
                string ext = saveFileDialog.FileName.Substring(
                    saveFileDialog.FileName.LastIndexOf('.') + 1, 3);
                switch (ext) {
                    case "bmp":
                        format = ImageFormat.Bmp;
                        break;
                    case "png":
                        format = ImageFormat.Png;
                        break;
                    case "jpg":
                        format = ImageFormat.Jpeg;
                        break;
                }
                image.Save(saveFileDialog.FileName, format);
                image.Dispose();
            }
        }
        private Bitmap drawImage() {
            Bitmap result = null;
            using (Graphics panel = textPanel.CreateGraphics()) {
                result = new Bitmap(textPanel.Width, textPanel.Height, panel);
                textPanel.DrawToBitmap(result, new Rectangle(0, 0, textPanel.Width, textPanel.Height));
            }
            return result;
        }

        private void imageEditViewToolStripMenuItem_Click(object sender, EventArgs e) {
            using (OpenFileDialog openFileDialog = new OpenFileDialog()) {
                openFileDialog.AddExtension = true;
                openFileDialog.Filter = "Portable Network Graphics (*.png)|*.png" +
                    "|Bitmap File (*.bmp)|*.bmp" +
                    "|Joint Photographic Experts Group File (*.jpg)|*.jpg";
                if (openFileDialog.ShowDialog() != DialogResult.OK) {
                    return;
                }
                ImageEditForm form = new ImageEditForm(openFileDialog.FileName);
                form.ShowDialog(this);
            }
        }

        private void newTextToolStripMenuItem_Click(object sender, EventArgs e)
        {

            string input = Microsoft.VisualBasic.Interaction.InputBox("Enter a Word to draw",
                        "Enter a Word to draw",
                        "Default",
                        20,
                        20);
            PointF loc = new PointF(20, 20);
         
            AddText(input, loc);
           
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Printer p = new Printer(document, this))
            {
                p.ShowDialog();
            }
        }
    }
}
