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
        public string Name { get; set; }
        public string Id { get; set; }
        public string File { get; set; }
        public string Index1 { get; set; }
        public bool Remote { get; set; }
        public string Remotetexture { get; set; }
        #endregion

        #region Enemy strings
        public string Size { get; set; }
        public string MaxHp { get; set; }
        public string Defense { get; set; }
        public string ShadowSize { get; set; }
        public string LevelForQuest { get; set; }
        #endregion

        #region Conditional Logic Questions
        public bool DialogQuest;
        public bool DialogGod;
        public bool DialogImmune;
        #endregion

        private void button1_Click_1 (object sender, EventArgs e)
        {
            Name = enemyName.Text;
            Id = enemyId.Text;
            File = textureFile.Text;
            Index1 = index.Text;
            Remotetexture = remoteTexture.Text;
            Size = enemySize.Text;
            MaxHp = enemyMaxHp.Text;
            Defense = enemyDefense.Text;
            ShadowSize = enemyShadowSize.Text;
            LevelForQuest = questLevel.Text;
            EnemyExecute();
        }
        public void EnemyExecute()
        {
            using (var writer = new StreamWriter("Enemy XML.txt", true))
            {
                writer.WriteLine(@"<Object type=""" + Id + @""" id=""" + Name + @""">");
                writer.WriteLine("<Enemy />");
                writer.WriteLine("<AnimatedTexture>");
                writer.WriteLine("<File>" + File + "</File><Index>" + Index1 + "</Index>");
                writer.WriteLine("<AnimatedTexture>");
                writer.WriteLine("<Size>" + Size + "</Size>");
                writer.WriteLine("<MaxHitPoints>" + MaxHp + "</MaxHitPoints>");
                writer.WriteLine("<Defense>" + Defense + "</Defense>");
                writer.WriteLine("<ShadowSize>" + ShadowSize + "</ShadowSize>");
                writer.WriteLine("");

                if (DialogQuest == true)
                {
                    writer.WriteLine("<Quest />");
                }

                if (DialogGod == true)
                {
                    writer.WriteLine("<God />");
                }

                if (DialogImmune == true)
                {
                    writer.WriteLine("<StasisImmune />");
                }
                writer.WriteLine("<Level>" + LevelForQuest + "</Level>");
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
                DialogQuest = true;
            }
            else
            {
                DialogQuest = false;
            }
        }

        private void godKill_Click(object sender, EventArgs e)
        {
            DialogResult result2 = MessageBox.Show("Do you want your enemy to count as a god kill?", "God Kill", MessageBoxButtons.YesNo);
            if (result2 == DialogResult.Yes)
            {
                DialogGod = true;
            }
            else
            {
                DialogGod = false;
            }
        }

        private void stasisImmune_Click(object sender, EventArgs e)
        {
            DialogResult result3 = MessageBox.Show("Do you want your enemy to be Stasis Immune?", "Stasis Immune", MessageBoxButtons.YesNo);
            if (result3 == DialogResult.Yes)
            {
                DialogImmune = true;
            }
            else
            {
                DialogImmune = false;
            }
        }
    }
}
