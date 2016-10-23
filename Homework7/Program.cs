using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Practices.Unity;
using SingleInstanceApplicationLib;
using Homework7.Entities;

namespace Homework7 {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args) {
            UnityConfig.Container.Resolve<SingleInstanceApplication<ShapesDocument>>()
                .Run(args);
        }
    }
}
