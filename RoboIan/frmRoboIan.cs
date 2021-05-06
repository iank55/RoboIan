using System;
using System.Windows.Forms;
using System.IO;

namespace RoboIan
{
    public partial class frmRoboIan : Form
    {
        string _phraseDirectory;
        public frmRoboIan()
        {
            InitializeComponent();
        }
        private void frmRoboIan_Load(object sender, EventArgs e)
        {
            _phraseDirectory = Path.Combine(Application.StartupPath, "Phrases");
        }

        #region Button Click Events
        private void btnOhShit_Click(object sender, EventArgs e)
        {
            AudioPlayer.PlayPhrase(Path.Combine(_phraseDirectory, "OhShit.wav"));
        }

        private void btnMetastormRant_Click(object sender, EventArgs e)
        {
            AudioPlayer.PlayPhrase(Path.Combine(_phraseDirectory, "MetastormRant.wav"));
        }

        private void btnOhFuck_Click(object sender, EventArgs e)
        {
            AudioPlayer.PlayPhrase(Path.Combine(_phraseDirectory, "OhFuck.wav"));
        }

        private void btnFuckingMetastorm_Click(object sender, EventArgs e)
        {
            AudioPlayer.PlayPhrase(Path.Combine(_phraseDirectory, "FuckingMetastorm.wav"));
        }

        private void btnIdiotsRant_Click(object sender, EventArgs e)
        {
            AudioPlayer.PlayPhrase(Path.Combine(_phraseDirectory, "IdiotsRant.wav"));
        }

        #endregion
    }
}
