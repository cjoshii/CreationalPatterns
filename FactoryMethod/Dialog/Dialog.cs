namespace FactoryMethod.Dialog;

public abstract class Dialog
{
    public abstract Button CreateButton();
    public void Render()
    {
        var okButton = CreateButton();
        okButton.Render();
        okButton.Click += okButtonClick;
        okButton.OnClick();

    }
    private void okButtonClick(object? sender, EventArgs e)
    {
        Console.WriteLine("Closing the dialog");
    }
}

public class WinDialog : Dialog
{
    public override Button CreateButton()
    {
        return new WinButton();
    }
}

public class WebDialog : Dialog
{
    public override Button CreateButton()
    {
        return new WebButton();
    }
}

public interface Button
{
    void Render();
    void OnClick();
    event EventHandler? Click;
}

public class WinButton : Button
{
    public event EventHandler? Click;
    public void Render()
    {
        Console.WriteLine("Render WinButton");
    }
    public void OnClick()
    {
        Click?.Invoke(this, EventArgs.Empty);
    }
}

public class WebButton : Button
{
    public event EventHandler? Click;
    public void Render()
    {
        Console.WriteLine("Render WebButton");
    }
    public void OnClick()
    {
        Click?.Invoke(this, EventArgs.Empty);
    }
}