using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading;


namespace WPFTestApps
{
    public class MyApplicationContext : ObservableProperty
    {
        private string myInputText;

        public string ApplicationName { get; set; }

        public bool IsProduction { get; set; }

        public int ConcurrentUserCount { get; set; }

        public string MyInputText
        {
            get => myInputText;
            set
            {
                myInputText = value;
                Debug.WriteLine($"MyInputText changed to: {myInputText}");
                OnPropertyChanged();
            }
        }

        public string Version
        {
            get; set;
        }

        private Thread updateThread;

        

        public MyApplicationContext()
        {
            this.ApplicationName = "WPF Test Application";
            this.IsProduction = false;
            this.Version = "1.0.0"; // Default version, can be changed later
            this.ConcurrentUserCount = 10;
            this.MyInputText = "Default Text";

            updateThread = new Thread(new ThreadStart(UpdateMyValue));
            updateThread.Start();
        }

        private void UpdateMyValue()
        {
            Thread.Sleep(10000);
            this.MyInputText = "Updated after 10 ms";
        }
    }

}
