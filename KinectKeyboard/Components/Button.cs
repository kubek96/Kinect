using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Media;

namespace KinectKeyboard.Components
{
    public class Button : INotifyPropertyChanged
    {
        private string _buttonLabel;
        private Color _color;
        private int _column;
        private int _row;

        public Button(string buttonLabel, int row, int column)
        {
            _buttonLabel = buttonLabel;
            _row = row;
            _column = column;
        }

        public Color Color
        {
            get { return _color; }
            set { SetField(ref _color, value, "Color"); }
        }

        public string ButtonLabel
        {
            get { return _buttonLabel; }
            set { SetField(ref _buttonLabel, value, "ButtonLabel"); }
        }

        public int Column
        {
            get { return _column; }
        }

        public int Row
        {
            get { return _row; }
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