using System;

namespace OOP4
{
    class Plant
    {
        private string Name;
        private int Size;
        private int TermLive;

        public string name
        {
            get { return Name; }
            set { Name = value; }
        }

        public int size
        {
            get { return Size; }
            set { Size = value; }
        }

        public int termLive
        {
            get { return TermLive; }
            set { TermLive = value; }
        }

        public Plant(string N, int S, int T)
        {
            Name = N;
            Size = S;
            TermLive = T;
        }
    }
}