using GalgenmaennchenV2.Objects;
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
        private RatingAdapter ratingAdapter = new RatingAdapter();
        public FinishedOverlay(GameAdapter gameAdapter)
        {
            InitializeComponent();
            this.gameAdapter = gameAdapter;
            loadPage();
        }

        private void FinishedOverlay_Load(object sender, EventArgs e)
        {

        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {

        }

        private void loadPage()
        {
            if (this.gameAdapter.game.getGameState() == GameState.WIN)
            {
                lblFinished.Text = "Win";
            } else if (this.gameAdapter.game.getGameState() == GameState.LOOS)
            {
                lblLose.Text = "Loose";
            }  else {
                lblError.Text = "Error";
            }
        }
    }
}
