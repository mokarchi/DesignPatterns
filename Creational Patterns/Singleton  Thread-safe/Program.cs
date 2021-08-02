﻿using System;
using System.Threading.Tasks;

namespace Singleton__Thread_safe
{
    class Program
    {
        static void Main(string[] args)
        {
            Parallel.Invoke(
                () => PrintTeacherDetails(),
                () => PrintStudentdetails()
                );
            Console.ReadLine();
        }

        private static void PrintTeacherDetails()
        {
            Singleton fromTeacher = Singleton.GetInstance;
            fromTeacher.PrintDetails("From Teacher");
        }
        private static void PrintStudentdetails()
        {
            Singleton fromStudent = Singleton.GetInstance;
            fromStudent.PrintDetails("From Student");
        }
    }
}
