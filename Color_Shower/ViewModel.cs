using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Input;

namespace Color_Shower
{
    
    public class ViewModel : INotifyPropertyChanged
    {
        private Rgb currentColor;

        private ICommand _resetCommand;

        private RgbGenerator _rgbGenerator;

    

        public ICommand ResetCommand
        {
            get { return _resetCommand; }
            set { _resetCommand = value; }
        }


        public Rgb CurrentColor
        {
            get { return currentColor; }
            set { currentColor = value;
                OnPropertyChanged("CurrentColor"); }
        }
        private double red;

        public double Red
        {
            get { return red; }
            set { red = value;
                CurrentColor = new Rgb() { Red = this.Red, Green = this.Green, Blue = this.Blue };
                OnPropertyChanged("Red");
            }
        }
        private double green;

        public double Green
        {
            get { return green; }
            set { green = value;
                CurrentColor = new Rgb() { Red = this.Red, Green = this.Green, Blue = this.Blue };
                OnPropertyChanged("Green");
            }
        }
        private double blue;

        public double Blue
        {
            get { return blue; }
            set { blue = value;
                CurrentColor = new Rgb() { Red = this.Red, Green = this.Green, Blue = this.Blue };
                OnPropertyChanged("Blue");
            }
        }

        public void OnPropertyChanged(string s)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(s));
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public ViewModel()
        {
            CurrentColor = new Rgb() {Red = 50, Green = 50, Blue = 50 };
            ResetCommand = new DelegateCommand(Reset);
            this._rgbGenerator = new RgbGenerator();

            this._rgbGenerator.RgbGenerated += OnColorGenerated;

        }

        private void OnColorGenerated(object sender, RgbGeneratedEventArgs genArgs)
        {
            CurrentColor = genArgs.GeneratedColor;
        }

        private void Reset(object args)
        {
            CurrentColor = new Rgb(){Red = 0, Blue = 0, Green = 0};
            this.Red = this.Blue = this.Green = 0;

        }
    }
}
