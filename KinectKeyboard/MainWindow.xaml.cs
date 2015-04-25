using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using Button = KinectKeyboard.Components.Button;

namespace KinectKeyboard
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();

            this.DataContext = this;

            _qwertyButtons = new ObservableCollection<Components.Button>();

            _qwertyButtons.Add(new Components.Button("Q", 0, 0));
            _qwertyButtons.Add(new Components.Button("W", 0, 1));
            _qwertyButtons.Add(new Components.Button("E", 0, 2));
            _qwertyButtons.Add(new Components.Button("R", 0, 3));
            _qwertyButtons.Add(new Components.Button("T", 0, 4));
            _qwertyButtons.Add(new Components.Button("Y", 0, 5));
            _qwertyButtons.Add(new Components.Button("U", 0, 6));
            _qwertyButtons.Add(new Components.Button("I", 0, 7));
            _qwertyButtons.Add(new Components.Button("O", 0, 8));
            _qwertyButtons.Add(new Components.Button("P", 0, 9));

            _qwertyButtons.Add(new Components.Button("A", 1, 0));
            _qwertyButtons.Add(new Components.Button("S", 1, 1));
            _qwertyButtons.Add(new Components.Button("D", 1, 2));
            _qwertyButtons.Add(new Components.Button("F", 1, 3));
            _qwertyButtons.Add(new Components.Button("G", 1, 4));
            _qwertyButtons.Add(new Components.Button("H", 1, 5));
            _qwertyButtons.Add(new Components.Button("J", 1, 6));
            _qwertyButtons.Add(new Components.Button("K", 1, 7));
            _qwertyButtons.Add(new Components.Button("L", 1, 8));

            _qwertyButtons.Add(new Components.Button("Z", 2, 0));
            _qwertyButtons.Add(new Components.Button("X", 2, 1));
            _qwertyButtons.Add(new Components.Button("C", 2, 2));
            _qwertyButtons.Add(new Components.Button("V", 2, 3));
            _qwertyButtons.Add(new Components.Button("B", 2, 4));
            _qwertyButtons.Add(new Components.Button("N", 2, 5));
            _qwertyButtons.Add(new Components.Button("M", 2, 6));
            //_qwertyButtons.Add(new Components.Button(Key, 1, 3));
            //for (int i = 44; i < 70; i++)
            //{
            //    _qwertyButtons.Add(new Components.Button(((Key)i).ToString(), 1, 3));
            //}
        }

        private ObservableCollection<Components.Button> _qwertyButtons;

        public ObservableCollection<Button> QwertyButtons
        {
            get { return _qwertyButtons; }
        }
    }
}
