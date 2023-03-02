using GalgenmaennchenV2.Pages;
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

namespace GalgenmaennchenV2
{
    /*
     * Author: Jonas Tran
     * Spielseite Galgenmännchen
     */
    public partial class GamePage : Form
    {
        List<Image> imageHangman;

        private GameAdapter gameAdapter = new GameAdapter();
        private bool isCollapsed;
        int countImage;
        private int userID;
        public GamePage(int userID)
        {
            InitializeComponent();
            initialise();
            this.userID = userID;

            imageHangman = new List<Image>()
            {
                Properties.Resources.Stage1,
                Properties.Resources.Stage2,
                Properties.Resources.Stage3,
                Properties.Resources.Stage4,
                Properties.Resources.Stage5,
                Properties.Resources.Stage6,
                Properties.Resources.Stage7,
                Properties.Resources.Stage8,
                Properties.Resources.Stage9,
                Properties.Resources.Stage10
            };

            countImage = 0;
        }

        public void initialise()
        {
            //imgHangman.BackgroundImage = imageHangman[countImage];

            gameAdapter.startNewGame();
            loadWordLbl(gameAdapter.getWordString());
            

        }
        //Verarbeitet eingegebenen Buchstaben
        private void proofLetter(char letter)
        {
            gameAdapter.move(letter);
            loadWordLbl(gameAdapter.getWordString());
            loadImg(gameAdapter.game.getFails());
           // Wenn Spiel beendet wurde, wird der Endscreen geladen
            if (gameAdapter.proofGameEnd())
            {
                loadEndScreen();
            }
        }

   
        private void loadWordLbl(string text)
        {
            lbl.Text = text;
        }
        private void loadImg(int state)
        {
            imgHangman.BackgroundImage = imageHangman[state];
        }

        private void loadEndScreen() {
            //Lädt Endscreen
            this.gameAdapter.handleGameEnd(this.userID);
            Form frmoverlay = new Form();
            try
            {

                using (FinishedOverlay frm = new FinishedOverlay(gameAdapter, this.userID, this))
                {
                    frmoverlay.StartPosition = FormStartPosition.Manual;
                    frmoverlay.FormBorderStyle = FormBorderStyle.None;
                    frmoverlay.Opacity = .50d;
                    frmoverlay.BackColor = Color.Black;
                    frmoverlay.WindowState = FormWindowState.Maximized;
                    frmoverlay.TopMost = false;
                    frmoverlay.Location = this.Location;
                    frmoverlay.ShowInTaskbar = false;
                    frmoverlay.Show();
                    frm.Owner = frmoverlay;
                    frm.ShowDialog();
                    frmoverlay.Dispose();
                }
            }

            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { frmoverlay.Dispose(); }

        }

        
        // Grauer Balken: startet Animation
        private void panelHeaderHover(object sender, EventArgs e)
        {
            timer1.Start();
        }
        // Grauer Balken: Header navigator, noch keine Funktion
        private void timerHeader(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                panelHeaderSpiel.Height += 30;
                if (panelHeaderSpiel.Size == panelHeaderSpiel.MaximumSize)
                {
                    timer1.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                panelHeaderSpiel.Height -= 30;
                if (panelHeaderSpiel.Size == panelHeaderSpiel.MinimumSize)
                {
                    timer1.Stop();
                    isCollapsed = true;
                }
            }
        }

        private void groupBox1_Load(object sender, EventArgs e)
        {
            Label lbl = new Label();
            lbl.Text = gameAdapter.getWordString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            proofLetter('A');
            button1.Enabled = false;

        }

        private void btnB_Click(object sender, EventArgs e)
        {
            proofLetter('B');
            btnB.Enabled = false;
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            proofLetter('C');
            btnC.Enabled = false;
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            proofLetter('D');
            btnD.Enabled = false;
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            proofLetter('E');
            btnE.Enabled = false;
        }

        private void btnF_Click(object sender, EventArgs e)
        {
            proofLetter('F');
            btnF.Enabled = false;
        }

        private void btnG_Click(object sender, EventArgs e)
        {
            proofLetter('G');
            btnG.Enabled = false;
        }

        private void btnH_Click(object sender, EventArgs e)
        {
            proofLetter('H');
            btnH.Enabled = false;
        }

        private void btnI_Click(object sender, EventArgs e)
        {
            proofLetter('I');
            btnI.Enabled = false;
        }

        private void btnJ_Click(object sender, EventArgs e)
        {
            proofLetter('J');
            btnJ.Enabled = false;
        }

        private void btnK_Click(object sender, EventArgs e)
        {
            proofLetter('K');
            btnK.Enabled = false;
        }

        private void btnL_Click(object sender, EventArgs e)
        {
            proofLetter('L');
            btnL.Enabled = false;
        }

        private void btnM_Click(object sender, EventArgs e)
        {
            proofLetter('M');
            btnM.Enabled = false;
        }

        private void btnN_Click(object sender, EventArgs e)
        {
            proofLetter('N');
            btnN.Enabled = false;
        }

        private void btnO_Click(object sender, EventArgs e)
        {
            proofLetter('O');
            btnO.Enabled = false;
        }

        private void btnP_Click(object sender, EventArgs e)
        {
            proofLetter('P');
            btnP.Enabled = false;
        }

        private void btnQ_Click(object sender, EventArgs e)
        {
            proofLetter('Q');
            btnQ.Enabled = false;
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            proofLetter('R');
            btnR.Enabled = false;
        }

        private void btnS_Click(object sender, EventArgs e)
        {
            proofLetter('S');
            btnS.Enabled = false;
        }

        private void btnT_Click(object sender, EventArgs e)
        {
            proofLetter('T');
            btnT.Enabled = false;
        }

        private void btnU_Click(object sender, EventArgs e)
        {
            proofLetter('U');
            btnU.Enabled = false;
        }

        private void btnV_Click(object sender, EventArgs e)
        {
            proofLetter('V');
            btnV.Enabled = false;
        }

        private void btnW_Click(object sender, EventArgs e)
        {
            proofLetter('W');
            btnW.Enabled = false;
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            proofLetter('X');
            btnX.Enabled = false;
        }

        private void btnY_Click(object sender, EventArgs e)
        {
            proofLetter('Y');
            btnY.Enabled = false;
        }

        private void btnZ_Click(object sender, EventArgs e)
        {
            proofLetter('Z');
            btnZ.Enabled = false;
        }
    }
}
