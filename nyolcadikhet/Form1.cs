using nyolcadikhet.Entities;
using nyolcadikhet.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nyolcadikhet
{
    public partial class Form1 : Form
    {
        private List<Toy> _toys = new List<Toy><Ball>();

        private BallFactory _factory;
        public BallFactory Factory

        {
            get { return _factory; }
            set { _factory = value; }
        }
        public Form1()
        {
            InitializeComponent();


           Factory = new CarFactory();
        }

        private void createTimer_Tick(object sender, EventArgs e)
        {
            var car = Factory.CreateNew();
            _toys.Add(car);
            car.Left = -car.Width;
            mainPanel.Controls.Add(car);
        }

        private void conveyorTimer_Tick(object sender, EventArgs e)
        {
            var maxPosition = 0;
            foreach (var car in _cars)
            {
                car.MoveToy();
                if (car.Left > maxPosition)
                    maxPosition = car.Left;
            }

            if (maxPosition > 1000)
            {
                var oldestBall = _balls[0];
                mainPanel.Controls.Remove(oldestBall);
                _balls.Remove(oldestBall);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}


       
    

