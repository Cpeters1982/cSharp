using System;
using System.Collections.Generic;
using System.Linq;
using JsonData;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Collections to work with
            List<Artist> Artists = JsonToFile<Artist>.ReadJson();
            List<Group> Groups = JsonToFile<Group>.ReadJson();

            //========================================================
            //Solve all of the prompts below using various LINQ queries
            //========================================================

            //There is only one artist in this collection from Mount Vernon, what is their name and age?

            // Artist FromMtVernon = Artists.Where(artist => artist.Hometown == "Mount Vernon").Single();
            // Console.WriteLine($"{FromMtVernon.ArtistName} is from Mt Vernon and is {FromMtVernon.Age} years old");



            //Who is the youngest artist in our collection of artists?

            // Artist Youngest = Artists.OrderBy(artists => artists.Age).First();
            // System.Console.WriteLine($"The youngest artist from the list is {Youngest.ArtistName}");



            //Display all artists with 'William' somewhere in their real name

            // List<Artist> Williams = Artists.Where(artist => artist.RealName.Contains("William")).ToList();
            // Console.WriteLine("The Following artists have William in their real names:");
            // foreach(var artist in Williams) {
            //     Console.WriteLine(artist.ArtistName + " - " + artist.RealName);
            // }


            //Display all groups with names less than 8 characters in length.

            // List<Group> NameLess = Groups.Where(group => group.GroupName.Length < 8).ToList();
            // System.Console.WriteLine("The following groups have less than 8 characters in their names");
            // foreach(var group in NameLess) {
            //     System.Console.WriteLine(group.GroupName);
            // }


            //Display the 3 oldest artist from Atlanta

            // List<Artist> OldestATL = Artists.Where(artist => artist.Hometown == "Atlanta").OrderByDescending(artist => artist.Age).Take(3).ToList();
            // Console.WriteLine("The three oldest artists from Atlanta are:");
            // foreach(var artist in OldestATL) {
            //     Console.WriteLine(artist.ArtistName + " - " + artist.Age);
            // }


            //(Optional) Display the Group Name of all groups that have members that are not from New York City

            // List<string> NotNy = Artists.Join(Groups, artist => artist.GroupId, group => group.Id, (artist, group) => { artist.Group = group; return artist;}).Where(artist => (artist.Hometown != "New York City" && artist.Group != null)).Select(artist => artist.Group.GroupName).Distinct().ToList();
            // Console.WriteLine("All groups with members not from New York City:");
            // foreach(var group in NotNy){
            //     Console.WriteLine(group);
            // }


            //(Optional) Display the artist names of all members of the group 'Wu-Tang Clan'

            List<Artist> WuTang = Artists.Where(artist => artist.GroupId == 1).ToList();
            System.Console.WriteLine($"The members of the Wu Tang Clan are:");
            foreach(var artist in WuTang) {
                System.Console.WriteLine(artist.ArtistName);
            }
                System.Console.WriteLine("And U-God, and Masta Killa, and Cappadonna");
                System.Console.WriteLine("PROTECT YA NECK. BRING THE MOTHA FUCKIN RUCKUS");
        }
    }
}
