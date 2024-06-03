namespace GraphicalUserInterface;

using System;
using System.Windows.Forms;

public partial class CloseWindow : Form
{
    public bool IsNotClosed { get; set; } = true;
    public Label Notification { get; set; } = new Label();
    public Button Confirm { get; set; } = new Button();

    public CloseWindow()
    {
        InitializeComponent();
        Notification = lbNoti;
        Confirm = btn_Yes;
    }

    private void btn_Yes_Click(object sender, EventArgs e)
    {
        this.Close();
        IsNotClosed = false;
    }

    private void btn_Cancel_Click(object sender, EventArgs e)
    {
        this.Close();
    }
}
