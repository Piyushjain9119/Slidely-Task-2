Partial Public Class Form1 :  Form
{
    Private VIEW viewForm; // Declare a variable To hold the reference To VIEW form
    Private String dataToSend; // String To hold data For VIEW

    Public Form1()
    {
        InitializeComponent();
        viewForm = New VIEW();
        dataToSend = "This is data from Form1!"; // Set some default data
    }

    Private void Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    {
        // Existing code for Form1 initialization (if any)
    }

    Private void Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    {
        viewForm.Show(); // Show the VIEW form
        viewForm.UpdateLabel(dataToSend); // Call a method in VIEW to update the label
    }
}
