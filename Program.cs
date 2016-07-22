using System;

namespace XMSquish
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Squisher squisher = new Squisher();
            squisher.Squish(args[0]);
        }
    }
}
