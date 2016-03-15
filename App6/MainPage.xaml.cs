using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

//“空白页”项模板在 http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409 上有介绍

namespace App6
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public ObservableCollection<_History> record = new ObservableCollection<_History>();
        public MainPage()
        {
            this.InitializeComponent();
            listView.ItemsSource = record;
            this.SizeChanged += (s, e) =>
              {
                  var state = "VisualState";
                 
                  if(e.NewSize.Width>1000)
                  {
                      state = "VisualState1000";

                  }
                      VisualStateManager.GoToState(this, state, true);
              };
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            record.Insert(0,new _History {History= input.Text.ToString()});
        }
    }
    public class _History
    {
        private string history;

        public string History
        {
            get
            {
                return history;
            }

            set
            {
                history = value;
            }
        }
    }

}
