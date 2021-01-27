using System;
using System.Collections.Generic;

namespace MyList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> jobs = new List<string>();
            jobs.Add("Engineer");
            Console.WriteLine(jobs.Count);
            ThisListMyList<string> experience = new ThisListMyList<string>();
            experience.Add("Intern position ");
            Console.WriteLine(experience.Count);
            
        }
    }
    class ThisListMyList<T>
    {
        T[] _mylist;
        T[] _tempArray;
        public ThisListMyList()
        {
            _mylist = new T[0];
        }
        public void Add(T item)
        {
            _tempArray = _mylist;
            _mylist = new T[_mylist.Length + 1];
            for (int i = 0; i < _tempArray.Length; i++)
            {
                _mylist[i] = _tempArray[i];
            }
            _mylist[_mylist.Length - 1] = item;
        }
        public int Count 
        {
            get { return _mylist.Length; }
        }
    }
}
