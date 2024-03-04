using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    internal class PushDownMethod
    {
        public void Example()
        {
            Music music = new Music(120, "Alo");
            Audio audio = new Audio(120);
            audio.GetLyrics();
        }

        public void RefactoredExample()
        {
            RefactoredMusic music = new RefactoredMusic(120, "Alo");
            RefactoredAudio audio = new RefactoredAudio(120);
            music.GetLyrics();
        }
    }

    //<----------- Ex 3 ----------->

    // Push Down Method

    class Sound
    {
        public int audioLength;
        public string lyrics;

        public Sound(int audioLength, string lyrics = "")
        {
            this.audioLength = audioLength;
            this.lyrics = lyrics;
        }

        public string GetLyrics()
        {
            return lyrics;
        }
    }

    class Music : Sound
    {
        public Music(int audioLength, string lyrics) : base(audioLength, lyrics)
        {
            Console.WriteLine("Audio Length: " + this.audioLength + " Lyrics: " + this.lyrics);
        }
    }

    class Audio : Sound
    {
        public Audio(int audioLength) : base(audioLength)
        {
            Console.WriteLine("Audio Length: " + this.audioLength + " Lyrics: " + this.lyrics);
        }
    }

    //<----------- Refactored ----------->

    class RefactoredSound
    {
        public int audioLength;


        public RefactoredSound(int audioLength)
        {
            this.audioLength = audioLength;
        }
    }

    class RefactoredMusic : RefactoredSound
    {
        public string lyrics;

        public RefactoredMusic(int audioLength, string lyrics) : base(audioLength)
        {
            Console.WriteLine("Audio Length: " + this.audioLength + " Lyrics: " + this.lyrics);
        }

        public string GetLyrics()
        {
            return lyrics;
        }
    }

    class RefactoredAudio : RefactoredSound
    {
        public RefactoredAudio(int audioLength) : base(audioLength)
        {
            Console.WriteLine("Audio Length: " + this.audioLength);
        }
    }
}
