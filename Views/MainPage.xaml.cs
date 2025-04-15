using System.Text.RegularExpressions;
using static System.Text.RegularExpressions.Regex;

namespace Multus.Views;

public partial class MainPage : ContentPage
{
    string? val1;
    string? val2;
    string omath, press;

    public MainPage()
    {
        InitializeComponent();
    }

    void Clear(object sender, EventArgs e)
    {
        val1 = null;
        val2 = null;
        historyView.Text = "";
        resultView.Text = "0";
    }

    void NumberSelect(object sender, EventArgs e)
    {
        if (sender is not Button button || string.IsNullOrWhiteSpace(button.Text)) 
            return;

        press = button.Text;


        historyView.Text += press;
        resultView.Text = press;

        if (!IsMatch(historyView.Text, @"[^0-9]"))
            val1 += press;
        else
            val2 += press;
    }

    void OperatorSelect(object sender, EventArgs e)
    {
        var button = sender as Button;

        omath = button.Text;
        resultView.Text = omath;
        historyView.Text += omath;
    }

    void Calculate(object sender, EventArgs e)
    {
        historyView.Text = "=" + resultView.Text;

        resultView.Text = Calculator.Calculate(Convert.ToDouble(val1), Convert.ToDouble(val2), omath).ToString();

        historyView.Text = resultView.Text;

        val1 = resultView.Text;
        val2 = "";

    }
}
