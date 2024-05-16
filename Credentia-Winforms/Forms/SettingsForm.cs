using Credentia_Winforms.CustomControls;
using DataAccessLibrary;
using DataAccessLibrary.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Credentia_Winforms
{
    public partial class SettingsForm : Form
    {


        public SettingsForm()
        {
            InitializeComponent();

        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            ActiveUsernameLabel.Text = LoginForm.ActiveUser;

        }

        // ----------------- DATABASE -----------------//


        // Getting the connection string from the appsettings.json file
        private static string GetConnectionString(string connectionStringName = "Default")
        {
            return DBConnectionHelper.GetConnectionString(connectionStringName);
        }
    }
}
