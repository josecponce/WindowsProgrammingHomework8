using SingleInstanceApplicationLib;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using WindowsProgramingHomework8.Entities;

namespace WindowsProgramingHomework8.Repositories {
    public class BinaryRepository : IDocumentRepository<TextsDocument> {
        private IFormatter formatter;

        public BinaryRepository(IFormatter formatter) {
            this.formatter = formatter;
        }
        public TextsDocument LoadDocument(string path) {
            TextsDocument document = null;
            using (Stream stream = File.OpenRead(path)) {
                document = formatter.Deserialize(stream) as TextsDocument;
            }
            document.Dirty = false;
            return document;
        }

        public void SaveDocument(TextsDocument file, string path) {
            using (Stream stream = File.OpenWrite(path)) {
                formatter.Serialize(stream, file);
            }
            file.Dirty = false;
        }
    }
}
