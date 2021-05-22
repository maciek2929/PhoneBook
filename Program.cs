using System;
using PhoneBook.Components;

namespace PhoneBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Contact maciek = new Contact("Maciek", "Opozda", "531-256-638646546465465456465456");
            maciek.contactInformation = "czesto dzwoni ";




            Console.Write($" name : {maciek.Name} surname :{maciek.Surname} and phone number is {maciek.GetPhoneNumber()} and your note about this contact is {maciek.contactInformation} ");



        }
    }
}
