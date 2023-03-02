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
    /*
     * Author: Jonas Tran
     * Popup Fenster nach Spielende
     */
    public partial class FinishedOverlay : Form
    {
        private GameAdapter gameAdapter;
        private RatingAdapter ratingAdapter = new RatingAdapter();
        private int userID;
        private GamePage gamePage;
        public FinishedOverlay(GameAdapter gameAdapter, int userID, GamePage gamePage) 
        {
            InitializeComponent();
            this.gameAdapter = gameAdapter;
            this.userID = userID;
            loadPage();
            this.gamePage = gamePage;
        }

        private void FinishedOverlay_Load(object sender, EventArgs e)
        {

        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            //Schließt die Spielseite und das Popupfenster, um ein neues Spielfenster zu öffnen
            GamePage gamePage2 = new GamePage(1);
            this.Hide();
            this.Close();
            this.gamePage.Hide();
            this.gamePage.Close();
            gamePage2.ShowDialog();
        }

        private void loadPage()
        {
            //Das Label Gewonnen und die Versuche werden angezeigt
            if (this.gameAdapter.game.getGameState() == GameState.WIN)
            {
                lblFinished.Text = "Gewonnen";
                lblLose.Hide();
                lblError.Hide();
                lblVersuche.Text = this.gameAdapter.game.getFails().ToString();
            }
            //Das Label Verloren und die Versuche werden angezeigt
            else if (this.gameAdapter.game.getGameState() == GameState.LOOS)
            {
                lblLose.Text = "Verloren";
                lblFinished.Hide();
                lblError.Hide();
                lblVersuche.Text = this.gameAdapter.game.getFails().ToString();
            //Bei einem Fehler wird das Label Fehler angezeigt
            }
            else {
                lblError.Text = "Fehler";
                lblFinished.Hide();
                lblLose.Hide();
            }
            //Highscore vom Spieler wird in einem Label generiert
            Rating rating = ratingAdapter.getHighScore(userID);
            lblHighscore.Text = rating.getVersuche().ToString();

            lblSolution.Text = this.gameAdapter.game.getWord();
        }

        //Zurück zum Hauptmenü kehren
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Dashboard dashboard= new Dashboard(this.userID);
            this.Hide();
            this.Close();
            this.gamePage.Hide();
            this.gamePage.Close();
            dashboard.ShowDialog();
        }

        private void lblError_Click(object sender, EventArgs e)
        {

        }
    }
}
