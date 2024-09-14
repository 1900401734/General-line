﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MesDatas
{
    public partial class FormSuperUser : Form
    {
        public string[] userdata = new string[1000];
        IniFiles ini_user = new IniFiles(Application.StartupPath + @"Userdata.INI");

        public FormSuperUser()
        {
            InitializeComponent();
        }
        private void FormSuperUser_Load(object sender, EventArgs e)
        {
            Userdata_Read();

        }
            private void Button1_Click(object sender, EventArgs e)
        {
            userdata[0] = tbx_00.Text;
            userdata[1] = tbx_01.Text;
            userdata[2] = tbx_02.Text;
            userdata[3] = tbx_03.Text;
            userdata[4] = tbx_04.Text;
            userdata[5] = tbx_05.Text;
            userdata[6] = tbx_06.Text;
            userdata[7] = tbx_07.Text;
            userdata[8] = tbx_08.Text;
            userdata[9] = tbx_09.Text;
            Userdata_Write();
            Close();
            MessageBox.Show("注册成功！请重启软件！");
        }

        private void Userdata_Write()
        {
           
            ini_user.IniWriteValue("SuperUser1", "ID", tbx_00.Text);
            ini_user.IniWriteValue("SuperUser1", "Passward", tbx_01.Text);
            ini_user.IniWriteValue("SuperUser2", "ID", tbx_02.Text);
            ini_user.IniWriteValue("SuperUser2", "Passward", tbx_03.Text);
            ini_user.IniWriteValue("SuperUser3", "ID", tbx_04.Text);
            ini_user.IniWriteValue("SuperUser3", "Passward", tbx_05.Text);
            ini_user.IniWriteValue("SuperUser4", "ID", tbx_06.Text);
            ini_user.IniWriteValue("SuperUser4", "Passward", tbx_07.Text);
            ini_user.IniWriteValue("SuperUser5", "ID", tbx_08.Text);
            ini_user.IniWriteValue("SuperUser5", "Passward", tbx_09.Text);

        }
        private void Userdata_Read()
        {
            userdata[0] = ini_user.IniReadValue("SuperUser1", "ID");
            userdata[1] = ini_user.IniReadValue("SuperUser1", "Passward");
            userdata[2] = ini_user.IniReadValue("SuperUser2", "ID");
            userdata[3] = ini_user.IniReadValue("SuperUser2", "Passward");
            userdata[4] = ini_user.IniReadValue("SuperUser3", "ID");
            userdata[5] = ini_user.IniReadValue("SuperUser3", "Passward");
            userdata[6] = ini_user.IniReadValue("SuperUser4", "ID");
            userdata[7] = ini_user.IniReadValue("SuperUser4", "Passward");
            userdata[8] = ini_user.IniReadValue("SuperUser5", "ID");
            userdata[9] = ini_user.IniReadValue("SuperUser5", "Passward");

            tbx_00.Text = userdata[0];
            tbx_01.Text = userdata[1];
            tbx_02.Text = userdata[2];
            tbx_03.Text = userdata[3];
            tbx_04.Text = userdata[4];
            tbx_05.Text = userdata[5];
            tbx_06.Text = userdata[6];
            tbx_07.Text = userdata[7];
            tbx_08.Text = userdata[8];
            tbx_09.Text = userdata[9];
        }

        private void Button2_Click(object sender, EventArgs e)
        {

            userdata[2] = tbx_02.Text;
            userdata[3] = tbx_03.Text; Userdata_Write();
        }

        private void Button3_Click(object sender, EventArgs e)
        {

            userdata[4] = tbx_04.Text;
            userdata[5] = tbx_05.Text; Userdata_Write();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            userdata[6] = tbx_06.Text;
            userdata[7] = tbx_07.Text; Userdata_Write();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            userdata[8] = tbx_08.Text;
            userdata[9] = tbx_09.Text; Userdata_Write();
        }
    }
}
