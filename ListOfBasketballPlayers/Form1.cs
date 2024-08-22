using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListOfBasketballPlayers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            List<Player> players = new List<Player>
            {
                new Player { FirstName = "LeBron", LastName = "James", JerseyNumber = 23 },
                new Player { FirstName = "Stephen", LastName = "Curry", JerseyNumber = 30 },
                new Player { FirstName = "Kevin", LastName = "Durant", JerseyNumber = 7 },
                new Player { FirstName = "Giannis", LastName = "Antetokounmpo", JerseyNumber = 34 },
                new Player { FirstName = "Kawhi", LastName = "Leonard", JerseyNumber = 2 }
            };

            dgv.DataSource = players;
        }

        class Player
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int JerseyNumber { get; set; }
        }

    }
}
