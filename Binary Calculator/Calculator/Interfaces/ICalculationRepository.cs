namespace Calculator.Interfaces
{
    using System;
    using System.Collections.Generic;

    public interface ICalculationRepository
    {
        IList<string> StoredCalculationInput { get; }

        IList<string> StoredCalculationResults { get; }

        IList<string> StoredCalculationBitViews { get; }
    }
}
