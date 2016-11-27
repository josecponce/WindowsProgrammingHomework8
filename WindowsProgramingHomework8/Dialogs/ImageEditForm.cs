using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsProgramingHomework8.Dialogs {
    public partial class ImageEditForm : Form {
        public Bitmap Image { get; set; }
        public ImageEditForm() {
            InitializeComponent();
        }
        public ImageEditForm(string imagePath) : this(new Bitmap(imagePath)) {
        }
        public ImageEditForm(Bitmap image) : this() {
            Image = image;
            imageViewPictureBox.Image = Image;
            Color[] colors = getColors(image);
            PopulateColorPalette(colors);
        }

        private void Button_Click(object sender, EventArgs e) {
            Color oldColor = (Color)((Button)sender).Tag;
            using (ColorDialog dialog = new ColorDialog() { Color = oldColor }) {
                if (dialog.ShowDialog() != DialogResult.OK) {
                    return;
                }
                Color newColor = dialog.Color;
                ColorMap map = new ColorMap {
                    OldColor = oldColor,
                    NewColor = newColor
                };
                ImageAttributes attributes = new ImageAttributes();
                attributes.SetRemapTable(new ColorMap[] { map });
                Bitmap newImage = getColorMappedBitmap(attributes);
                Image.Dispose();
                Image = newImage;
                imageViewPictureBox.Image = Image;
            }
            //repopulate color palette, since one color doesn't exist anymore
            Color[] colors = getColors(Image);
            PopulateColorPalette(colors);
        }
        private Bitmap getColorMappedBitmap(ImageAttributes attributes) {
            Bitmap result = null;
            using (Graphics imageView = imageViewPictureBox.CreateGraphics()) {
                result = new Bitmap(Image.Width, Image.Height, imageView);
                using (Graphics imageGraphics = Graphics.FromImage(result)) {
                    imageGraphics.DrawImage(Image, new Rectangle(0, 0, Image.Width, Image.Height),
                        0, 0, Image.Width, Image.Height, GraphicsUnit.Pixel, attributes);//graphics unit "has to be" pixel
                }
            }
            return result;
        }
        private Color[] getColors(Bitmap image) {
            List<Color> colors = new List<Color>();
            for (int y = 0; y < image.Height; y++) {
                for (int x = 0; x < image.Width; x++) {
                    Color color = image.GetPixel(x, y);
                    if (colors.Count == 0 || !colors.Contains(color)) {//add color if not added yet
                        colors.Add(color);
                    }
                }
            }
            return colors.ToArray();
        }
        private void PopulateColorPalette(Color[] colors) {
            colorPalettePanel.Controls.Clear();
            foreach (var color in colors) {
                Button button = new Button {
                    Text = color.Name,
                    Dock = DockStyle.Top,
                    Width = colorPalettePanel.Width,
                    Tag = color,
                    BackColor = color
                };
                button.Click += Button_Click;
                colorPalettePanel.Controls.Add(button);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e) {
            using (OpenFileDialog openFileDialog = new OpenFileDialog()) {
                openFileDialog.AddExtension = true;
                openFileDialog.Filter = "Portable Network Graphics (*.png)|*.png" +
                    "|Bitmap File (*.bmp)|*.bmp" +
                    "|Joint Photographic Experts Group File (*.jpg)|*.jpg";
                if (openFileDialog.ShowDialog() != DialogResult.OK) {
                    return;
                }
                Image = new Bitmap(openFileDialog.FileName);
                imageViewPictureBox.Image = Image;
                Color[] colors = getColors(Image);
                PopulateColorPalette(colors);
            }
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e) {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog()) {
                saveFileDialog.AddExtension = true;
                saveFileDialog.Filter = "Portable Network Graphics (*.png)|*.png";
                if (saveFileDialog.ShowDialog() != DialogResult.OK) {
                    return;
                }
                ImageFormat format = ImageFormat.Png;       
                Image.Save(saveFileDialog.FileName, format);
                Image.Dispose();
            }
        }
    }
}
