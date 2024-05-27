using Reqnroll;

namespace ReqnrollTest;

[Binding]
public class StepDefinitions
{
    [Then(@"the data should be")]
    public void ThenTheDataShouldBe(Table table)
    {
        var data = new List<Entry>();

        for (var i = 0; i < 2; i++)
        {
            if (i == 0)
            {
                data.Add(new(1, "Charlie"));
            }
            else
            {
                data.Add(new(2, "Bob"));
            }
        };

        table.CompareToSet(data);
    }

}

public record Entry(int Id, string Value);