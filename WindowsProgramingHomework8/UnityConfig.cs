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

            container.RegisterType<IDocumentRepository<TextsDocument>,
                DocumentRepository<TextsDocument>>()
                .RegisterInstance(typeof(IFormatter), new BinaryFormatter())
                .RegisterInstance(typeof(SingleInstanceApplication<TextsDocument>), new SingleInstanceApplication<TextsDocument>(container))
                .RegisterType<TopLevelForm<TextsDocument>, FormMain>();

            return container;
        }
    }
}
