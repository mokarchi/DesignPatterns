using System;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Client passing employee with Role Developer to folderproxy");
            Employee emp1 = new Employee("Anurag", "Anurag123", "Developer");
            SharedFolderProxy folderProxy1 = new SharedFolderProxy(emp1);
            folderProxy1.PerformRWOperations();
            Console.WriteLine();
            Console.WriteLine("Client passing employee with Role Manager to folderproxy");
            Employee emp2 = new Employee("Pranaya", "Pranaya123", "Manager");
            SharedFolderProxy folderProxy2 = new SharedFolderProxy(emp2);
            folderProxy2.PerformRWOperations();
            Console.Read();
        }
    }
}
