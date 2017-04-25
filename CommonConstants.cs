using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PathLab
{
    public static class CommonConstants
    {
        public const string Male = "M";
        public const string FeMale = "F";
        public const string MaleText = "Male";
        public const string FeMaleText = "Female";
        public static List<strDropDown> Gender { get; set; }

        static CommonConstants()
        {
            Gender.Add(new strDropDown() { Id = Male, Name = MaleText });
            Gender.Add(new strDropDown() { Id = FeMale, Name = FeMaleText });
        }

    }

    public class strDropDown
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }


}
