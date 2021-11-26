namespace QR_Code_in_Base64_encoding_for_KSA_E_Invoicing
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Dashboard());
        }
    }
}