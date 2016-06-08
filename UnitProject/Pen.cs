using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitProject
{
    public class Pen
    {
        // сколько чернила в ручке
        private int inkContainerValue = 1000;
        // размер букв, которые пишутся ручкой
        private double sizeLetter = 1.0;
        // цвет ручки
        private String color = "BLUE";

        public Pen(int inkContainerValue)
        {
            this.inkContainerValue = inkContainerValue;
        }

        public Pen(int inkContainerValue, double sizeLetter): this(inkContainerValue)
        {
            this.sizeLetter = sizeLetter;
        }

        public Pen(int inkContainerValue, double sizeLetter, String color): this(inkContainerValue, sizeLetter)
        {
            this.color = color;
        }

        public String write(String word)
        {
            if (!isWork())
            {
                return "";
            }
            double sizeOfWord = word.Length * sizeLetter;
            if (sizeOfWord <= inkContainerValue)
            {
                inkContainerValue -= (int)sizeOfWord;
                return word;
            }
            String partOfWord = word.Substring(0, inkContainerValue);
            inkContainerValue = 0;
            return partOfWord;
        }

        // ERROR!!! Bug
        public String getColor()
        {
            return "BLUE";
        }

        public Boolean isWork()
        {
            return inkContainerValue > 0;
        }
        public void doSomethingElse()
        {
            Console.WriteLine(color);
        }
    }
}
