using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RulesEngine;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create rules engine instance
            Engine engine = new Engine();

            // Define cad event
            CadEvent cadEvent = new CadEvent()
            {
                JobTime = new DateTime(2019, 07, 08, 13, 29, 12)
            };

            // Define supplier agreement rates
            // NB: this means that CRM will need to identify agreement (or agreements?) event was done under
            Dictionary<string, double> agreementRates = new Dictionary<string, double>();
            agreementRates.Add("AfterMiddayRate", 77);

            var activeRules = engine.GetRules();

            Payment payment = engine.CalculatePayments(activeRules, cadEvent, agreementRates);

            payment.PrintDetails();

        }
    }
}
