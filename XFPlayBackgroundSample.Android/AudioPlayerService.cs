using System;
using Android.Content;
using Xamarin.Essentials;
using Xamarin.Forms;
using XFPlayBackgroundSample.Droid;

[assembly: Dependency(typeof(AudioPlayerService))]
namespace XFPlayBackgroundSample.Droid
{
    public class AudioPlayerService : IAudioPlayerService
    {
        public void Pause()
        {
            SendAudioCommand(StreamingBackgroundService.ActionPause);

        }

        public void Play()
        {
            SendAudioCommand(StreamingBackgroundService.ActionPlay);

        }

        public void Stop()
        {
            SendAudioCommand(StreamingBackgroundService.ActionStop);

        }

        private void SendAudioCommand(string action)
        {
            var intent = new Intent(action);
            intent.SetPackage(Platform.CurrentActivity.ApplicationContext.PackageName);
            if (Android.OS.Build.VERSION.SdkInt >= Android.OS.BuildVersionCodes.O)
            {
                Platform.CurrentActivity.StartForegroundService(intent);
            }
            else
            {
                Platform.CurrentActivity.StartService(intent);
            }
        }
    }
}
