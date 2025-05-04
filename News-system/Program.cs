namespace News_System {
    internal static class Program {
        private static readonly FileDataUsers _fileDataUsers = new FileDataUsers();
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            AuthorizationMain authorizationModel = new AuthorizationMain(_fileDataUsers);
            AuthorizationWindow authorizationWindow = new AuthorizationWindow(authorizationModel);

            Application.Run(authorizationWindow);
        }
    }
}