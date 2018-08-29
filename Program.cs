using System;
using System.Collections.Generic;

namespace nickelback
{
    class Program
    {
        static void Main(string[] args)
        {
            List<(string, string)> goodSongs = new List<(string artist, string title)>();
            HashSet<(string, string)> songs = new HashSet<(string, string)>(){
            ("Nickelback", "Rockstar"),
            ("Nickelback", "You Remind Me"),
            ("Nickelback", "Far Away"),
            ("Nickelback", "Someday"),
            ("Daughtry", "Home"),
            ("3 Doors Down", "One Light"),
            ("Third Eye Blind", "Jumper"),
            };

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
