using System;
using System.Collections.Generic;
using System.Linq;
using ResourceServer.Domain.Helpers;

namespace DynamicSorting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }



        static void SortingSimpleObject()
        {
            var nations = new List<Nation>();

            var sortedByNameAsc = nations.Sorting("Name", true);
            var sortedByNameDesc = nations.Sorting("Name", false);
        }


        static void SoritingComplexObject()
        {
            var users = new List<User>();

            var sortedByNationId = users.AsQueryable().OrderBy("Nation.Id DESC").ToList();
            var sortedByNationName = users.AsQueryable().OrderBy("Nation.Name ASC").ToList();

            
            var combineSorting = users.AsQueryable().OrderBy("FirstName ASC, Nation.ISOCode DESC").ToList();
        }

    }
}
