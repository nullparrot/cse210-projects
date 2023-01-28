using System;

class Program
{
    static void Main(string[] args)
    {
        Journal myjournal = new Journal();
        myjournal.NewEntry();
        myjournal.Display();
    }
}