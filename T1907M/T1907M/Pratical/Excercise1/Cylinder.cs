using System;

namespace PraticalC.Excercise1
{
    public class Cylinder
    {
        private double basearea;
        private double lateralarea;
        private double totalarea;
        private double volume;
        
        public Cylinder()
        {
        }
        public Cylinder(double basearea, double lateralarea, double totalarea, double volume)
        {
            this.basearea = basearea;
            this.lateralarea = lateralarea;
            this.totalarea = totalarea;
            this.volume = volume;
        }
        
        public double Basearea
        {
            get => basearea;
            set => basearea = value;
        }
        
        public double Lateralarea
        {
            get => lateralarea;
            set => lateralarea = value;
        }
        
        public double Totalarea
        {
            get => totalarea;
            set => totalarea = value;
        }
        
        public double Volume
        {
            get => volume;
            set => volume = value;
        }
        
        public void Process(double radius,double height)
        {
            Basearea = radius * radius * Math.PI;
            Lateralarea = 2 * Math.PI * radius * height; 
            Totalarea = 2 * Math.PI * radius* (height + radius);
            Volume = Math.PI * radius * radius * height;
        }
        public void Result()
        {
            Console.WriteLine("BaseArea"+Math.Round(Basearea,2)+"   |    tLateralArea"+Math.Round(Lateralarea,2)+"   |    TotalArea"+Math.Round(Totalarea,2)+"   |    Volume"+Math.Round(Volume),2);
        }
    }
}