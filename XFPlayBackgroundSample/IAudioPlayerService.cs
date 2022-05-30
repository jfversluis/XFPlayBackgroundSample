using System;
namespace XFPlayBackgroundSample
{
    public interface IAudioPlayerService
    {
        void Play();

        void Pause();

        void Stop();
    }
}
