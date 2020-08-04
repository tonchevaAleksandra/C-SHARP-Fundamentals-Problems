using System;
using System.Collections.Generic;
using System.Linq;


namespace Songs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberSongs = int.Parse(Console.ReadLine());
            List<Songs> songs = new List<Songs>();

            for (int i = 0; i < numberSongs; i++)
            {
                string[] currSong = Console.ReadLine().Split("_");
                string type = currSong[0];
                string name = currSong[1];
                string time = currSong[2];
                Songs song = new Songs();
                song.TypeList = type;
                song.Name = name;
                song.Time = time;
                songs.Add(song);
               
            }

            string typeList = Console.ReadLine();
            if (typeList == "all")
            {
                foreach (Songs song in songs)
                {
                    Console.WriteLine(song.Name);
                }
            }
            //else
            //{
            //    foreach (Songs song in songs)
            //    {
            //        if (typeList == song.TypeList)
            //        {
            //            Console.WriteLine(song.Name);
            //        }
            //    }

            //}

            else
            {
                List<Songs> filteredSongs = songs.Where(s => s.TypeList == typeList).ToList();

                foreach (Songs song in filteredSongs)
                {
                    Console.WriteLine(song.Name);
                } 
            }
        }

        class Songs
        {
            public string TypeList { get; set; }
            public string Name { get; set; }
            public string Time { get; set; }
        }
    }
}
