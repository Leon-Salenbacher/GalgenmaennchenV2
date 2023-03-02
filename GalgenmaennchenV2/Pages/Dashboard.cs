using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GalgenmaennchenV2.Service;

namespace GalgenmaennchenV2.Pages
{
    /*
     * Author: Jonas Tran
     * Hauptmenü Oberfläche
     */

    public partial class Dashboard : Form
    {
        private LeaderBoardAdapter leaderBoardAdapter = new LeaderBoardAdapter();
        private UserAdapter userAdapter = new UserAdapter();
        private bool isCollapsed;
        private int userId;
        public Dashboard(int userId)
        {
            this.userId = userId;
            InitializeComponent();
            initialize();
        }

        private void initialize()
        {
            //Generiert ein Label und holt sich den Namen
            lblLeaderboard.Text = leaderBoardAdapter.ratingsToString(leaderBoardAdapter.getTop10Ratings_groupedByUser());
            lblUsername.Text = userAdapter.getUserById(this.userId).getName();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            //Verlinkung zur Spielseite

            GamePage gamePage = new GamePage(this.userId);
            this.Hide();
            gamePage.ShowDialog();
            this.Close();
        }
        private void panelHeaderHover(object sender, EventArgs e)
        {
            //timer1.Start();
        }

        // Grauer Balken: Header navigator, noch keine Funktion
        private void timerHeader(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                panelHeaderDashboard.Height += 30;
                if (panelHeaderDashboard.Size == panelHeaderDashboard.MaximumSize)
                {
                    timer1.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                panelHeaderDashboard.Height -= 30;
                if (panelHeaderDashboard.Size == panelHeaderDashboard.MinimumSize)
                {
                    timer1.Stop();
                    isCollapsed = true;
                }
            }
        }

        private void panelHeaderClose(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void panelHeaderEnter(object sender, EventArgs e)
        {
            //timer1.Start();
        }
        private void leaderboard_load(object sender, EventArgs e)
        {
            //Generiert ein Label für die Bestenliste
            Label lblLeaderboard = new Label();
            lblLeaderboard.Text = leaderBoardAdapter.ratingsToString(leaderBoardAdapter.getTop10Ratings_groupedByUser());
        }
    }

    

}
