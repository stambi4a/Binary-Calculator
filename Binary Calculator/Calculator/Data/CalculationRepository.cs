namespace Calculator.Data
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;
    using System.Text;

    using Calculator.Interfaces;
    using Calculator.Utilities;

    public class CalculationRepository : ICalculationRepository
    {
        private readonly Type defaultNumericType = typeof(long);
        public CalculationRepository()
        {
            this.StoredCalculationInput = new List<string>();
            this.StoredCalculationResults = new List<string>();
            this.StoredCalculationBitViews = new List<string>();
        }

        public IList<string> StoredCalculationInput { get; set; }

        public IList<string> StoredCalculationResults { get; }

        public IList<string> StoredCalculationBitViews { get; }
    }
}
