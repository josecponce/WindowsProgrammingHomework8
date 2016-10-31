using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SingleInstanceApplicationLib {
    public class DocumentRepository<T> : IDocumentRepository<T> where T : class{
        
        private IDictionary<string, IDocumentRepository<T>> repositories;
        
        public DocumentRepository(
            IDictionary<string, IDocumentRepository<T>> repositories) {
            this.repositories = repositories;            
        }

        public T LoadDocument(string path) {
            string extension = path.Substring(
                path.LastIndexOf("."),
                path.Length - path.LastIndexOf(".")).ToLower();
            T document = repositories[extension].LoadDocument(path);
            return document;
        }

        public void SaveDocument(T document, string path) {
            //always save in binary format, regardless of extension
            repositories[".wtxt"].SaveDocument(document, path);
        }
    }
}
