using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using WeAreDevs_API;

namespace Tridle_Executor
{
    public partial class Injector : KryptonForm
    {
        ExploitAPI module = new ExploitAPI();
        public Injector()
        {
            InitializeComponent();
        }

        private void Injector_Load(object sender, EventArgs e)
        {
            lb_Scripts.Items.Clear();
            Functions.PopulateListBox(lb_Scripts, "./Scripts", "*.txt");
            Functions.PopulateListBox(lb_Scripts, "./Scripts", "*.lua");
        }

        private void btn_Attach_Click(object sender, EventArgs e)
        {
            module.LaunchExploit();
        }

        private void btn_Execute_Click(object sender, EventArgs e)
        {
            module.SendLuaScript(txt_Code.Text);
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_Code.Clear();
        }

        private void btn_OpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                openFileDialog1.Title = "Open";
                txt_Code.Text = File.ReadAllText(openFileDialog1.FileName);
            }
        }

        private void btn_SaveFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (Stream s = File.Open(saveFileDialog1.FileName, FileMode.CreateNew))
                using (StreamWriter sw = new StreamWriter(s))
                {
                    sw.Write(txt_Code.Text);
                }
            }
        }

        private void lb_Scripts_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_Code.Text = File.ReadAllText($"./Scripts/{lb_Scripts.SelectedItem}");
        }

        private void btn_EasyMenu_Click(object sender, EventArgs e)
        {
            EasyMenu easyMenu = new EasyMenu();
            easyMenu.Show();
        }
    }
}
