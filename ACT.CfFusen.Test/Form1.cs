using System.Windows.Forms;

namespace ACT.CfFusen.Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PluginBase plugin = new PluginBase();
            plugin.InitPlugin(tabPage1, null);
        }
    }
}
