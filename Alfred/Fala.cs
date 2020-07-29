using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;

namespace Alfred
{
    public class Fala
    {
        private static SpeechSynthesizer sp = new SpeechSynthesizer();

        public static void falar(String text)
        {
            sp.SpeakAsync(text);
        }
    }
}
