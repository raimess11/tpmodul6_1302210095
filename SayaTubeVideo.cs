using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
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
            Debug.Assert(
                title != null,
                "title tidak boleh null"
                );
            Debug.Assert(
                title.Length < 100,
                "maksima karakter pada title adalah 100 karakter"
                );

            this.title = title;
            this.id = random.Next(10000,99999);
            int playCount = 0;
        }
        public void IncreasePlayCount(int Count)
        {
            Debug.Assert(
                Count <= 10000000,
                "batas penambahan play count adalah 10.000.000"
                );

            try{checked{playCount += Count;}}
            catch( OverflowException e ){Console.WriteLine(e.Message);}

            this.playCount += Count;
        }
        public void PrintVideoDetails()
        {
            Console.WriteLine(
                    this.title + "\n#" + this.id + 
                    "\ndiputar: " + this.playCount
                );
        }
    }
}
