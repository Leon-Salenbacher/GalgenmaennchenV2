﻿using GalgenmaennchenV2.Service;
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

        private void proofLetter(char letter)
        {
            gameAdapter.proofLetter(letter);
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

        private void button1_Click(object sender, EventArgs e)
        {
            proofLetter('A');
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            proofLetter('B');
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            proofLetter('C');
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            proofLetter('D');
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            proofLetter('E');
        }

        private void btnF_Click(object sender, EventArgs e)
        {
            proofLetter('F');
        }

        private void btnG_Click(object sender, EventArgs e)
        {
            proofLetter('G');
        }

        private void btnH_Click(object sender, EventArgs e)
        {
            proofLetter('H');
        }

        private void btnI_Click(object sender, EventArgs e)
        {
            proofLetter('I');
        }

        private void btnJ_Click(object sender, EventArgs e)
        {
            proofLetter('J');
        }

        private void btnK_Click(object sender, EventArgs e)
        {
            proofLetter('K');
        }

        private void btnL_Click(object sender, EventArgs e)
        {
            proofLetter('L');
        }

        private void btnM_Click(object sender, EventArgs e)
        {
            proofLetter('M');
        }

        private void btnN_Click(object sender, EventArgs e)
        {
            proofLetter('N');
        }

        private void btnO_Click(object sender, EventArgs e)
        {
            proofLetter('O');
        }

        private void btnP_Click(object sender, EventArgs e)
        {
            proofLetter('P');
        }

        private void btnQ_Click(object sender, EventArgs e)
        {
            proofLetter('Q');
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            proofLetter('R');
        }

        private void btnS_Click(object sender, EventArgs e)
        {
            proofLetter('S');
        }

        private void btnT_Click(object sender, EventArgs e)
        {
            proofLetter('T');
        }

        private void btnU_Click(object sender, EventArgs e)
        {
            proofLetter('U');
        }

        private void btnV_Click(object sender, EventArgs e)
        {
            proofLetter('V');
        }

        private void btnW_Click(object sender, EventArgs e)
        {
            proofLetter('W');
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            proofLetter('X');
        }

        private void btnY_Click(object sender, EventArgs e)
        {
            proofLetter('Y');
        }

        private void btnZ_Click(object sender, EventArgs e)
        {
            proofLetter('Z');
        }
    }
}
