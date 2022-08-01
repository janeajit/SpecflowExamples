using FluentAssertions;
using SpecflowExamples;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject.Steps
{
    [Binding]
    public sealed class CalculatorSteps
    {
        private readonly Calculator _calculator = new Calculator();
        private int _result;
       

        [Given("the firsts number is (.*)")]
        public void GivenTheFirstsNumberIs(int number)
        {
            //TODO: implement arrange (precondition) logic
            // For storing and retrieving scenario-specific data see https://go.specflow.org/doc-sharingdata
            // To use the multiline text or the table argument of the scenario,
            // additional string/Table parameters can be defined on the step definition
            // method. 

            _calculator.FirstNumber = number;
        }

        [Given("the seconds number is (.*)")]
        public void GivenTheSecondsNumberIs(int number)
        {
            //TODO: implement arrange (precondition) logic
            // For storing and retrieving scenario-specific data see https://go.specflow.org/doc-sharingdata
            // To use the multiline text or the table argument of the scenario,
            // additional string/Table parameters can be defined on the step definition
            // method. 

            _calculator.SecondNumber = number;
        }

        [When("the two numbers are subtracted")]
        public void WhenTheTwoNumbersAreSubtract()
        {
            //TODO: implement act (action) logic

            _result = _calculator.Subtract();
        }

        [Then("the results should be (.*)")]
        public void ThenTheResultsShouldBe(int result)
        {
            //TODO: implement assert (verification) logic

            _result.Should().Be(result);
        }
    }
}
