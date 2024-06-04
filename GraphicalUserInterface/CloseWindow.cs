namespace GraphicalUserInterface;

using System;
using System.Windows.Forms;

public partial class CloseWindow : Form
{
    public CloseWindow()
    {
        this.InitializeComponent();
        this.Notification = this.lbNoti;
        this.Confirm = this.btn_Yes;
    }

    public bool IsNotClosed { get; set; } = true;

    public Label Notification { get; set; } = new Label();

    public Button Confirm { get; set; } = new Button();

    private void btn_Yes_Click(object sender, EventArgs e)
    {
        this.Close();
        this.IsNotClosed = false;
    }

    private void btn_Cancel_Click(object sender, EventArgs e)
    {
        this.Close();
    }
}
