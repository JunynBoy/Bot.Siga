namespace Bot.Core.src.Helper
{
    public static class StringHelper
    {
        public static void ConsoleColoredLog(ConsoleColor color, params string[] args)
        {

            Console.ForegroundColor = color;

            foreach (string text in args)
            {
                Console.WriteLine(text);
            }

            Console.ResetColor();

        }
    }
}
