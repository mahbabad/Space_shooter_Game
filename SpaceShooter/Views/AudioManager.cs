using System;
using System.Collections.Generic;
using System.IO;
using System.Media;
using System.Text;
using System.Windows.Media;

namespace SpaceShooter.Views
{
    public static class AudioManager
    {
        static MediaPlayer backMusic;
        static MediaPlayer boombMusic;
        static MediaPlayer shieldMusic;
        static MediaPlayer coinMusic;
        static SoundPlayer soundplayer;
        
        static bool _isMusicMuted;
        static bool _isSfxMuted;
        public static bool IsMusicMuted
        {
            get { return _isMusicMuted; }
            set 
            { 
                _isMusicMuted = value;
                if (backMusic != null)
                {
                    backMusic.IsMuted = value;
                }
            }
        }
        public static bool IsSfxMuted
        { 
            get { return _isSfxMuted; } 
            set 
            {
                _isSfxMuted = value;
                if (boombMusic != null)
                {
                    boombMusic.IsMuted = value;
                }
                if (value && soundplayer != null)
                {
                    soundplayer.Stop(); 
                }
            } 
        }
        static AudioManager()
        {
            IsMusicMuted = false;
            IsSfxMuted = false;
            backMusic = new MediaPlayer();
            boombMusic = new MediaPlayer();
            soundplayer = new SoundPlayer();
            coinMusic = new MediaPlayer();
            shieldMusic = new MediaPlayer();
        }
        public static void PlayBackMusic(Stream music, string filename)
        {
            //if (IsMusicMuted)
            //    return;

            backMusic.Close();
            string tempPath = Path.Combine(Path.GetTempPath(), filename);
            if (!File.Exists(tempPath))
            {
                using (FileStream file = new FileStream(tempPath, FileMode.Create, FileAccess.Write))
                {
                    music.CopyTo(file);
                }
            }

            backMusic.Open(new Uri(tempPath));
            backMusic.IsMuted = IsMusicMuted;
            backMusic.Play();

            backMusic.MediaEnded += (s, e) =>
            {
                backMusic.Position = TimeSpan.Zero;
                backMusic.Play();
            };
        }
        public static void StopBackMusic()
        {
            backMusic.Stop();
            backMusic.Close();
        }
        public static void PlayBoombMusic(Stream music, string fileName)
        {
            if (IsSfxMuted)
                return;

            string tempPath = Path.Combine(Path.GetTempPath(), fileName);
            if (!File.Exists(tempPath))
            {
                using (FileStream file = new FileStream(tempPath, FileMode.Create, FileAccess.Write))
                {
                    music.CopyTo(file);
                }
            }
            boombMusic.Open(new Uri(tempPath));
            boombMusic.Play();
        }
        public static void PlayShieldMusic(Stream music, string fileName)
        {
            if (IsSfxMuted)
                return;

            string tempPath = Path.Combine(Path.GetTempPath(), fileName);
            if (!File.Exists(tempPath))
            {
                using (FileStream file = new FileStream(tempPath, FileMode.Create, FileAccess.Write))
                {
                    music.CopyTo(file);
                }
            }
            shieldMusic.Open(new Uri(tempPath));
            shieldMusic.Play();
        }
        public static void CoinPlayer(Stream music, string filename)
        {
            if (IsSfxMuted)
                return;

            string tempPath = Path.Combine(Path.GetTempPath(), filename);
            if (!File.Exists(tempPath))
            {
                using (FileStream file = new FileStream(tempPath, FileMode.Create, FileAccess.Write))
                {
                    music.CopyTo(file);
                }
            }
            coinMusic.Open(new Uri(tempPath));
            coinMusic.Play();
        }
        
        
        public static void PlaySfx(Stream sfx)
        {
            if (IsSfxMuted)
                return;

            soundplayer.Stream = sfx;
            soundplayer.Play();
        }
    }
}
