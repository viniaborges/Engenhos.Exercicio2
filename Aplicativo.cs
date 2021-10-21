using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Engenhos.Exercicio2
{
    public partial class Aplicativo : Form
    {
        public Aplicativo()
        {
            InitializeComponent();
        }

        private void Aplicativo_Load(object sender, EventArgs e)
        {
            BatChangeBt.Text = "Trocar bateria";
            BatTimer.Enabled = true;
            BatTimer.Stop();
            Refresh_Flashlight();
        }

        public void Refresh_Flashlight()
        {
            BatteryStatus.Text = Program.Bats.Last().Status + "%";

            if (Program.OnOffBt)
            {
                OnOffBtStatus.Text = "Botão ligado";
                OnOffBt.Text = "Desligar";
                Program.Lant.Status = true;
                BatTimer.Start();
            }
            else
            {
                OnOffBtStatus.Text = "Botão desligado";
                OnOffBt.Text = "Ligar";
                Program.Lant.Status = false;
                BatTimer.Stop();
            }

            if (Program.Bats.Last().Status == 0)
            {
                Program.Lant.Status = false;
            }
            
            if (Program.Lant.Status)
            {
                FlashlightStatus.Text = "Lanterna ligada";
                FlashlightImg.BackgroundImage = Properties.Resources.FlashlightOn;
            }
            else
            {
                FlashlightStatus.Text = "Lanterna desligada";
                FlashlightImg.BackgroundImage = Properties.Resources.FlashlightOff;
            }
        }

        private void BatTimer_Tick(object sender, EventArgs e)
        {
            if(Program.Bats.Last().Status > 0)
            {
                Program.Bats.Last().Consumir();
            }
            Refresh_Flashlight();
        }

        private void OnOffBt_Click(object sender, EventArgs e)
        {
            Program.OnOffBt = !Program.OnOffBt;
            Refresh_Flashlight();
        }

        private void BatChangeBt_Click(object sender, EventArgs e)
        {
            Bateria bat = new();
            Program.Bats.Add(bat);
            BatTimer.Enabled = false;
            BatTimer.Enabled = true;
            Refresh_Flashlight();
        }
    }

    public class Lanterna
    {
        public bool Status { get; set; }

        public Lanterna()
        {
            Status = false;
        }

        public void Ligar()
        {
            Status = true;
        }

        public void Desligar()
        {
            Status = false;
        }
    }

    public class Bateria
    {
        public int Status { get; set; }

        public Bateria()
        {
            Status = 100;
        }

        public void Consumir()
        {
            if(Status > 0)
            {
                Status--;
            }
        }
    }
}
