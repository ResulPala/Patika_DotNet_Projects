using System;
using System.Collections.Generic;

namespace phonebook
{
    class contacts    {
        private string name;

        private string surname;

        private long number;

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public long Number { get => number; set => number = value; }
    }
}