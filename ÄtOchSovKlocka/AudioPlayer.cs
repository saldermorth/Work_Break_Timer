using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace ÄtOchSovKlocka
{
    public class AudioPlayer
    {
        public static void PlaySound(int select)
        {

            SoundPlayer player = new SoundPlayer();
            
           
            if (select == 1)
            {
                player.SoundLocation = @"C:\Users\Nere\source\repos\timer\ÄtOchSovKlocka\alarms\1.wav";
            }
            else if (select == 2)
            {
                player.SoundLocation = @"C:\Users\Nere\source\repos\timer\ÄtOchSovKlocka\alarms\2.wav";
            }
            else
            {
                player.SoundLocation = @"C:\Users\Nere\source\repos\timer\ÄtOchSovKlocka\alarms\3.wav";
            }


            player.Load();
            player.Play();
        }
        
    }
}