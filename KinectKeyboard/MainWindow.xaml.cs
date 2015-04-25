using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MahApps.Metro.Controls;
using Microsoft.Samples.Kinect.ControlsBasics;
using Button = KinectKeyboard.Components.Button;
using Microsoft.Kinect;
using Microsoft.Kinect.Toolkit;
using Microsoft.Kinect.Toolkit.Controls;

namespace KinectKeyboard
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : INotifyPropertyChanged
    {
        private readonly KinectSensorChooser sensorChooser;

        private ObservableCollection<Components.Button> _qwertyButtons;
        private Components.Button _button;

        private string _text;

        public string Text
        {
            get { return _text; }
            set { SetField(ref _text, value, "Text"); }
        }

        public MainWindow()
        {
            InitializeComponent();

            this.DataContext = this;

            _text = "";

            // initialize the sensor chooser and UI
            this.sensorChooser = new KinectSensorChooser();
            this.sensorChooser.KinectChanged += SensorChooserOnKinectChanged;
            this.sensorChooserUi.KinectSensorChooser = this.sensorChooser;
            this.sensorChooser.Start();

            // Bind the sensor chooser's current sensor to the KinectRegion
            var regionSensorBinding = new Binding("Kinect") { Source = this.sensorChooser };
            BindingOperations.SetBinding(this.kinectRegion, KinectRegion.KinectSensorProperty, regionSensorBinding);

            _qwertyButtons = new ObservableCollection<Components.Button>();

            _qwertyButtons.Add(new Components.Button("q", 0, 0));
            _qwertyButtons.Add(new Components.Button("w", 0, 1));
            _qwertyButtons.Add(new Components.Button("e", 0, 2));
            _qwertyButtons.Add(new Components.Button("r", 0, 3));
            _qwertyButtons.Add(new Components.Button("t", 0, 4));
            _qwertyButtons.Add(new Components.Button("y", 0, 5));
            _qwertyButtons.Add(new Components.Button("u", 0, 6));
            _qwertyButtons.Add(new Components.Button("i", 0, 7));
            _qwertyButtons.Add(new Components.Button("o", 0, 8));
            _qwertyButtons.Add(new Components.Button("p", 0, 9));

            _qwertyButtons.Add(new Components.Button("a", 1, 0));
            _qwertyButtons.Add(new Components.Button("s", 1, 1));
            _qwertyButtons.Add(new Components.Button("d", 1, 2));
            _qwertyButtons.Add(new Components.Button("f", 1, 3));
            _qwertyButtons.Add(new Components.Button("g", 1, 4));
            _qwertyButtons.Add(new Components.Button("h", 1, 5));
            _qwertyButtons.Add(new Components.Button("j", 1, 6));
            _qwertyButtons.Add(new Components.Button("k", 1, 7));
            _qwertyButtons.Add(new Components.Button("l", 1, 8));

            _qwertyButtons.Add(new Components.Button("z", 2, 0));
            _qwertyButtons.Add(new Components.Button("x", 2, 1));
            _qwertyButtons.Add(new Components.Button("c", 2, 2));
            _qwertyButtons.Add(new Components.Button("v", 2, 3));
            _qwertyButtons.Add(new Components.Button("b", 2, 4));
            _qwertyButtons.Add(new Components.Button("n", 2, 5));
            _qwertyButtons.Add(new Components.Button("m", 2, 6));

            _button = new Button("");
        }


        public ObservableCollection<Button> QwertyButtons
        {
            get { return _qwertyButtons; }
        }

        /// <summary>
        /// Called when the KinectSensorChooser gets a new sensor
        /// </summary>
        /// <param name="sender">sender of the event</param>
        /// <param name="args">event arguments</param>
        private static void SensorChooserOnKinectChanged(object sender, KinectChangedEventArgs args)
        {
            if (args.OldSensor != null)
            {
                try
                {
                    args.OldSensor.DepthStream.Range = DepthRange.Default;
                    args.OldSensor.SkeletonStream.EnableTrackingInNearRange = false;
                    args.OldSensor.DepthStream.Disable();
                    args.OldSensor.SkeletonStream.Disable();
                }
                catch (InvalidOperationException)
                {
                    // KinectSensor might enter an invalid state while enabling/disabling streams or stream features.
                    // E.g.: sensor might be abruptly unplugged.
                }
            }

            if (args.NewSensor != null)
            {
                try
                {
                    args.NewSensor.DepthStream.Enable(DepthImageFormat.Resolution640x480Fps30);
                    args.NewSensor.SkeletonStream.Enable();

                    try
                    {
                        args.NewSensor.DepthStream.Range = DepthRange.Near;
                        args.NewSensor.SkeletonStream.EnableTrackingInNearRange = true;
                    }
                    catch (InvalidOperationException)
                    {
                        // Non Kinect for Windows devices do not support Near mode, so reset back to default mode.
                        args.NewSensor.DepthStream.Range = DepthRange.Default;
                        args.NewSensor.SkeletonStream.EnableTrackingInNearRange = false;
                    }
                }
                catch (InvalidOperationException)
                {
                    // KinectSensor might enter an invalid state while enabling/disabling streams or stream features.
                    // E.g.: sensor might be abruptly unplugged.
                }
            }
        }

        /// <summary>
        /// Handle a button click from the wrap panel.
        /// </summary>
        /// <param name="sender">Event sender</param>
        /// <param name="e">Event arguments</param>
        private void KinectTileButtonClick(object sender, RoutedEventArgs e)
        {
            if (e == null) return;
            
            var button = (KinectTileButton)e.OriginalSource;
            var obj = button.GetChildObjects();

            foreach (var v in obj)
            {
                if (v is TextBlock)
                {
                    Text += (v as TextBlock).Text;
                } 
            }
            e.Handled = true;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
        protected bool SetField<T>(ref T field, T value, string propertyName)
        {
            if (EqualityComparer<T>.Default.Equals(field, value)) return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
    }
}
