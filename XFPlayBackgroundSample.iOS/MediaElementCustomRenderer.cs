using Xamarin.CommunityToolkit.UI.Views;
using XFPlayBackgroundSample.iOS;

[assembly: Xamarin.Forms.ExportRenderer(typeof(MediaElement), typeof(MediaElementCustomRenderer))]
namespace XFPlayBackgroundSample.iOS
{
    public class MediaElementCustomRenderer : MediaElementRenderer
    {
        public MediaElementCustomRenderer()
        {
            //avPlayerViewController.UpdatesNowPlayingInfoCenter = false;
        }
    }
}
