namespace EventForSemafor
{
    internal class Program
    {
        public delegate void SemaforLightsDelegate(byte semafor);
        public static event SemaforLightsDelegate SemaforLights;
        static void Main(string[] args)
        {
            SemaforLights += new SemaforLightsDelegate(GreenLight);
            Status(1, 3);
            SemaforLights -= new SemaforLightsDelegate(GreenLight);
            SemaforLights += new SemaforLightsDelegate(RedLight);
            Status(2, 4);

            Thread.Sleep(2000);
            Console.WriteLine("");

            SemaforLights -= new SemaforLightsDelegate(RedLight);
            SemaforLights += new SemaforLightsDelegate(YellowLight);

            Status(1, 3);
            Status(2, 4);

            Console.WriteLine("");
            Thread.Sleep(2000);

            SemaforLights -= new SemaforLightsDelegate(YellowLight);
            SemaforLights += new SemaforLightsDelegate(GreenLight);

            Status(1, 3); 
            SemaforLights -= new SemaforLightsDelegate(GreenLight);
            SemaforLights += new SemaforLightsDelegate(RedLight);
            Status(2, 4);
            
        }
        static void Status(byte s1, byte s2)
        {
            if (SemaforLights != null)
            {
                SemaforLights.Invoke(s1);
                SemaforLights.Invoke(s2);
            }
        }
        static void GreenLight(byte status)
        {
            Console.WriteLine($"Semafor {status} has a green light");
        }
        static void RedLight(byte status)
        {
            Console.WriteLine($"Semafor {status} has a red light");
        }
        static void YellowLight(byte status)
        {
            Console.WriteLine($"Semafor {status} has a yellow light");
        }
    }
}
