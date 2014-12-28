using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Enemy_Creator
{
    public partial class EnemyCreatorGUI : Form
    {
        public EnemyCreatorGUI()
        {
            InitializeComponent();
        }

        #region Just some strings ;D
        public static string name { get; set; }
        public static string id { get; set; }
        public static string file { get; set; }
        public static string index1 { get; set; }
        public static bool remote { get; set; }
        public static string remotetexture { get; set; }
        #endregion

        #region Enemy strings
        public static string size { get; set; }
        public static string maxHp { get; set; }
        public static string defense { get; set; }
        public static string shadowSize { get; set; }
        public static string levelForQuest { get; set; }
        #endregion

        #region Conditional Logic Questions
        public static bool dialogQuest;
        public static bool dialogGod;
        public static bool dialogImmune;
        #endregion

        private void button1_Click_1 (object sender, EventArgs e)
        {
            name = enemyName.Text;
            id = enemyId.Text;
            file = textureFile.Text;
            index1 = index.Text;
            remotetexture = remoteTexture.Text;
            size = enemySize.Text;
            maxHp = enemyMaxHp.Text;
            defense = enemyDefense.Text;
            shadowSize = enemyShadowSize.Text;
            levelForQuest = questLevel.Text;
            EnemyExecute();
        }
        public static void EnemyExecute()
        {
            using (var writer = new StreamWriter("Enemy XML.txt", true))
            {
                writer.WriteLine(@"<Object type=""" + id + @""" id=""" + name + @""">");
                writer.WriteLine("<Enemy />");
                writer.WriteLine("<AnimatedTexture>");
                writer.WriteLine("<File>" + file + "</File><Index>" + index1 + "</Index>");
                writer.WriteLine("<AnimatedTexture>");
                writer.WriteLine("<Size>" + size + "</Size>");
                writer.WriteLine("<MaxHitPoints>" + maxHp + "</MaxHitPoints>");
                writer.WriteLine("<Defense>" + defense + "</Defense>");
                writer.WriteLine("<ShadowSize>" + shadowSize + "</ShadowSize>");
                writer.WriteLine("");

                if (dialogQuest == true)
                {
                    writer.WriteLine("<Quest />");
                }
                else
                {
                    //
                }

                if (dialogGod == true)
                {
                    writer.WriteLine("<God />");
                }
                else
                {
                    //
                }

                if (dialogImmune == true)
                {
                    writer.WriteLine("<StasisImmune />");
                }
                else
                {
                    //
                }
                writer.WriteLine("<Level>" + levelForQuest + "</Level>");
            }
        }
        private void enemyQuest_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void TriggerTexture_Click(object sender, EventArgs e)
        {
            if (TriggerTexture.Text == "Client")
            {
                TriggerTexture.Text = "Remote";
                index.Visible = true;
                textureFile.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = false;
                remoteTexture.Visible = false;
            }
            else
            {
                TriggerTexture.Text = "Client";
                index.Visible = false;
                textureFile.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = true;
                remoteTexture.Visible = true;
            }
        }

        public void questButton_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Do you want your enemy to be a quest?", "Quest", MessageBoxButtons.YesNo);
            if (result1 == DialogResult.Yes)
            {
                dialogQuest = true;
            }
            else
            {
                dialogQuest = false;
            }
        }

        private void godKill_Click(object sender, EventArgs e)
        {
            DialogResult result2 = MessageBox.Show("Do you want your enemy to count as a god kill?", "God Kill", MessageBoxButtons.YesNo);
            if (result2 == DialogResult.Yes)
            {
                dialogGod = true;
            }
            else
            {
                dialogGod = false;
            }
        }

        private void stasisImmune_Click(object sender, EventArgs e)
        {
            DialogResult result3 = MessageBox.Show("Do you want your enemy to be Stasis Immune?", "Stasis Immune", MessageBoxButtons.YesNo);
            if (result3 == DialogResult.Yes)
            {
                dialogImmune = true;
            }
            else
            {
                dialogImmune = false;
            }
        }
    }
}
