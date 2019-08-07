using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RulesEngine
{
    public class Payment
    {
        private readonly List<RulePaymentLine> _paymentLines;

        public Payment()
        {
            _paymentLines = new List<RulePaymentLine>();
        }

        public void AddPaymentLine(RulePaymentLine paymentLine)
        {
            _paymentLines.Add(paymentLine);
        }

        public double Total => _paymentLines.Sum(pl => pl.Amount);

        public void PrintDetails()
        {
            foreach (RulePaymentLine line in _paymentLines)
            {
                Console.WriteLine("Rule applied: {0}. Amount paid: {1}", line.RuleName, line.Amount);
            }

            Console.WriteLine("Total payment: {0}",this.Total);
        }

    }
}
