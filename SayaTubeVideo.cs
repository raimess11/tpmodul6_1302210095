using System;
using System.Collections.Generic;
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
            this.title = title;
            this.id = random.Next(10000,99999);
            int playCount = 0;
        }
        public void IncreasePlayCount(int Count)
        {
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
