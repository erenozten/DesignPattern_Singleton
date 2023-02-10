
namespace DesignPattern_Singleton
{
    public sealed class Singleton
    {
        public string Name { get; set; }

        private Singleton() { }

        private static Singleton _instance;

        public static Singleton GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Singleton();
            }
            return _instance;
        }
        
        public void someBusinessLogic()
        {
            // business logic buraya
        }
    }
}