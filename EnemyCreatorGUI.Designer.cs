namespace Enemy_Creator
{
    partial class EnemyCreatorGUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.enemyDefense = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.enemyMaxHp = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.enemySize = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.remoteTexture = new System.Windows.Forms.TextBox();
            this.index = new System.Windows.Forms.TextBox();
            this.textureFile = new System.Windows.Forms.TextBox();
            this.enemyId = new System.Windows.Forms.TextBox();
            this.enemyName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TriggerTexture = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.xpMultBox = new System.Windows.Forms.TextBox();
            this.questButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // enemyDefense
            // 
            this.enemyDefense.Location = new System.Drawing.Point(85, 189);
            this.enemyDefense.Name = "enemyDefense";
            this.enemyDefense.Size = new System.Drawing.Size(129, 20);
            this.enemyDefense.TabIndex = 249;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 192);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(47, 13);
            this.label20.TabIndex = 248;
            this.label20.Text = "Defense";
            // 
            // enemyMaxHp
            // 
            this.enemyMaxHp.Location = new System.Drawing.Point(85, 158);
            this.enemyMaxHp.Name = "enemyMaxHp";
            this.enemyMaxHp.Size = new System.Drawing.Size(129, 20);
            this.enemyMaxHp.TabIndex = 247;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 161);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(70, 13);
            this.label19.TabIndex = 246;
            this.label19.Text = "Health Points";
            // 
            // enemySize
            // 
            this.enemySize.Location = new System.Drawing.Point(85, 126);
            this.enemySize.Name = "enemySize";
            this.enemySize.Size = new System.Drawing.Size(129, 20);
            this.enemySize.TabIndex = 245;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 129);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(74, 13);
            this.label18.TabIndex = 244;
            this.label18.Text = "Size of Enemy";
            // 
            // remoteTexture
            // 
            this.remoteTexture.Location = new System.Drawing.Point(147, 85);
            this.remoteTexture.Name = "remoteTexture";
            this.remoteTexture.Size = new System.Drawing.Size(129, 20);
            this.remoteTexture.TabIndex = 241;
            this.remoteTexture.Visible = false;
            // 
            // index
            // 
            this.index.Location = new System.Drawing.Point(264, 85);
            this.index.Name = "index";
            this.index.Size = new System.Drawing.Size(129, 20);
            this.index.TabIndex = 239;
            // 
            // textureFile
            // 
            this.textureFile.Location = new System.Drawing.Point(29, 85);
            this.textureFile.Name = "textureFile";
            this.textureFile.Size = new System.Drawing.Size(129, 20);
            this.textureFile.TabIndex = 238;
            // 
            // enemyId
            // 
            this.enemyId.Location = new System.Drawing.Point(264, 24);
            this.enemyId.Name = "enemyId";
            this.enemyId.Size = new System.Drawing.Size(129, 20);
            this.enemyId.TabIndex = 236;
            // 
            // enemyName
            // 
            this.enemyName.Location = new System.Drawing.Point(29, 24);
            this.enemyName.Name = "enemyName";
            this.enemyName.Size = new System.Drawing.Size(129, 20);
            this.enemyName.TabIndex = 233;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(171, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 243;
            this.label5.Text = "Remote Texture";
            this.label5.Visible = false;
            // 
            // TriggerTexture
            // 
            this.TriggerTexture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TriggerTexture.Location = new System.Drawing.Point(174, 21);
            this.TriggerTexture.Name = "TriggerTexture";
            this.TriggerTexture.Size = new System.Drawing.Size(80, 23);
            this.TriggerTexture.TabIndex = 242;
            this.TriggerTexture.Text = "Remote";
            this.TriggerTexture.UseVisualStyleBackColor = true;
            this.TriggerTexture.Click += new System.EventHandler(this.TriggerTexture_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(313, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 240;
            this.label4.Text = "Index";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 237;
            this.label3.Text = "Texture File";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(320, 8);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(16, 13);
            this.label35.TabIndex = 235;
            this.label35.Text = "Id";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(73, 8);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(35, 13);
            this.label36.TabIndex = 234;
            this.label36.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 251;
            this.label1.Text = "Shadow Size";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(85, 221);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(129, 20);
            this.textBox1.TabIndex = 252;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(147, 469);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 23);
            this.button1.TabIndex = 253;
            this.button1.Text = "Create Enemy";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 256;
            this.label2.Text = "XpMult";
            // 
            // xpMultBox
            // 
            this.xpMultBox.Location = new System.Drawing.Point(85, 255);
            this.xpMultBox.Name = "xpMultBox";
            this.xpMultBox.Size = new System.Drawing.Size(129, 20);
            this.xpMultBox.TabIndex = 257;
            // 
            // questButton
            // 
            this.questButton.Location = new System.Drawing.Point(261, 124);
            this.questButton.Name = "questButton";
            this.questButton.Size = new System.Drawing.Size(75, 23);
            this.questButton.TabIndex = 258;
            this.questButton.Text = "Quest?";
            this.questButton.UseVisualStyleBackColor = true;
            this.questButton.Click += new System.EventHandler(this.questButton_Click);
            // 
            // EnemyCreatorGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(406, 504);
            this.Controls.Add(this.questButton);
            this.Controls.Add(this.xpMultBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.enemyDefense);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.enemyMaxHp);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.enemySize);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.remoteTexture);
            this.Controls.Add(this.index);
            this.Controls.Add(this.textureFile);
            this.Controls.Add(this.enemyId);
            this.Controls.Add(this.enemyName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TriggerTexture);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label35);
            this.Controls.Add(this.label36);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "EnemyCreatorGUI";
            this.Text = "Enemy Creator - Versified";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox enemyDefense;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox enemyMaxHp;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox enemySize;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox remoteTexture;
        private System.Windows.Forms.TextBox index;
        private System.Windows.Forms.TextBox textureFile;
        private System.Windows.Forms.TextBox enemyId;
        private System.Windows.Forms.TextBox enemyName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button TriggerTexture;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox xpMultBox;
        private System.Windows.Forms.Button questButton;
    }
}

