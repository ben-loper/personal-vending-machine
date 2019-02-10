using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace VendingMachine.Utility
{
    public class Sound
    {
        public static void PlaySound(string fileName)
        {
            string path = $@"C:\workspace\team\week-4-pair-exercises-c-team-4\19_Capstone\dotnet\etc\{fileName}";

            Process.Start(@"powershell", $@"-c (New-Object Media.SoundPlayer '{path}').PlaySync();");
        }
    }
}
