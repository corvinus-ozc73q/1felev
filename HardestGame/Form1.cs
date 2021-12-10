﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorldsHardestGame;

namespace HardestGame
{
    public partial class Form1 : Form
    {
        GameController gc = new GameController();
        GameArea ga;
       
        int populationSize = 100;
        int nbrOFSteps = 10;
        int nbrOfStepsIncrement = 10;
        int generation = 1;

        public Form1()
        {
            InitializeComponent();

            ga = gc.ActivateDisplay();
            this.Controls.Add(ga);

            gc.GameOver += Gc_Gameover;

            for (int i = 0; i < populationSize; i++)
            {
                gc.AddPlayer(nbrOFSteps);
            }
            gc.Start();
            
        }
        private void Gc_Gameover(object sender)
        {
            generation++;
            label1.Text = string.Format("{0}. generáció,", generation);

            var playerlist = from p in gc.GetCurrentPlayers()
                             orderby p.GetFitness() descending
                             select p;
            var topPerformers = playerlist.Take(populationSize / 2).ToList();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
