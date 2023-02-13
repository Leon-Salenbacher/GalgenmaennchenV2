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
    public partial class GamePage : Form
    {
        List<Image> imageHangman;

        private GameAdapter gameAdapter = new GameAdapter();
        private bool isCollapsed;
        int countImage;
        public GamePage()
        {
            InitializeComponent();
            initialise();



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

        private void initialise()
        {
            //imgHangman.BackgroundImage = imageHangman[countImage];

            gameAdapter.startNewGame();
            loadWordLbl(gameAdapter.getWordString());
            

        }

        private void loadWordLbl(string text)
        {
            lbl.Text = text;
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            countImage++;
            imgHangman.BackgroundImage = imageHangman[countImage];
        }

        private void panelHeaderHover(object sender, EventArgs e)
        {
            timer1.Start();
        }

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

       
    }
}
