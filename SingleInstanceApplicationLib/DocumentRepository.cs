using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SingleInstanceApplicationLib {
    public class DocumentRepository<T> : IDocumentRepository<T> where T : class{
        private IFormatter formatter;

        public DocumentRepository(IFormatter formatter) {
            this.formatter = formatter;
        }

        public T LoadDocument(string path) {
            T document = null;
            using (Stream stream = File.OpenRead(path)) {
                document = formatter.Deserialize(stream) as T;
            }
            return document;
        }

        public void SaveDocument(T document, string path) {
            using (Stream stream = File.OpenWrite(path)) {
                formatter.Serialize(stream, document);
            }
        }
    }
}
