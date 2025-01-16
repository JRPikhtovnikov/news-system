using News_System;

namespace News_System {
    internal static class Program {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // окно авторизации
            AuthorizationMain authorizationModel = new AuthorizationMain();
            AuthorizationWindow authorizationWindow = new AuthorizationWindow(authorizationModel);

            // окно новостей
            MainWindow mainWindow = new MainWindow();

            // окно добавления новости
            AddNewsMain addNewsMain = new AddNewsMain();
            AddNews addNewsWindow = new AddNews(addNewsMain);

            // окно регистрации
            RegistrationMain registrationModel = new RegistrationMain();
            RegistrationWindow registrationWindow = new RegistrationWindow(registrationModel);

            Application.Run(mainWindow);
        }
    }
}