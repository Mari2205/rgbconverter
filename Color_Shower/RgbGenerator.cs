using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Color_Shower
{

    public class RgbGeneratedEventArgs : EventArgs
    {
        public Rgb GeneratedColor;

        public RgbGeneratedEventArgs(Rgb generatedColor)
        {
            this.GeneratedColor = generatedColor;
        }
    }

    public class RgbGenerator
    {
        private static Random _random = new Random();
        private bool _shouldGenerate = true;
        private Thread _generateThread;

        public event EventHandler<RgbGeneratedEventArgs> RgbGenerated;

        public RgbGenerator()
        {
            this._generateThread = new Thread(KeepGenerating);

            _generateThread.Name = "GeneratingThread";

            _generateThread.Start();

        }




        public bool ShouldGenerate
        {
            get { return _shouldGenerate; }
            set { _shouldGenerate = value; }
        }


        public Rgb Generate()
        {

            return new Rgb()
            {
                Red = _random.Next(0,256),
                Blue = _random.Next(0,256),
                Green = _random.Next(0,256)
            };

        }

        public void KeepGenerating()
        {
            while (_shouldGenerate)
            {
                Rgb generated = Generate();
                RgbGenerated?.Invoke(this, new RgbGeneratedEventArgs(generated));

                Thread.Sleep(TimeSpan.FromSeconds(5));
            }
        }

    }
}
