using System;

namespace PraticalC.Excercise2
{
    public class Base
    {
        protected int weight;
        protected string name;

        public Base(int weight, string name)
        {
            this.weight = weight;
            this.name = name;
        }

        public int Weight
        {
            get => weight;
            set => weight = value;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public virtual void Show()
        {
            Console.WriteLine("Name"+Name+"\t,Weight:"+Weight);
        }

        public virtual void setMe(int weight,string name)
        {
            Weight = weight;
            Name = name;
        }
    }
}