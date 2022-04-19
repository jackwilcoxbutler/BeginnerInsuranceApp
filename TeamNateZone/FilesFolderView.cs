using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TeamNateZone
{
    public partial class FilesFolderView : Form
    {
        User user;
        User other;
        dbHandler db;
        string FID;

        public FilesFolderView(User user, User other)
        {
            InitializeComponent();
            this.user = user;
            this.other = other;
            this.db = new dbHandler(@"Data Source=se361.cysfo7qeek6c.us-east-1.rds.amazonaws.com;Initial Catalog=TEAM_A;Persist Security Info=True;User ID=TEAM_A;Password=j2uBr3v4F4y7kgAZF3CZmmMP;Encrypt=True;TrustServerCertificate=True");
            string name = user.getFname() + " " + user.getLname() + ".";
            userLbl.Text = name;
            otherUserLbl.Text = other.getFname() + " " + other.getLname() + ".";

        }
        public FilesFolderView(User user, string fid)
        {
            InitializeComponent();
            this.user = user;
            FID = fid;
            this.db = new dbHandler(@"Data Source=se361.cysfo7qeek6c.us-east-1.rds.amazonaws.com;Initial Catalog=TEAM_A;Persist Security Info=True;User ID=TEAM_A;Password=j2uBr3v4F4y7kgAZF3CZmmMP;Encrypt=True;TrustServerCertificate=True");
            string name = user.getFname() + " " + user.getLname() + ".";
            userLbl.Text = name;
            viewLbl.Visible = false;
            otherUserLbl.Visible = false;
        }
        private void FilesFolderView_Load(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=se361.cysfo7qeek6c.us-east-1.rds.amazonaws.com;Initial Catalog=TEAM_A;Persist Security Info=True;User ID=TEAM_A;Password=j2uBr3v4F4y7kgAZF3CZmmMP;Encrypt=True;TrustServerCertificate=True");
            SqlDataAdapter da;
            cn.Open();
            //client
            if (user.getClearance() == 0)
            {
                da = new SqlDataAdapter("SELECT filesID, UserID, FileName, FileDescription FROM FilesInFolders WHERE UserID = @id", cn);
                da.SelectCommand.Parameters.AddWithValue("@id", FID);

                DataTable dtbl = new DataTable();

                da.Fill(dtbl);

                dataGridView1.DataSource = dtbl;
                //db.get_files_folder_client(user.getUserID());
            }
            //admin
            else if (user.getClearance() == 3)
            {
                da = new SqlDataAdapter("SELECT filesID, UserID, FileName, FileDescription FROM FilesInFolders WHERE UserID = @id", cn);
                da.SelectCommand.Parameters.AddWithValue("@id", FID);

                DataTable dtbl = new DataTable();

                da.Fill(dtbl);

                dataGridView1.DataSource = dtbl;
                //db.get_files_folder_limited(other.getUserID());
            }
            //fm and cm
            else
            {
                //fm
                if (user.getClearance() == 2)
                {
                    da = new SqlDataAdapter("SELECT filesID, UserID, FileName, FileDescription FROM FilesInFolders WHERE UserID = @id AND FmPermission = @true", cn);
                    da.SelectCommand.Parameters.AddWithValue("@id", FID);
                    da.SelectCommand.Parameters.AddWithValue("@true", 1);
                }
                //cm
                else
                {
                    da = new SqlDataAdapter("SELECT filesID, UserID, FileName, FileDescription FROM FilesInFolders WHERE UserID = @id AND CmPermission = @true", cn);
                    da.SelectCommand.Parameters.AddWithValue("@id", FID);
                    da.SelectCommand.Parameters.AddWithValue("@true", 1);
                }

                DataTable dtbl = new DataTable();

                da.Fill(dtbl);

                dataGridView1.DataSource = dtbl;

                cn.Close();

                //db.get_files_folder_all(other.getUserID());
            }

        }
    }
}
