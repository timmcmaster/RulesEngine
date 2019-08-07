using System;
using System.Collections.Generic;

namespace RulesEngine
{
    public class AfterMiddayRule : BaseRule
    {
        public AfterMiddayRule() : base("AfterMiddayRule")
        {
        }

        public override bool IsMatchFor(CadEvent cadEvent)
        {
            TimeSpan noon = new TimeSpan(12, 0, 0);
            return cadEvent.JobTime.TimeOfDay > noon;
        }

        public override RulePaymentLine CalculatePayment(CadEvent cadEvent, Dictionary<string,double> supplierAgreementRates)
        {
            double rate;
            supplierAgreementRates.TryGetValue("AfterMiddayRate", out rate);
            return new RulePaymentLine(this.Name, rate);
        }
    }
}
