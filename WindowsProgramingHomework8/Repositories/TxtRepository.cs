using SingleInstanceApplicationLib;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsProgramingHomework8.Entities;

namespace WindowsProgramingHomework8.Repositories {
    public class TxtRepository : IDocumentRepository<TextsDocument> {
        public TextsDocument LoadDocument(string path) {
            List<Text> texts = new List<Text>();

            string[] allText = File.ReadAllLines(path);
            int zOrder = 0;
            foreach (var line in allText) {
                foreach (var word in line.Split(' ', '\t')) {
                    texts.Add(new Text(
                        word, new PointF(0, 0), SystemFonts.DefaultFont, 0, zOrder++, false));
                }
            }

            TextsDocument doc = new TextsDocument() {
                Texts = texts,
                Dirty = false
            };

            return doc;
        }

        public void SaveDocument(TextsDocument file, string path) {
            throw new InvalidOperationException();
        }
    }
}
