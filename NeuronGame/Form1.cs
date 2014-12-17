using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeuronNetwork
{
    public partial class MainForm : Form
    {
        private NeuronNetwork neuronGame = new NeuronNetwork();

        public int countStone {
            get {
                return int.Parse(labelCountStone.Text);
            }
            set {
                if (value < 0)
                    value = 0;
                labelCountStone.Text = value.ToString();
            }
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            neuronGame.Init();
            countStone = 11;
            label_NS_list.Text = label_Player_list.Text = "";
            Statuslabel.Text = "Игра началась";
            EnabledControl(false);
        }

        private void buttonGetOne_Click(object sender, EventArgs e)
        {
            countStone--;
            label_Player_list.Text += "Пользователь взял 1 камень\n";
            NeuronHelper.Write("Пользователь взял 1 камень");
            getWin(false);
            if(countStone>0)
                getNeuron();
        }

        public void getNeuron()
        {
            if (neuronGame.GetNeuronValue(countStone))
            {
                countStone--;
                label_NS_list.Text += "НС взяла 1 камень\n";
                NeuronHelper.Write("НС взяла 1 камень");
            }
            else
            {
                countStone -= 2;
                label_NS_list.Text += "НС взяла 2 камня\n";
                NeuronHelper.Write("НС взяла 2 камня");
            }
            this.Refresh();
            getWin(true);
        }

        public void getWin(bool isNeuron)
        {
            if (countStone <=0 )
            {
                Statuslabel.Text = "Победа " + ((isNeuron) ? "НС" : "пользователя");
                NeuronHelper.Write(Statuslabel.Text);
                neuronGame.CorrectNeurons(isNeuron);
                EnabledControl(true);
            }
        }

        private void buttonGetTwo_Click(object sender, EventArgs e)
        {
            countStone-=2;
            label_Player_list.Text += "Пользователь взял 2 камня\n";
            NeuronHelper.Write("Пользователь взял 2 камня");
            getWin(false);
            if (countStone > 0)
                getNeuron();
        }

        public void EnabledControl(bool Lock)
        {
            buttonGetOne.Enabled = buttonGetTwo.Enabled = !Lock;
            buttonStart.Enabled = Lock;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ResourceString.AboutText, ResourceString.AboutCaption, MessageBoxButtons.OK);
        }

        private void trainerButton_Click(object sender, EventArgs e)
        {
            EnabledControl(true);
            buttonStart.Enabled = false;
            Statuslabel.Text = "Обучение НС...";
            var result = MessageBox.Show("Обучение НС будет проходить на " + NeuronSettings.countGameForTrainer.ToString() + " итераций. В конце обучения, вам будет выведено сообщение о завершении обучения.", "Запуск тренера", MessageBoxButtons.OKCancel);
            if(result == System.Windows.Forms.DialogResult.OK)
            {
                neuronGame.Init();
                NeuronTrainer trainer = new NeuronTrainer(NeuronSettings.countGameForTrainer);
                trainer.Start(neuronGame);
                MessageBox.Show("Обучение НС было завершено успешно.", "Обучение НС");
            }
            Statuslabel.Text = "Обучение НС завершено!";
            buttonStart.Enabled = true;
        }

    }
}
