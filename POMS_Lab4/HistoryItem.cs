using System;
using System.Collections.Generic;
using System.Text;
using POMS_Lab4.RESX;

namespace POMS_Lab4
{
    public class HistoryItem
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public override string ToString()
        {
            return $"{Resource.entryNamePlaceholder}:{Name} {Resource.entrySurnamePlaceholder}:{Surname} {Resource.age}:{Age}";
        }
        public HistoryItem(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }
    }
}
