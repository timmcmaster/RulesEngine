using System.Collections.Generic;

namespace RulesEngine
{
    public interface IRule
    {
        bool IsMatchFor(CadEvent cadEvent); // Need to add criteria values specific to agreement
        RulePaymentLine CalculatePayment(CadEvent cadEvent, Dictionary<string, double> supplierAgreementRates);
    }
}
