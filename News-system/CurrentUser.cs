using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News_System {
    public class CurrentUser {

        private static string _username;

        public static void Login(string username) {
            _username = username;
        }

        public static bool IsLoggedIn() {
            return !string.IsNullOrEmpty(_username);
        }

        public string GetUsername() { return _username; }
    }
}

