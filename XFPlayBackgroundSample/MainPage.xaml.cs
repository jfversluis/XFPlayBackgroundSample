using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.CommunityToolkit.UI.Views;

namespace XFPlayBackgroundSample
{
    public class StartMessage { }
    public class PauseMessage { }
    public class StopMessage { }

    public partial class MainPage : ContentPage
    {
        
        public MainPage()
        {
            InitializeComponent();
        }

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            DependencyService.Get<IAudioPlayerService>().Play();
            //MessagingCenter.Send(new StartMessage(), "start");
        }

        void Button_Clicked_1(System.Object sender, System.EventArgs e)
        {
            DependencyService.Get<IAudioPlayerService>().Pause();

            //MessagingCenter.Send(new PauseMessage(), "pause");

        }

        void Button_Clicked_2(System.Object sender, System.EventArgs e)
        {
            DependencyService.Get<IAudioPlayerService>().Stop();

            //MessagingCenter.Send(new StopMessage(), "stop");
        }
    }
}
