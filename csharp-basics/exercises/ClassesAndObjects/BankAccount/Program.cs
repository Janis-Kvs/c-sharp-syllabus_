using System;


namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            Account benson = new Account("Benson", -17.23m);
            Console.WriteLine(benson.ShowUserNameAndBalance());
            Console.ReadKey();
        }
    }
}
