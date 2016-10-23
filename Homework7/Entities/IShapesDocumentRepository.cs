using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7.Entities {
    public interface IShapesDocumentRepository {
        void SaveDocument(ShapesDocument file, string path);
        ShapesDocument LoadDocument(string path);
    }
}
