using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Homework7.Entities {
    public class ShapesDocumentRepository : IShapesDocumentRepository {

        private IFormatter formatter;

        public ShapesDocumentRepository(IFormatter formatter) {
            this.formatter = formatter;
        }

        public ShapesDocument LoadDocument(string path) {
            ShapesDocument document = null;
            using (Stream stream = File.OpenRead(path)) {        
                document = formatter.Deserialize(stream) as ShapesDocument;
            }
            return document;
        }

         public void SaveDocument(ShapesDocument document, string path) {
            using (Stream stream = File.OpenWrite(path)) {
                formatter.Serialize(stream, document);
            }
        }
    }
}
