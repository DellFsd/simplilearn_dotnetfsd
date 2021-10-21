
namespace Phase1Section6._4
{
    class ThisApplication
    {
        private static ThisApplication _instance;
        public static ThisApplication Instance {
            get {
                if (_instance == null)
                {
                    _instance = new ThisApplication();
                }
                return _instance;

            }
        }
        public string Name { get; set; } = "ThisApplication";

        protected ThisApplication() { }
    }
}
