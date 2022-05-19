using System;
namespace DynamicSorting
{
    // simple object
    public class Nation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ISOCode { get; set; }
    }


    // complex object
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string DisplayName { get; set; }

        public Nation Nation { get; set; }
    }
}
