using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonsterMerger.UserInterface {
    public partial class MainMenu : Form {
        public MainMenu() {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e) {

        }

        private void buttonMerge_Click(object sender, EventArgs e) {
            new MergeMenu().ShowDialog();
        }

        private void buttonCreate_Click(object sender, EventArgs e) {
            //new CreateMenu(Program.dataManager.Load("helloworld969", DataManager.DataType.Monsters)).ShowDialog();
            new CreateMenu(null).ShowDialog();
        }

        private void buttonModify_Click(object sender, EventArgs e) {
            new ListMenu().ShowDialog();
        }

        private void buttonSaveAll_Click(object sender, EventArgs e) {
            Program.dataManager.SaveAllData();
        }

        private void buttonLoadAll_Click(object sender, EventArgs e) {
            Program.dataManager.LoadAllData();
        }

        private void label1_Click(object sender, EventArgs e) {

        }
    }
}
