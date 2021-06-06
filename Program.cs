using System;
using System.IO;

namespace MakeMusic
{
    class Program
    {
        static void Main(string[] args)
        {
            MakeMusic.Wav(@"C:\Users\clay0\workshop\coding\csharp\week16\Sample\Unity\", "tone.txt", "duration.txt", "Unity.wav", 5);
            /*
            MakeMusic.Wav(@"C:\Users\clay0\workshop\coding\csharp\week16\Sample\Unity\", "tone.txt", "duration.txt", "Unity.wav", 5);
            MakeMusic.Wav(@"C:\Users\clay0\workshop\coding\csharp\week16\Sample\NightOfFire\", "tone.txt", "duration.txt", "NightOfFire.wav", 4);
            MakeMusic.Wav(@"C:\Users\clay0\workshop\coding\csharp\week16\Sample\MagicForest\", "tone.txt", "duration.txt", "out3.wav", 3);
            MakeMusic.Wav(@"C:\Users\clay0\workshop\coding\csharp\week16\Sample\Megalovania\", "tone.txt", "duration.txt", "out2.wav", 2);
            MakeMusic.Wav(@"C:\Users\clay0\workshop\coding\csharp\week16\Sample\Wily'sCastle\", "tone.txt", "duration.txt", "out1.wav", 1);
            MakeMusic.Wav(@"C:\Users\clay0\workshop\coding\csharp\week16\Sample\Dejavu\", "tone.txt", "duration.txt", "out0.wav");
            */
            //Easy();
        }
        public static void Easy()
        {
            string path = @"C:\Users\clay0\workshop\coding\csharp\week16\Sample\Megalovania\";
            string tonesFile = "tone.txt";
            string durationsFile = "duration.txt";
            string[] tones = File.ReadAllText($"{path}{tonesFile}")
                .Replace("\n", "").Replace("\r", "").Split(' ');
            string[] durations = File.ReadAllText($"{path}{durationsFile}")
                .Replace("\n", "").Replace("\r", "").Split(' ');
            int len = tones.Length;
            Console.WriteLine("Megalovania");
            Console.WriteLine("tone | duration");
            for (int i = 0; i < len; i++)
                Console.WriteLine(" {0,-3} | {1,-4}", tones[i], durations[i]);
            Console.ReadLine();
        }
        public static void Medium()
        {
            // Case: File Not found
            MakeMusic.Wav(@"C:\Users\clay0\workshop\coding\csharp\week16\Sample\Dejavu\", "TONE.txt", "DURATION.txt", "out0.wav");

            // Case: Path doesn;t exist
            MakeMusic.Wav(@"C:\Users\clay0\workshop\coding\csharp\week9999\Sample\Wily'sCastle\", "tone.txt", "duration.txt", "out1.wav", 1);

            // Case: Duration and tone are not .txt format.
            MakeMusic.Wav(@"C:\Users\clay0\workshop\coding\csharp\week16\Sample\Megalovania\", "tone.dat", "duration.jpg", "out2.wav", 2);
            
            // Case: Output music file are not .wav format.
            MakeMusic.Wav(@"C:\Users\clay0\workshop\coding\csharp\week16\Sample\MagicForest\", "tone.txt", "duration.txt", "out3.mp3", 3);
        }
        public static void Hard()
        {
            
        }
    }
}
