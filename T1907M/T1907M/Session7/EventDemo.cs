using System;

namespace T1907M.Session7
{
    public delegate void ButtonHander(string msg);
    public class EventDemo
    {
        public event ButtonHander OnClick;

        public void ClickButton()
        {
            Console.WriteLine("Button Clicked!");
            DateTime now = DateTime.Now;
            if (OnClick == null)
            {
                OnClick += ShowAlert;
            }

            OnClick("User Clicked At : " + now);
        }

        public static void ShowAlert(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}