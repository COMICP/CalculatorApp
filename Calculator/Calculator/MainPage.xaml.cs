using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Calculator
{
    public partial class MainPage : ContentPage
    {
        public string answerString = "Calc Demo";
        public MainPage()
        {
            InitializeComponent();
        }
        void Add_Nums(object sender, EventArgs e)
        {
            double firstNum = double.Parse(TopEnt.Text);
            double secondNum = double.Parse(BotEnt.Text);

            topAns.Text = (firstNum + secondNum).ToString();
            
        }
        void Sub_Nums(object sender, EventArgs e)
        {
            double firstNum = double.Parse(TopEnt.Text);
            double secondNum = double.Parse(BotEnt.Text);

            topAns.Text = (firstNum - secondNum).ToString();
        }
        void Div_Nums(object sender, EventArgs e)
        {
            double firstNum = double.Parse(TopEnt.Text);
            double secondNum = double.Parse(BotEnt.Text);

            topAns.Text = (firstNum / secondNum).ToString();
        }
        void Mul_Nums(object sender, EventArgs e)
        {
            double firstNum = double.Parse(TopEnt.Text);
            double secondNum = double.Parse(BotEnt.Text);

            topAns.Text = (firstNum * secondNum).ToString();
        }
    }
}
