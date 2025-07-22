using System.Diagnostics;

namespace WPFTestApps
{
    public class MyApplicationContext
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
            }
        }

        public string Version
        {
            get; set;
        }

        public MyApplicationContext()
        {
            this.ApplicationName = "WPF Test Application";
            this.IsProduction = false;
            this.Version = "1.0.0"; // Default version, can be changed later
            this.ConcurrentUserCount = 10;
            this.MyInputText = "Default Text";
        }
    }
}
