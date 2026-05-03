using System;
using System.Drawing;
using System.Windows.Forms;

public class MainForm : Form {
    public MainForm() {
        this.Size = new Size(500, 350);
        this.BackColor = Color.White;
        this.Text = "Dominant Executor";

        // Botón LOAD (Inject)
        Button loadBtn = new Button { 
            Text = "LOAD", 
            Location = new Point(275, 200), 
            Size = new Size(70, 50),
            BackColor = Color.LightGray 
        };
        loadBtn.Click += (s, e) => {
            this.Text = "BACKDOOR FOUND";
        };
        this.Controls.Add(loadBtn);

        // Editor de texto para scripts
        TextBox txt = new TextBox { 
            Multiline = true, 
            Location = new Point(20, 60), 
            Size = new Size(240, 200),
            ScrollBars = ScrollBars.Vertical 
        };
        this.Controls.Add(txt);
    }

    [STAThread]
    static void Main() {
        Application.EnableVisualStyles();
        Application.Run(new MainForm());
    }
}
