
namespace DesignPattern_Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            // client
            Singleton s1 = Singleton.GetInstance();
            Singleton s2 = Singleton.GetInstance();

            // s1 ve s2 objesi aynıdır:
            if (s1 == s2)
            {
                Console.WriteLine("Objeler aynı");
            }
            else
            {
                Console.WriteLine("Objeler farklı");
            }
        }
    }
}