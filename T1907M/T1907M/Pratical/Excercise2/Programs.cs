namespace PraticalC.Excercise2
{
    class Program
    {
        public static void Main(string[] args)
        {
            Lion l = new Lion(0,"");
            Tiger t = new Tiger(0,"");
            l.setMe(200,"Lion");
            t.setMe(100,"Tiger");
            l.Show();
            t.Show();
        }
    }
}