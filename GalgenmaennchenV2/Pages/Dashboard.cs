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
    public partial class Dashboard : Form
    {
        private LeaderBoardAdapter leaderBoardAdapter = new LeaderBoardAdapter();
        private bool isCollapsed;
        public Dashboard()
        {
            InitializeComponent();
            initialize();
        }

        private void initialize()
        {
            lblLeaderboard.Text = leaderBoardAdapter.ratingsToString(leaderBoardAdapter.getTop10Ratings_groupedByUser());

        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            GamePage gamePage = new GamePage(1);
            this.Hide();
            gamePage.ShowDialog();
            this.Close();
        }
        private void panelHeaderHover(object sender, EventArgs e)
        {
            //timer1.Start();
        }

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
            Label lblLeaderboard = new Label();
            lblLeaderboard.Text = leaderBoardAdapter.ratingsToString(leaderBoardAdapter.getTop10Ratings_groupedByUser());
        }
    }

    

}
