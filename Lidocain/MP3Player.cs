using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.InteropServices;

namespace Lidocain
{ 

    class MP3Player : IDisposable
    {
        public bool Repeat { get; set; }
        public string mediaFile { get; set; }

        public MP3Player(string fileName)
        {
            mediaFile = fileName;
        }

        public MP3Player()
        {

        }

        public void Load(string fileName)
        {
            const string FORMAT = @"open ""{0}"" type mpegvideo alias MediaFile";
            string command = string.Format(FORMAT, fileName);
            mciSendString(command, null, 0, IntPtr.Zero);
        }

        public void Play()
        {
            string command = "play MediaFile";
            if (Repeat)
                command += " REPEAT";
            mciSendString(command, null, 0, IntPtr.Zero);
            
        }


        public void Stop()
        {
            string command = "stop MediaFile";
            mciSendString(command, null, 0, IntPtr.Zero);
        }

        public void Dispose()
        {
            string command = "close MediaFile";
            mciSendString(command, null, 0, IntPtr.Zero);
        }

        [DllImport("winmm.dll")]
        private static extern long mciSendString(string strCommand, StringBuilder strReturn, int iReturnLength, IntPtr hwndCallback);
    }
}
