using System;
using System.Windows.Forms;

public class Program {
    [STAThread]
    static void Main() {
        Form f = new Form();
        f.Text = "SECRET EXECUTOR";
        Application.Run(f);
    }
}
