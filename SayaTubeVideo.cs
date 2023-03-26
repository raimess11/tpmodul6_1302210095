using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul6_1302210095
{
    internal class SayaTubeVideo
    {
        int id;
        string title;
        int playCount;

        Random random = new Random(DateTime.Now.Second);
        public SayaTubeVideo(string title)
        {
            if (title == null)
            {
                throw new invalidTitle("judul tidak boleh null");
            }
            Debug.Assert(
                title != null,
                "title tidak boleh null"
                );

            if (title.Length >= 100)
            {
                throw new invalidTitle("maksima karakter pada title adalah 100 karakter");
            }
            Debug.Assert(
                title.Length < 100,
                "maksima karakter pada title adalah 100 karakter"
                );

            this.title = title;
            this.id = random.Next(10000,99999);
            this.playCount = 0;
        }
        public void IncreasePlayCount(int Count)
        {
            if (Count > 10000000)
            {
                throw new invalidPlayCount("batas penambahan play count adalah 10.000.000");
            }
            Debug.Assert(
                Count <= 10000000,
                "batas penambahan play count adalah 10.000.000"
                );

            try{checked{this.playCount += Count;}}
            catch( OverflowException e ){Console.WriteLine(e.Message);}
            catch( invalidPlayCount e ){Console.WriteLine(e.Message);}

        }
        public void PrintVideoDetails()
        {
            Console.WriteLine(
                    this.title + "\n#" + this.id + 
                    "\ndiputar: " + this.playCount
                );
        }
    }

    [Serializable]
    internal class invalidTitle : Exception
    {
        public invalidTitle()
        {
        }

        public invalidTitle(string? message) : base(message)
        {
        }

        public invalidTitle(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected invalidTitle(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }

    [Serializable]
    internal class invalidPlayCount : Exception
    {
        public invalidPlayCount()
        {
        }

        public invalidPlayCount(string? message) : base(message)
        {
        }

        public invalidPlayCount(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected invalidPlayCount(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
