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
        static bool IsMusicMuted { get; set; }
        static bool IsSfxMuted { get; set; }
        static AudioManager()
        {
            IsMusicMuted = false;
            IsSfxMuted = false;
            backMusic = new MediaPlayer();
            boombMusic = new MediaPlayer();
        }
        public static void PlayBackMusic(Stream music, string filename)
        {
            if (IsMusicMuted)
                return;
            backMusic.Close();
            string tempPath = Path.Combine(Path.GetTempPath(), filename);
            using (FileStream file = new FileStream(tempPath, FileMode.Create, FileAccess.Write))
            {
                music.CopyTo(file);
            }

            backMusic.Open(new Uri(tempPath));
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
            using (FileStream file = new FileStream(tempPath, FileMode.Create, FileAccess.Write))
            {
                music.CopyTo(file);
            }

            boombMusic.Open(new Uri(tempPath));
            boombMusic.Play();
        }
        public static void PlaySfx(Stream sfx)
        {
            if (IsSfxMuted)
                return;

            SoundPlayer sp = new SoundPlayer(sfx);
            sp.Play();
        }
    }
}
