using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RulesEngine
{
    public class Engine
    {
        public IEnumerable<IRule> GetRules()
        {
            // TODO: Would want to get applicable rules based on request provided
            List<IRule> rules = new List<IRule> {new AfterMiddayRule()};

            return rules;
        }

        public Payment CalculatePayments(IEnumerable<IRule> rules, CadEvent cadEvent, Dictionary<string,double> agreementRates)
        {
            Payment payment = new Payment();

            foreach (IRule rule in rules)
            {
                if (rule.IsMatchFor(cadEvent))
                {
                    payment.AddPaymentLine(rule.CalculatePayment(cadEvent, agreementRates));
                }
            }

            return payment;
        }

    }
}
