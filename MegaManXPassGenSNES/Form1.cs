using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaManXPassGenSNES
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            PopulateComboBoxPasswordSet();
        }

        private void PopulateComboBoxPasswordSet()
        {
            for (int x = 1; x < 9; x++)
            {
                comboBoxPasswordSet.Items.Add(x);
            }

            comboBoxPasswordSet.SelectedIndex = 0;
        }

        private void buttonGeneratePassword_Click(object sender, EventArgs e)
        {

            PasswordData passwordData = new PasswordData
            {
                AcquiredArmor = checkBoxArmor.Checked,
                AcquiredBoots = checkBoxBoots.Checked,
                AcquiredHeartTankArmoredArmadillo = checkBoxArmoredArmadilloHeartTank.Checked,
                AcquiredHeartTankBoomerKuwanger = checkBoxBoomerKuwangerHeartTank.Checked,
                AcquiredHeartTankChillPenguin = checkBoxChillPenguinHeartTank.Checked,
                AcquiredHeartTankFlameMammoth = checkBoxFlameMammothHeartTank.Checked,
                AcquiredHeartTankLaunchOctopus = checkBoxLaunchOctopusHeartTank.Checked,
                AcquiredHeartTankSparkMandrill = checkBoxSparkMandrillHeartTank.Checked,
                AcquiredHeartTankStingChameleon = checkBoxStingChameleonHeartTank.Checked,
                AcquiredHeartTankStormEagle = checkBoxStormEagleHeartTank.Checked,
                AcquiredHelmet = checkBoxHelmet.Checked,
                AcquiredSubTankArmoredArmadillo = checkBoxArmoredArmadilloSubTank.Checked,
                AcquiredSubTankFlameMammoth = checkBoxFlameMammothSubTank.Checked,
                AcquiredSubTankSparkMandrill = checkBoxSparkMandrillSubTank.Checked,
                AcquiredSubTankStormEagle = checkBoxStormEagleSubTank.Checked,
                AcquiredXBuster = checkBoxXBuster.Checked,
                DefeatedArmoredArmadillo = checkBoxArmoredArmadillo.Checked,
                DefeatedBoomerKuwanger = checkBoxBoomerKuwanger.Checked,
                DefeatedChillPenguin = checkBoxChillPenguin.Checked,
                DefeatedFlameMammoth = checkBoxFlamemammoth.Checked,
                DefeatedLaunchOctopus = checkBoxLaunchOctopus.Checked,
                DefeatedSparkMandrill = checkBoxSparkMandrill.Checked,
                DefeatedStingChameleon = checkBoxStingChameleon.Checked,
                DefeatedStormEagle = checkBoxStormEagle.Checked
            };

            passwordData.PasswordSet = comboBoxPasswordSet.SelectedIndex + 1;
            passwordData.GeneratePassword();

            textBoxPasswordLineX1Y1.Text = passwordData.X1Y1.ToString();
            textBoxPasswordLineX1Y2.Text = passwordData.X1Y2.ToString();
            textBoxPasswordLineX1Y3.Text = passwordData.X1Y3.ToString();

            textBoxPasswordLineX2Y1.Text = passwordData.X2Y1.ToString();
            textBoxPasswordLineX2Y2.Text = passwordData.X2Y2.ToString();
            textBoxPasswordLineX2Y3.Text = passwordData.X2Y3.ToString();

            textBoxPasswordLineX3Y1.Text = passwordData.X3Y1.ToString();
            textBoxPasswordLineX3Y2.Text = passwordData.X3Y2.ToString();
            textBoxPasswordLineX3Y3.Text = passwordData.X3Y3.ToString();

            textBoxPasswordLineX4Y1.Text = passwordData.X4Y1.ToString();
            textBoxPasswordLineX4Y2.Text = passwordData.X4Y2.ToString();
            textBoxPasswordLineX4Y3.Text = passwordData.X4Y3.ToString();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxPasswordLineX1Y1.Clear();
            textBoxPasswordLineX1Y2.Clear();
            textBoxPasswordLineX1Y3.Clear();

            textBoxPasswordLineX2Y1.Clear();
            textBoxPasswordLineX2Y2.Clear();
            textBoxPasswordLineX2Y3.Clear();

            textBoxPasswordLineX3Y1.Clear();
            textBoxPasswordLineX3Y2.Clear();
            textBoxPasswordLineX3Y3.Clear();

            textBoxPasswordLineX4Y1.Clear();
            textBoxPasswordLineX4Y2.Clear();
            textBoxPasswordLineX4Y3.Clear();

            checkBoxArmoredArmadillo.Checked = false;
            checkBoxArmor.Checked = false;
            checkBoxArmoredArmadilloHeartTank.Checked = false;
            checkBoxArmoredArmadilloSubTank.Checked = false;
            checkBoxBoomerKuwanger.Checked = false;
            checkBoxBoomerKuwangerHeartTank.Checked = false;
            checkBoxBoots.Checked = false;
            checkBoxChillPenguin.Checked = false;
            checkBoxChillPenguinHeartTank.Checked = false;
            checkBoxFlameMammothHeartTank.Checked = false;
            checkBoxFlamemammoth.Checked = false;
            checkBoxArmor.Checked = false;
            checkBoxFlameMammothSubTank.Checked = false;
            checkBoxHelmet.Checked = false;
            checkBoxLaunchOctopus.Checked = false;
            checkBoxLaunchOctopusHeartTank.Checked = false;
            checkBoxSparkMandrill.Checked = false;
            checkBoxSparkMandrillHeartTank.Checked = false;
            checkBoxSparkMandrillSubTank.Checked = false;
            checkBoxStingChameleon.Checked = false;
            checkBoxStingChameleonHeartTank.Checked = false;
            checkBoxStormEagle.Checked = false;
            checkBoxStormEagleHeartTank.Checked = false;
            checkBoxStormEagleSubTank.Checked = false;
            checkBoxXBuster.Checked = false;
        }
    }
}
