using System.Collections.Generic;

namespace RulesEngine
{
    public abstract class BaseRule : IRule
    {
        public string Name { get; }

        protected BaseRule(string name)
        {
            Name = name;
        }

        public abstract bool IsMatchFor(CadEvent cadEvent);
        public abstract RulePaymentLine CalculatePayment(CadEvent cadEvent,
            Dictionary<string, double> supplierAgreementRates);
    }
}