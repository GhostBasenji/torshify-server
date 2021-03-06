using System;

using Torshify.Origo.Contracts.V1;

namespace Torshify.Origo.Interfaces
{
    public interface IMusicPlayerController
    {
        #region Events

        event EventHandler CurrentTrackChanged;

        event EventHandler TrackComplete;

        event EventHandler ElapsedChanged;

        event EventHandler IsPlayingChanged;

        event EventHandler VolumeChanged;

        #endregion Events

        #region Properties

        Track CurrentTrack
        {
            get;
        }

        TimeSpan Elapsed
        {
            get;
        }

        bool IsPlaying
        {
            get;
        }

        float Volume
        {
            get; 
            set;
        }

        #endregion Properties

        #region Methods

        void Play(string trackId);

        void TogglePause();

        void Seek(TimeSpan timeSpan);

        #endregion Methods
    }
}