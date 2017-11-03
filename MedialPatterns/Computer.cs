namespace MedialPatterns
{
    public class Computer
    {
        private Keyboard _keyboard;
        private Screen _screen;

        public void RegisterKeyboard(Keyboard keyboard)
        {
            _keyboard = keyboard;
        }

        public void RegisterScreen(Screen screen)
        {
            _screen = screen;
        }

        public void KeyPressed(string key)
        {
            _screen.DisplayKey(key);
        }
    }
}