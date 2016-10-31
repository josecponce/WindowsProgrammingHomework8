using Homework7.Entities;
using Microsoft.Practices.Unity;
using SingleInstanceApplicationLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using WindowsProgramingHomework8;
using WindowsProgramingHomework8.Entities;
using WindowsProgramingHomework8.Repositories;

namespace Homework8 {
    public static class UnityConfig {
        private static IUnityContainer container;
        public static IUnityContainer Container {
            get {
                container = container ?? RegisterComponents();
                return container;
            }
        }
        private static IUnityContainer RegisterComponents() {
            IUnityContainer container = new UnityContainer();
            var txtRepo = new TxtRepository();
            var htmlRepo = new HTMLRepository(txtRepo);
            Dictionary<string, IDocumentRepository<TextsDocument>> repos =
                new Dictionary<string, IDocumentRepository<TextsDocument>> {
                    { ".wtxt",  new BinaryRepository(new BinaryFormatter())},
                    { ".txt", txtRepo },
                    { ".html", htmlRepo },
                    { ".htm", htmlRepo }
                };
            container.RegisterType<IDocumentRepository<TextsDocument>,
                DocumentRepository<TextsDocument>>()
                .RegisterInstance(typeof(SingleInstanceApplication<TextsDocument>), new SingleInstanceApplication<TextsDocument>(container))
                .RegisterType<TopLevelForm<TextsDocument>, FormMain>()
                .RegisterInstance(typeof(IDictionary<string, IDocumentRepository<TextsDocument>>), repos);
                

            return container;
        }
    }
}
