using GalgenmaennchenV2.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GalgenmaennchenV2.Pages
{
    public partial class FinishedOverlay : Form
    {
        private GameAdapter gameAdapter;
        public FinishedOverlay(GameAdapter gameAdapter)
        {
            InitializeComponent();
            this.gameAdapter = gameAdapter;
        }

        private void FinishedOverlay_Load(object sender, EventArgs e)
        {

        }
    }
}
