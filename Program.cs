using System;
using System.Collections.Generic;

namespace nickelback
{
    class Program
    {
        static void Main(string[] args)
        {
            List<(string, string)> goodSongs = new List<(string artist, string title)>();
            HashSet<(string, string)> songs = new HashSet<(string, string)>();
            songs.Add (("Nickelback", "Rockstar"));
            songs.Add (("Nickelback", "You Remind Me"));
            songs.Add (("Nickelback", "Far Away"));
            songs.Add (("Nickelback", "Someday"));
            songs.Add (("Daughtry", "Home"));
            songs.Add (("3 Doors Down", "One Light"));
            songs.Add (("Third Eye Blind", "Jumper"));

            foreach (var song in songs)
            {
                if (song.Item1 != "Nickelback"){
                    goodSongs.Add(song);
                } 

            }

            foreach (var thing in goodSongs) {
                Console.WriteLine(thing);
            }

            
        }}}
