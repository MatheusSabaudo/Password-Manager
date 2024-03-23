using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password_Manager
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        //GLOBAL SETTINGS:
        bool pwd_visible = false;
        string pwd = "";

        private void Main_Load(object sender, EventArgs e)
        {
            //CONFIG PWD STANDARD MANUAL

            pwd_visible = false;

            lbl_google1.Text = "● ● ● ● ● ● ● ● ● ● ● ● ● ● ● ●";
            lbl_google2.Text = "● ● ● ● ● ● ● ● ● ● ● ● ● ● ● ●";
            lbl_googlesuits.Text = "● ● ● ● ● ● ● ● ● ● ● ● ● ● ● ●";
            lbl_discord.Text = "● ● ● ● ● ● ● ● ● ● ● ● ● ● ● ●";
            lbl_github.Text = "● ● ● ● ● ● ● ● ● ● ● ● ● ● ● ●";
            lbl_amazon.Text = "● ● ● ● ● ● ● ● ● ● ● ● ● ● ● ●";
            lbl_instagram.Text = "● ● ● ● ● ● ● ● ● ● ● ● ● ● ● ●";
            lbl_netflixm.Text = "● ● ● ● ● ● ● ● ● ● ● ● ● ● ● ●";
            lbl_netflixt.Text = "● ● ● ● ● ● ● ● ● ● ● ● ● ● ● ●";
            lbl_microsoft.Text = "● ● ● ● ● ● ● ● ● ● ● ● ● ● ● ●";
            lbl_argo.Text = "● ● ● ● ● ● ● ● ● ● ● ● ● ● ● ●";
            lbl_vatsim.Text = "● ● ● ● ● ● ● ● ● ● ● ● ● ● ● ●";
            lbl_gtt.Text = "● ● ● ● ● ● ● ● ● ● ● ● ● ● ● ●";
            lbl_flypln.Text = "● ● ● ● ● ● ● ● ● ● ● ● ● ● ● ●";
            lbl_fivem.Text = "● ● ● ● ● ● ● ● ● ● ● ● ● ● ● ●";
            lbl_razer.Text = "● ● ● ● ● ● ● ● ● ● ● ● ● ● ● ●";
            lbl_spotify.Text = "● ● ● ● ● ● ● ● ● ● ● ● ● ● ● ●";
            lbl_twitch.Text = "● ● ● ● ● ● ● ● ● ● ● ● ● ● ● ●";
            lbl_twitter.Text = "● ● ● ● ● ● ● ● ● ● ● ● ● ● ● ●";
            lbl_vatstar.Text = "● ● ● ● ● ● ● ● ● ● ● ● ● ● ● ●";
        }

        //PWD SETTING MANUAL MODE

        string pwd1 = "Gz$4(|;z=y>Mb7|2|_4;??i#>=vG\"[";
        string pwd2 = "PBd4EUs!TRghnze5mbUxdw!pskcrU#";
        string pwd3 = "Msr@19534152";
        string pwd4 = "uW1a#{y3imk@c%&MqZ9mxq)OI+d6Hr";
        string pwd5 = "Msr@19534152";
        string pwd6 = "RafaSBD@19051997";
        string pwd7 = "pm'YVeV[TafE3~02@VR3_17}hXoxEx";
        string pwd8 = "Msr@19534152";
        string pwd9 = "Cris@1508";
        string pwd10 = "Msr@195341526384";
        string pwd11 = "zAt#s@yEqip_,c9=Lq~QkAM8jF_d'r";
        string pwd12 = "1670662 - Msr@19534152";
        string pwd13 = "1348556 - Msr@19534152";
        string pwd14 = "MatteoSa - Msr@19534152";
        string pwd15 = "MatteoSabaudo - Msr@19534152";
        string pwd16 = "Msr19534152";
        string pwd17 = "Yc%2Qg@%&KotCEuPjJHuf!oWnT@6ZN";
        string pwd18 = "oCLn~J4J.u@i(HbWXFd'YW@lYqSLA[";
        string pwd19 = "Msr@19534152";
        string pwd20 = "1670662 - Msr@19534152";

        private void DecryptPWD(Label label)
        {
            if (pwd_visible)
            {
                //Encrypt
                label.Text = "● ● ● ● ● ● ● ● ● ● ● ● ● ● ● ●";
            }
            else
            {
                //Decrypt
                label.Text = pwd;
            }

            //Revert the actual state
            pwd_visible = !pwd_visible;
        }

        private void btn_show1_Click(object sender, EventArgs e)
        {
            pwd = pwd1;
            DecryptPWD(lbl_google1);
        }

        private void btn_show19_Click(object sender, EventArgs e)
        {
            pwd = pwd2;
            DecryptPWD(lbl_google2);
        }

        private void btn_show18_Click(object sender, EventArgs e)
        {
            pwd = pwd3;
            DecryptPWD(lbl_googlesuits);
        }

        private void btn_show17_Click(object sender, EventArgs e)
        {
            pwd = pwd4;  
            DecryptPWD(lbl_discord);
        }

        private void btn_show16_Click(object sender, EventArgs e)
        {
            pwd = pwd5;
            DecryptPWD(lbl_github);  
        }

        private void btn_show15_Click(object sender, EventArgs e)
        {
            pwd = pwd6;
            DecryptPWD(lbl_amazon);

        }

        private void btn_show14_Click(object sender, EventArgs e)
        {
            pwd = pwd7;
            DecryptPWD(lbl_instagram);
        }

        private void btn_show13_Click(object sender, EventArgs e)
        {
            pwd = pwd8;
            DecryptPWD(lbl_netflixm);
        }

        private void btn_show12_Click(object sender, EventArgs e)
        {
            pwd = pwd9;
            DecryptPWD(lbl_netflixt);
        }

        private void btn_show11_Click(object sender, EventArgs e)
        {
            pwd = pwd10;
            DecryptPWD(lbl_microsoft);
        }

        private void btn_show10_Click(object sender, EventArgs e)
        {
            pwd = pwd11;
            DecryptPWD(lbl_argo);
        }

        private void btn_show9_Click(object sender, EventArgs e)
        {
            pwd = pwd12;
            DecryptPWD(lbl_vatsim);
        }

        private void btn_show8_Click(object sender, EventArgs e)
        {
            pwd = pwd13;
            DecryptPWD(lbl_gtt);
        }

        private void btn_show7_Click(object sender, EventArgs e)
        {
            pwd = pwd14;
            DecryptPWD(lbl_flypln);
        }

        private void btn_show6_Click(object sender, EventArgs e)
        {
            pwd = pwd15;
            DecryptPWD(lbl_fivem);
        }

        private void btn_show5_Click(object sender, EventArgs e)
        {
            pwd = pwd16;
            DecryptPWD(lbl_razer);;
        }

        private void btn_show4_Click(object sender, EventArgs e)
        {
            pwd = pwd17;
            DecryptPWD(lbl_spotify);
        }

        private void btn_show3_Click(object sender, EventArgs e)
        {
            pwd = pwd18;
            DecryptPWD(lbl_twitch);
        }

        private void btn_show2_Click(object sender, EventArgs e)
        {
            pwd = pwd19;
            DecryptPWD(lbl_twitter);
        }

        private void btn_show20_Click(object sender, EventArgs e)
        {
            pwd = pwd20;
            DecryptPWD(lbl_vatstar);
        }

        private void btn_copy1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(pwd1);
            MessageBox.Show("PWD copied to the clipboard!");
        }

        private void btn_copy2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(pwd2);
            MessageBox.Show("PWD copied to the clipboard!");
        }

        private void btn_copy3_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(pwd3);
            MessageBox.Show("PWD copied to the clipboard!");
        }

        private void btn_copy4_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(pwd4);
            MessageBox.Show("PWD copied to the clipboard!");
        }

        private void btn_copy5_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(pwd5);
            MessageBox.Show("PWD copied to the clipboard!");
        }

        private void btn_copy10_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(pwd6);
            MessageBox.Show("PWD copied to the clipboard!");
        }

        private void btn_copy9_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(pwd7);
            MessageBox.Show("PWD copied to the clipboard!");
        }

        private void btn_copy8_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(pwd8);
            MessageBox.Show("PWD copied to the clipboard!");
        }

        private void btn_copy7_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(pwd9);
            MessageBox.Show("PWD copied to the clipboard!");
        }

        private void btn_copy6_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(pwd10);
            MessageBox.Show("PWD copied to the clipboard!");
        }

        private void btn_copy11_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(pwd11);
            MessageBox.Show("PWD copied to the clipboard!");
        }

        private void btn_copy12_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(pwd12);
            MessageBox.Show("PWD copied to the clipboard!");
        }

        private void btn_copy13_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(pwd13);
            MessageBox.Show("PWD copied to the clipboard!");
        }

        private void btn_copy14_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(pwd14);
            MessageBox.Show("PWD copied to the clipboard!");
        }

        private void btn_copy15_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(pwd15);
            MessageBox.Show("PWD copied to the clipboard!");
        }

        private void btn_copy16_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(pwd16);
            MessageBox.Show("PWD copied to the clipboard!");
        }

        private void btn_copy17_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(pwd17);
            MessageBox.Show("PWD copied to the clipboard!");
        }

        private void btn_copy18_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(pwd18);
            MessageBox.Show("PWD copied to the clipboard!");
        }

        private void btn_copy19_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(pwd19);
            MessageBox.Show("PWD copied to the clipboard!");
        }

        private void btn_copy20_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(pwd20);
            MessageBox.Show("PWD copied to the clipboard!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Test().Show();
            this.Hide();
        }

        private void btn_notes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("GOOGLE BACKUP CODES (msabaudo84) - 1.9031  -  2.7299 - 3.8580  -  4.6882 - 5.1177  -  6.2626 - 7.2307  -  8.0192 - 9.4388  -  10.1665 \")\r\n\r\nGITHUB SSH KEY - ssh-rsa AAAAB3NzaC1yc2EAAAADAQABAAABgQDHqzehiGACOgj6EUfwNvsrHZNsdvknCE3wc2djD4AJQ0/B/PCQW7p1T3mYL33GwzvZtTs/EHIkOEmlY+WP7+aXgxMi8mD/gsiYfDTiS6rRig5WEPPMl9nie+qkGcmfRWj9/Mqpu8tt6tyX6z/zd8YAorSM8yVn/GLVGdMdBpgDbWsg/undebOFUZ9Mb/uTa/0m3muaIl6vWrLOJSBnRIY26BUSEh9KKOWj/aomhh3Z//1HiwO2fAd/uJjncQEhhzMiJK7uNhHl64G7tl5SqI7DaIfOXN8Hs5N08imRpVfXN3MdaxPFeiXZ7MQPnD0teKFBf/vmGTFoQ0ajUVP2SnvKFB2VVmz/Jjge+r4thxgUs+dZ49JXPpIKLzz5SkBlFM6rpHrymnYgcjI9ZBu1Fx/yxP/2L7dzio9vgmQQ63XfTQmVwtPKuaT3sPneAY5Fl3P4WpNOEsKV9UINZBuyuBVIdFOLgAaEhbZpp8iBVUB7ahD3Kys/IKlYrdAxOHYZtc8= ubuntu@codespaces-e6f4d2\")\r\n\r\nSTEAM BACKUP CODES: 1.BKJJCH8  -  2.XH8QP65 - 3.RVVBB42  -  4.8RNQRK3 - 5.HXD8XN2  -  6.FWQ9G67 - 7.YH89MM6  -  8.R5QYWY3 - 9.MCMHBC2  -  10.BBK4GN8 \r\n\r\nSTEAM OWNER CODE: R50895 \")\r\n\r\nCodigos Instagram: 0597 8123 | 7523 8409 | 2465 9380 | 2937 0814 |9376 4152 \r\n\r\nCodigos Outlook (matteosabaudo): R7DKU-UGDGS-ZQHF2-YLH9E-TBL37", "CODES");
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
