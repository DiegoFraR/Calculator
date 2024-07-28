using Microsoft.Playwright;

namespace CalculatorEndToEndTests;

[Parallelizable(ParallelScope.Self)]
[TestFixture]
public class Tests : PageTest
{
    [Test]
    public async Task CalculatorPage_HasTitleCalculator()
    {
        await Page.GotoAsync("https://localhost:7037");
        await Expect(Page).ToHaveTitleAsync(new Regex("Calculator"));
    }

    [Test]
    public async Task CalculatorPage_AddTwoNumbersTogether_GetsValidResultOnScreen()
    {
        await Page.GotoAsync("https://localhost:7037");
        await Page.GetByRole(AriaRole.Textbox, new () { NameString = "A" }).ClickAsync();
        await Page.GetByRole(AriaRole.Textbox, new () { NameString = "A" }).FillAsync("5");
        await Page.GetByRole(AriaRole.Textbox, new () { NameString = "B" }).ClickAsync();
        await Page.GetByRole(AriaRole.Textbox, new () { NameString = "B" }).FillAsync("5");
        await Page.GetByRole(AriaRole.Button, new () { NameString = "A + B" }).ClickAsync();

        await Expect(Page.GetByText("10")).ToBeVisibleAsync();
    }

    [Test]
    public async Task CalculatorPage_ReturnsErrorMessage_WhenDivideByZeroExceptionOccurs()
    {
        await Page.GotoAsync("https://localhost:7037/");
        await Page.GetByRole(AriaRole.Textbox, new () { NameString = "A" }).ClickAsync();
        await Page.GetByRole(AriaRole.Textbox, new () { NameString = "A" }).FillAsync("25");
        await Page.GetByRole(AriaRole.Textbox, new () { NameString = "B" }).ClickAsync();
        await Page.GetByRole(AriaRole.Textbox, new () { NameString = "B" }).FillAsync("0");
        await Page.GetByRole(AriaRole.Button, new () { NameString = "A / B" }).ClickAsync();
        
        await Expect(Page.GetByText("Error Occured: Cannot Divide by Zero!")).ToBeVisibleAsync();
    }
    
    //Add Test to ensure non-text elements are accounted for.

    [Test]
    public async Task CalculatorPage_ClearMethod_ClearsElementsAfterOperationCalled()
    {
        await Page.GotoAsync("https://localhost:7037/");
        await Page.GetByRole(AriaRole.Textbox, new () { NameString = "A" }).ClickAsync();
        await Page.GetByRole(AriaRole.Textbox, new () { NameString = "A" }).FillAsync("15");
        await Page.GetByRole(AriaRole.Textbox, new () { NameString = "B" }).ClickAsync();
        await Page.GetByRole(AriaRole.Textbox, new () { NameString = "B" }).FillAsync("15");
        await Page.GetByRole(AriaRole.Button, new () { NameString = "A + B" }).ClickAsync();
        await Page.GetByRole(AriaRole.Button, new () { NameString = "Clear" }).ClickAsync();
        
        await Expect(Page.GetByText("Enter value(s) below and select an operation!")).ToBeVisibleAsync();
        
    }
}