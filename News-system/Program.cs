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

            // ���� �����������
            AuthorizationMain authorizationModel = new AuthorizationMain();
            AuthorizationWindow authorizationWindow = new AuthorizationWindow(authorizationModel);

            // ���� ��������
            MainWindow mainWindow = new MainWindow();

            // ���� ���������� �������
            AddNewsMain addNewsMain = new AddNewsMain();
            AddNews addNewsWindow = new AddNews(addNewsMain);

            // ���� �����������
            RegistrationMain registrationModel = new RegistrationMain();
            RegistrationWindow registrationWindow = new RegistrationWindow(registrationModel);

            Application.Run(mainWindow);
        }
    }
}