using SingleInstanceApplicationLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsProgramingHomework8.Entities;

namespace WindowsProgramingHomework8.Repositories {
    public class HTMLRepository : IDocumentRepository<TextsDocument> {
        private TxtRepository repository;
        public HTMLRepository(TxtRepository repository) {
            this.repository = repository;
        }
        public TextsDocument LoadDocument(string path) {
            return repository.LoadDocument(path);
        }

        public void SaveDocument(TextsDocument file, string path) {
            throw new InvalidOperationException();
        }
    }
}
