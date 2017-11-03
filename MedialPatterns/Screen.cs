using System;

namespace MedialPatterns
{
    public class Screen
    {
        private Computer pi;

        public Screen(Computer pi)
        {
            this.pi = pi;
            pi.RegisterScreen(this);
        }

        public void DisplayKey(string key)
        {
            Console.Write(key);
        }
    }
}