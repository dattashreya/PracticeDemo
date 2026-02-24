using System;
using System.Drawing;
using System.Windows.Forms;

class DynamicButtonApp : Form
{
    public DynamicButtonApp()
    {
        // 1. Create the button dynamically
        Button btn = new Button();
        btn.Text = "Click Me";
        btn.Size = new Size(100, 50);
        btn.Location = new Point(50, 50);

        // 2. Using an anonymous function (lambda expression) for the event
        btn.Click += (sender, e) => 
        {
            MessageBox.Show("Button clicked dynamically!");
        };

        this.Controls.Add(btn);
    }

    [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
        Application.Run(new DynamicButtonApp());
    }
}
