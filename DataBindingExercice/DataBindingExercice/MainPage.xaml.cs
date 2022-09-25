using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DataBindingExercice
{
    public partial class MainPage : ContentPage
    {
        public List<string> Items { get; set; }
        public List<Color> colors { get; set; } 
        public int i;
        public MainPage()
        {
            InitializeComponent();
            i = 0;
            colors = new List<Color>() { Color.Red, Color.Green,Color.Blue};
            Items = new List<string>() { "hello","world!", "nothing", "awesone", "donot"};
        }

        private void Button_Clicked(object sender, EventArgs e)
        {   
            if(i >= Items.Count)
            {
                i = 0;
            }
            
            quoteLabel.Text = Items[i].ToString();
            i++;
        }

        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            quoteLabel.TextColor = colors[((int)(e.NewValue))];

        }

        private void sizeSlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            sizeLabel.Text = "FontSize : "+ e.NewValue.ToString();

        }
    }
}
