using NAudio.Wave;
using System;
using System.IO;
using System.Net;
using System.Security.Cryptography;
using System.Text;

namespace ttsGenerator
{
    public class Generate
    {
        public void tts(string text, string lang, bool writeWav, bool useCache, string mp3Path, string wavPath, string fileName_)
        {
            if (text.Length > 0)
            {
                try
                {
                    if (lang.Length <= 0)
                    {
                        lang = "en";
                    }

                    string fileName = GetMd5Hash(text);
                    if (fileName_.Length > 0)
                        fileName = fileName_;

                    bool exists;

                    exists = System.IO.Directory.Exists(mp3Path);
                    if (!exists)
                        System.IO.Directory.CreateDirectory(mp3Path);

                    exists = System.IO.Directory.Exists(wavPath);
                    if (!exists)
                        System.IO.Directory.CreateDirectory(wavPath);

                    string mp3FileName = mp3Path + fileName + ".mp3";
                    string wavFileName = wavPath + fileName + ".wav";

                    if (!useCache)
                    {
                        dowloadVoice(text, lang, mp3FileName);
                    }
                    else
                    {
                        if (!File.Exists(mp3FileName))
                            dowloadVoice(text, lang, mp3FileName);
                    }

                    if (writeWav)
                    {
                        if (!useCache)
                        {
                            MP3ToWave(mp3FileName, wavFileName);
                        }
                        else
                        {
                            if (!File.Exists(wavFileName))
                                MP3ToWave(mp3FileName, wavFileName);
                        }
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
            else
            {
            }
        }

        private void dowloadVoice(string text, string lang, string mp3FileName)
        {
            WebClient wb = new WebClient();
            Console.WriteLine("Webclient created");
            Generate TokenMaker = new Generate();
            Console.WriteLine("Token generator created");
            string token = TokenMaker.MakeToken(text);
            Console.WriteLine("Token: " + token);

            string URL = "https://translate.google.com/translate_tts?ie=UTF-8&q=" + text + "&tl=" + lang + "&total=" + text + "&idx=0&textlen=" + text.Length + "&client=tw-ob&tk=" + token + "&prev=input";
            Console.WriteLine(URL);
            Console.WriteLine("Download started");
            wb.DownloadFile(URL, mp3FileName);

            wb.Dispose();

            Console.WriteLine("MP3 Lame File Created");
        }

        public string MakeToken(string text)
        {
            int time = ((int)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds) / 3600;
            char[] chars = Encoding.UTF8.GetString(Encoding.UTF8.GetBytes(text)).ToCharArray();
            long stamp = time;

            foreach (int ch in chars)
            {
                stamp = (long)MakeRl((stamp + ch), "+-a^+6");
            }

            stamp = (long)MakeRl(stamp, "+-3^+b+-f");

            if (stamp < 0)
            {
                stamp = (long)((stamp & 2147483647) + 2147483648);
            }

            stamp = stamp % long.Parse((Math.Pow(10.00, 6.00)).ToString());

            return stamp + "." + (stamp ^ time);
        }

        private long MakeRl(long num, string str)
        {
            for (int i = 0; i < str.Length - 2; i += 3)
            {
                string d = str.Substring(i + 2, 1);

                if (Encoding.ASCII.GetBytes(d.ToString())[0] >= Encoding.ASCII.GetBytes("a")[0])
                {
                    d = (Encoding.ASCII.GetBytes(d.ToString())[0] - 87).ToString();
                }
                else
                {
                    d = long.Parse(d).ToString();
                }

                if (str.Substring(i + 1, 1) == "+")
                {
                    d = (num >> Int32.Parse(d)).ToString();
                }
                else
                {
                    d = (num << Int32.Parse(d)).ToString();
                }

                if (str.Substring(i, 1) == "+")
                {
                    num = num + long.Parse(d) & 4294967295;
                }
                else
                {
                    num = num ^ long.Parse(d);
                }
            }
            return num;
        }

        public string GetMd5Hash(string input)
        {
            StringBuilder sBuilder = new StringBuilder();
            using (MD5 md5Hash = MD5.Create())
            {
                byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

                for (int i = 0; i < data.Length; i++)
                {
                    sBuilder.Append(data[i].ToString("x2"));
                }
            }
            return sBuilder.ToString();
        }

        private void MP3ToWave(string mp3FileName, string waveFileName)
        {
            using (var reader = new Mp3FileReader(mp3FileName))
            using (var writer = new WaveFileWriter(waveFileName, reader.WaveFormat))
                reader.CopyTo(writer);
        }
    }
}