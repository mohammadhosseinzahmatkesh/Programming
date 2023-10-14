using System;

namespace ConsoleApp1
{
    internal class Param
    {
        internal string name;
        internal string model;

        public string Manu { get; internal set; }

        public static implicit operator Param(string v)
        {
            throw new NotImplementedException();
        }
    }
}