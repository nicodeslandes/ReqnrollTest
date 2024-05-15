using Reqnroll;

namespace ReqnrollTest;

[Binding]
public partial class StepDefinitions
{
    [Then(@"the data should be")]
    public void ThenTheDataShouldBe(Table table)
    {
        var data = new[]
        {
            new{ Id = 1, Value = "Charlie" },
            new{ Id = 2, Value = "Bob" },
        };

        table.CompareToSet(data);
    }

}
