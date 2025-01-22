using КП.Infrastructure;

public class Panel1 : UserControl
{
    public Panel1()
    {
        this.BackColor = System.Drawing.Color.LightBlue;
        this.Dock = DockStyle.Fill;

        Button switchButton = new Button
        {
            Text = "Перейти на Panel2",
            Dock = DockStyle.Top
        };
        switchButton.Click += (s, e) => PanelManager.SwitchTo<Panel2>();

        this.Controls.Add(switchButton);
    }
}

public class Panel2 : UserControl
{
    public Panel2()
    {
        this.BackColor = System.Drawing.Color.LightGreen;
        this.Dock = DockStyle.Fill;

        Button switchButton = new Button
        {
            Text = "Перейти на Panel1",
            Dock = DockStyle.Top
        };
        switchButton.Click += (s, e) => PanelManager.SwitchTo<Panel1>();

        this.Controls.Add(switchButton);
    }
}
