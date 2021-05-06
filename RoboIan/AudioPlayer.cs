using System.Media;

namespace RoboIan
{
    public class AudioPlayer
    {
        public static void PlayPhrase(string filepath)
        {
            try
            {
                SoundPlayer soundPlayer = new SoundPlayer(filepath);
                soundPlayer.Play();
            }
            catch { }
        }
    }
}
