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
