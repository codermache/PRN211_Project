using Program.Admin;

namespace Program
{
    internal static class Program
    {
        public static int Id;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new frmLogin());
            //Application.Run(new frmMenu());
            // Application.Run(new frmSlot());
           // Application.Run(new frmSlot());

        }
    }
}