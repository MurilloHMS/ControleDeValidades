using ControleDeValidades.Databases;

namespace ControleDeValidades
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(String[] args)
        {
            if (args.Length <1 || !new List<string> {"--install", "--INSTALL"}.Any(s => args[0].Contains(s)))
            {
                // To customize application configuration such as set high DPI settings or default font,
                // see https://aka.ms/applicationconfiguration.
                ApplicationConfiguration.Initialize();
                Application.Run(new MainWindow());
            }
            else
            {
                using( var context = new ControleContext())
                {
                    context.VerificarBanco();
                }
            }
        }
    }
}