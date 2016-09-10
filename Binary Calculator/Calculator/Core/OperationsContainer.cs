namespace Calculator.Core
{
    using System.Windows.Forms;

    using Calculator.Attributes;
    using Calculator.Interfaces;

    [Core]
    public class OperationsContainer: IOperationsContainer
    {
        private readonly ICalculationRepository calculationRepository;

        [Inject]
        private readonly IRepositoryHandler repositoryHandler;

        [Inject]
        private readonly IMethodInvoker methodInvoker;

        [Inject]
        private readonly IValueExtractor valueExtractor;

        [Inject]
        private readonly ICalculationHandler calculationHandler;

        private readonly IDependencyContainer dependencyContainer;

        public OperationsContainer(ICalculationRepository calculationRepository, IDependencyContainer dependencyContainer)
        {
            this.dependencyContainer = dependencyContainer;
            this.calculationRepository = calculationRepository;
        }

        public ICalculationHandler CalculationHandler => this.calculationHandler;

        public void Execute(string input)
        {
            this.calculationHandler.Execute(input);
        }

        public void RestoreResultFromMemory()
        {
            throw new System.NotImplementedException();
        }
    }
}
