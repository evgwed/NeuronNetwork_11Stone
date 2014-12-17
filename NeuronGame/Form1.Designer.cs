namespace NeuronNetwork
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonGetOne = new System.Windows.Forms.Button();
            this.buttonGetTwo = new System.Windows.Forms.Button();
            this.labelCountStone = new System.Windows.Forms.Label();
            this.label_Player_list = new System.Windows.Forms.Label();
            this.label_NS_list = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.trainerButton = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Statuslabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(473, 12);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Старт";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonGetOne
            // 
            this.buttonGetOne.Enabled = false;
            this.buttonGetOne.Location = new System.Drawing.Point(473, 42);
            this.buttonGetOne.Name = "buttonGetOne";
            this.buttonGetOne.Size = new System.Drawing.Size(75, 23);
            this.buttonGetOne.TabIndex = 1;
            this.buttonGetOne.Text = "Взять один";
            this.buttonGetOne.UseVisualStyleBackColor = true;
            this.buttonGetOne.Click += new System.EventHandler(this.buttonGetOne_Click);
            // 
            // buttonGetTwo
            // 
            this.buttonGetTwo.Enabled = false;
            this.buttonGetTwo.Location = new System.Drawing.Point(473, 72);
            this.buttonGetTwo.Name = "buttonGetTwo";
            this.buttonGetTwo.Size = new System.Drawing.Size(75, 23);
            this.buttonGetTwo.TabIndex = 2;
            this.buttonGetTwo.Text = "Взять два";
            this.buttonGetTwo.UseVisualStyleBackColor = true;
            this.buttonGetTwo.Click += new System.EventHandler(this.buttonGetTwo_Click);
            // 
            // labelCountStone
            // 
            this.labelCountStone.AutoSize = true;
            this.labelCountStone.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCountStone.Location = new System.Drawing.Point(221, 12);
            this.labelCountStone.Name = "labelCountStone";
            this.labelCountStone.Size = new System.Drawing.Size(106, 73);
            this.labelCountStone.TabIndex = 3;
            this.labelCountStone.Text = "11";
            // 
            // label_Player_list
            // 
            this.label_Player_list.AutoSize = true;
            this.label_Player_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Player_list.Location = new System.Drawing.Point(6, 16);
            this.label_Player_list.Name = "label_Player_list";
            this.label_Player_list.Size = new System.Drawing.Size(0, 13);
            this.label_Player_list.TabIndex = 6;
            // 
            // label_NS_list
            // 
            this.label_NS_list.AutoSize = true;
            this.label_NS_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_NS_list.Location = new System.Drawing.Point(18, 16);
            this.label_NS_list.Name = "label_NS_list";
            this.label_NS_list.Size = new System.Drawing.Size(0, 13);
            this.label_NS_list.TabIndex = 7;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.Statuslabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 345);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(560, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trainerButton,
            this.toolStripMenuItem1});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(29, 20);
            this.toolStripDropDownButton1.Text = "Меню";
            // 
            // trainerButton
            // 
            this.trainerButton.Name = "trainerButton";
            this.trainerButton.Size = new System.Drawing.Size(170, 22);
            this.trainerButton.Text = "Запустить тренер";
            this.trainerButton.Click += new System.EventHandler(this.trainerButton_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(170, 22);
            this.toolStripMenuItem1.Text = "О программе";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // Statuslabel
            // 
            this.Statuslabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Statuslabel.ForeColor = System.Drawing.Color.Black;
            this.Statuslabel.Name = "Statuslabel";
            this.Statuslabel.Size = new System.Drawing.Size(0, 17);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(196, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Количество оставшихся камней";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_NS_list);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 220);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Действия НС:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label_Player_list);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(284, 113);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(264, 220);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Действия пользователя";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 367);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.labelCountStone);
            this.Controls.Add(this.buttonGetTwo);
            this.Controls.Add(this.buttonGetOne);
            this.Controls.Add(this.buttonStart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Игра 11 камней на основе НС";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonGetOne;
        private System.Windows.Forms.Button buttonGetTwo;
        private System.Windows.Forms.Label labelCountStone;
        private System.Windows.Forms.Label label_Player_list;
        private System.Windows.Forms.Label label_NS_list;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel Statuslabel;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem trainerButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

