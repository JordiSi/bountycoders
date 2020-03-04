using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FTP
{
    public partial class frm_FTP : Form
    {
        public frm_FTP()
        {
            InitializeComponent();
        }
        struct FtpSetting 
        {
            public string Server { get; set; }
            public string Username { get; set; }
            public string Password { get; set; }
            public string FileName { get; set; }
            public string FullName { get; set; }
        }

        FtpSetting _inputParameter;

        private void btnUpload_Click(object sender, EventArgs e)
        { 
            using (OpenFileDialog ofd = new OpenFileDialog() { Multiselect = false, ValidateNames = true, Filter = "All files|*.*" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    FileInfo fi = new FileInfo(ofd.FileName);
                    _inputParameter.Username = txtUserName.Text;
                    _inputParameter.Password = txtPassword.Text;
                    _inputParameter.Server = txtServer.Text;
                    _inputParameter.FileName = fi.Name;
                    _inputParameter.FullName = fi.FullName;
                }
            }
            string Nom_Fitxer = _inputParameter.FileName;
            string Ruta = _inputParameter.FullName;
            string Usuari = _inputParameter.Username;
            string psswd = _inputParameter.Password;
            string server = _inputParameter.Server;
            FtpWebRequest Connexio = (FtpWebRequest)WebRequest.Create(new Uri("ftp://" + server + "/" + Nom_Fitxer));
            Connexio.Method = WebRequestMethods.Ftp.UploadFile;
            Connexio.Credentials = new NetworkCredential(Usuari, psswd);
            Stream ftpStream = Connexio.GetRequestStream();
            FileStream fs = File.OpenRead(Ruta);
            byte[] buffer = new byte[1024];
            double total = (double)fs.Length;
            int byteRead = 0;
            double read = 0;

            do
            {
                byteRead = fs.Read(buffer, 0, 1024);
                ftpStream.Write(buffer, 0, byteRead);
                read += (double)byteRead;
                double percentage = read / total * 100;
            }
            while (byteRead != 0);
            fs.Close();
            ftpStream.Close();
            lblStatus.Text = "Upload complete !";
        }

        private void btn_Download_Click(object sender, EventArgs e)
        {
            string Nom_Fitxer = "bimmer.jpg";
            string Usuari = txtUserName.Text;
            string psswd = txtPassword.Text;
            string server = txtServer.Text;
            FtpWebRequest Connexio = (FtpWebRequest)WebRequest.Create(new Uri("ftp://" + server + "/" + Nom_Fitxer));
            Connexio.Method = WebRequestMethods.Ftp.DownloadFile;
            Connexio.Credentials = new NetworkCredential(Usuari, psswd);
            FtpWebResponse response = (FtpWebResponse)Connexio.GetResponse();

            Stream responseStream = response.GetResponseStream();

            StreamReader reader = new StreamReader(responseStream);
            reader.re(1, )

            String file = @"C://Bountycoders";

            FileStream fs = new FileStream(file, FileMode.OpenOrCreate, FileAccess.Write);
            StreamReader sr = new StreamReader(fs);
            StreamWriter sw = new StreamWriter(fs);
            sw.Write('',)

            using FileStream fs = File.OpenWrite(Nom_Fitxer);
            byte[] buffer = new byte[1024];
                    double total = (double)fs.Length;

                        fs.WriteLine(buffer, 0, 1024);
            byte[] buffer = new byte[1024];
            double total = (double)fs.Length;
            int byteRead = 0;
            double read = 0;

            do
            {
                byteRead = fs.Read(buffer, 0, 1024);
                ftpStream.Write(buffer, 0, byteRead);
                read += (double)byteRead;
                double percentage = read / total * 100;
            }

            MessageBox.Show(reader.ReadToEnd());

            Console.WriteLine("Download Complete, status {0}", response.StatusDescription);

            reader.Close();

            response.Close();



        }
    }
}
