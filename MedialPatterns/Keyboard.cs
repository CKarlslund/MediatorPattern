namespace MedialPatterns
{
    public class Keyboard
    {
        private Computer pi;

        public Keyboard(Computer pi)
        {
            this.pi = pi;
            pi.RegisterKeyboard(this);
        }

        internal void Press(string key)
        {
            pi.KeyPressed(key);
        }
    }
}