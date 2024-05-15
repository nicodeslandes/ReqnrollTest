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
            new{ Id = 1, Value = "Charlie" }
        };

        table.CompareToSet(data);
    }

}
