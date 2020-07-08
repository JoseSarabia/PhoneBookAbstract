using System;
namespace PhoneBookAbstract
{
    static class Record
    {
        static int counter = 0;
        public static string CreateRecord(int id, string name, string number)
        {
            counter++;
            return id + "-" + " " + name + " " + number ;
        }
    }
}
