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

namespace Homework7 {
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

            container.RegisterType<IDocumentRepository<ShapesDocument>,
                DocumentRepository<ShapesDocument>>()
                .RegisterInstance(typeof(IFormatter), new BinaryFormatter())
                .RegisterInstance(typeof(SingleInstanceApplication<ShapesDocument>), new SingleInstanceApplication<ShapesDocument>(container))
                .RegisterType<TopLevelForm<ShapesDocument>, HW7TopLevelForm>();

            return container;
        }
    }
}
