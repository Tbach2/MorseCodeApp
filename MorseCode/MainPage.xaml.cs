using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MorseCode
{
    public partial class MainPage : ContentPage
    {
        string DotsAndDashes = "";
        public MainPage()
        {
            InitializeComponent();
        }
        void Dot(object sender, System.EventArgs e)
        {
            DotsAndDashes += ".";
            DotsDashes.Text = DotsAndDashes;
        }
        void Dash(object sender, System.EventArgs e)
        {
            DotsAndDashes += "-";
            DotsDashes.Text = DotsAndDashes;
        }
        void Gap(object sender, System.EventArgs e)
        {
            if(string.IsNullOrEmpty(DotsAndDashes))
            {
                Text.Text += " ";
            }
            else
            {
                Text.Text += $"{Morse.MorseCoder(DotsAndDashes)}";
                DotsAndDashes = "";
            }
            
        }
    }
}
