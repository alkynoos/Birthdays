using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BerthDays
{
    class Program
    {

        static void Main(string[] args)
        {
            // edw tha iparxoun auta --- toulaxiston 4 me 5 methodes


            int numOfFriends = 5;
            string[] firstNames = new string[numOfFriends];
            string[] lastNames = new string[numOfFriends];
            string[] telephones = new string[numOfFriends];
            string[] datesOfBirth = new string[numOfFriends];


            LoopToGetDate(numOfFriends, firstNames, lastNames, telephones, datesOfBirth);

        }


        static void DisplayInfoToScreen(int i)
        {
            string end = "";
            int friend = i;

            if (friend == 1)
            {
                end = "st";
            }
            else if (friend == 2)
            {
                end = "nd";
            }
            else if (friend == 3)
            {
                end = "rd";
            }
            else
            {
                end = "th";
            }


            Console.WriteLine("Data for " + i + end + " friend.");
        }

        static void AskUserDetails(string message, string[] array, int i)
        {
            Console.Write("Give my you " + message);
            array[i -1] = Console.ReadLine();
        }

        //static void PrintData(int i, string[] firstNames, string[] lastNames, string[] telephones, string[] datesOfBirth)
        //{
        //    Console.WriteLine("First name: {0}, Last Name: {1}, Telephone: {3}, Date of Berth: {4}", firstNames[i - 1], lastNames[i - 1], telephones[i - 1], datesOfBirth[i - 1]);
        //}

        static void LoopToGetDate(int numOfFriends, string[] firstNames, string[] lastNames, string[] telephones, string[] datesOfBirth)
        {


            for (int i = 1; i <= numOfFriends; i++)
            {                
                DisplayInfoToScreen(i);

                AskUserDetails("first name: ", firstNames, i);

                AskUserDetails("last name: ", lastNames, i);

                AskUserDetails("telephone: ", telephones, i);

                AskUserDetails("date of berth: ", datesOfBirth, i);
                //PrintData(i, firstNames, lastNames, telephones, datesOfBirth);
                //Console.WriteLine($"First name: {firstNames[i]}, Last Name: {lastNames[i]}, Telephone: , Date of Berth: " /*, telephones[i], datesOfBirth[i]*/);
            }
        }
    }
}
