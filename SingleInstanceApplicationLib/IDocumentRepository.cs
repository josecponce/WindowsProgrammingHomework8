using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleInstanceApplicationLib {
    public interface IDocumentRepository<T> {
        void SaveDocument(T file, string path);
        T LoadDocument(string path);
    }
}
