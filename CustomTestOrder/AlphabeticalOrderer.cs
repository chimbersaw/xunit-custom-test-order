using Xunit.Abstractions;
using Xunit.Sdk;

namespace CustomTestOrder;

public class AlphabeticalOrderer : ITestCaseOrderer
{
    public IEnumerable<TTestCase> OrderTestCases<TTestCase>(IEnumerable<TTestCase> testCases)
        where TTestCase : ITestCase
    {
        return testCases.OrderBy(testCase => testCase.TestMethod.Method.Name).Reverse();
    }
}