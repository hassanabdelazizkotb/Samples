using System;
using System.Windows.Forms;
using Registration; // Adjust the namespace if needed

namespace Registration;

static class Program
{
    [STAThread]
    static void Main()
    {
        // Initialize the database
        DatabaseSetup.CreateDatabase();

        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new LoginForm());
    }
}
