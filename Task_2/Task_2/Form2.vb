Partial Public Class VIEW :    Form
{
    Public VIEW()
    {
        InitializeComponent();
    }

    Private void VIEW_Load(sender As Object, e As EventArgs) Handles MyBase.Load
Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

        {
        // Existing code for VIEW initialization (if any)
    }

    Public void UpdateLabel(String data) // Public method To update label from Form1
    {
        Label2.Text = data; // Update the Label2 text with received data
    }

    // Existing event handlers for Label2_Click, Label4_Click, TextBox4_TextChanged, TextBox1_TextChanged (if any)
}
