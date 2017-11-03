using System;

namespace MedialPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer pi = new Computer();
            Keyboard keyboard = new Keyboard(pi);
            Screen screen = new Screen(pi);
            keyboard.Press("H");
            keyboard.Press("E");
            keyboard.Press("L");
            keyboard.Press("L");
            keyboard.Press("O");
        }
    }
}
