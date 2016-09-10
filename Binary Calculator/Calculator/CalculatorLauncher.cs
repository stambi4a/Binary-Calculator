namespace Calculator
{
    using System;
    using System.Collections.Generic;
    using System.Security.Permissions;
    using System.Threading;
    using System.Windows.Forms;

    using Calculator.Core;
    using Calculator.Data;
    using Calculator.Forms;
    using Calculator.Interfaces;

    public class CalculatorLauncher
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        [SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.ControlAppDomain)]
        private static void Main()
        {
            IDependencyContainer dependencyContainer = new DependencyContainer();
            var calculationRepository = new CalculationRepository();
            dependencyContainer.AddDependency(typeof(ICalculationRepository), calculationRepository);
            dependencyContainer.AddDependency(typeof(IDependencyContainer), dependencyContainer);
            var operationsContainer = dependencyContainer.Resolve<IOperationsContainer>();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var binaryCalculator = new BinaryCalculator(operationsContainer);
            Application.Run(binaryCalculator);
        }
    }
}
