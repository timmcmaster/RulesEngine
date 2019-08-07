namespace RulesEngine
{
    public class RulePaymentLine
    {
        public RulePaymentLine(string ruleName, double amount)
        {
            RuleName = ruleName;
            Amount = amount;
        }

        public string RuleName { get; }
        public double Amount { get; }
    }
}
