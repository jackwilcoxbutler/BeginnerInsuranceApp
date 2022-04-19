using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamNateZone
{
    public partial class folderPage : Form
    {
        User user;
        int userClearLevel; 
        public folderPage(User user)
        {
            InitializeComponent();
            this.user = user;
            userClearLevel = user.getClearance();
        }

        private void folderPage_Load(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=se361.cysfo7qeek6c.us-east-1.rds.amazonaws.com;Initial Catalog=TEAM_A;Persist Security Info=True;User ID=TEAM_A;Password=j2uBr3v4F4y7kgAZF3CZmmMP;Encrypt=True;TrustServerCertificate=True");
            SqlDataAdapter da;
            cn.Open();
            if (user.getClearance() == 0)
            {
                da = new SqlDataAdapter("SELECT * FROM Folders WHERE UserID = @userid", cn);
                da.SelectCommand.Parameters.AddWithValue("userid", user.getUserID());
            }
            else
            {
                da = new SqlDataAdapter("SELECT * FROM Folders", cn);

            }
            
            DataTable dtbl = new DataTable();


            da.Fill(dtbl);

            dataGridView_Folders.DataSource = dtbl;


            cn.Close();

        }
        
        private void btnExpand_Click(object sender, EventArgs e)
        {
            //client only
            FilesFolderView files = new FilesFolderView(user, folderIdTxt.Text);
            files.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            if(userClearLevel == 0)
            {
                ClientWelcomeForm cWel = new ClientWelcomeForm(user);
                cWel.Show();
            }
            else if(userClearLevel == 1)
            {
                CMWelcomeForm cmWelc = new CMWelcomeForm(user);
                cmWelc.Show();
            }
            else if(userClearLevel == 2)
            {
                FMWelcomeForm fmWelc = new FMWelcomeForm(user);
                fmWelc.Show();
            }
            else
            {
                AdminWelcomeForm adWelc = new AdminWelcomeForm(user);
                adWelc.Show();
            }
        }
    }
}
