﻿using AddressBookSystem;
using System;

namespace AddressBooksystem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program");

            bool check = true;

            while (check)
            {
                Console.WriteLine("Please select the Options :\n" +
                    "1)Enter Details to add Contact in List\n");

                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:

                        AddressBook addobj = new AddressBook();
                        addobj.createContact();
                        break;

                    default:
                        Console.WriteLine("Please select proper option");
                        break;
                }
                check = false;
                break;
            }
        }
    }

}