﻿using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WPFTestApps
{
    public class ObservableProperty : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName]string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
