namespace Quanlicaffe_HoangLTG
{
    partial class htableManger
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(htableManger));
            contextMenuStrip1 = new ContextMenuStrip(components);
            menuStrip1 = new MenuStrip();
            adminToolStripMenuItem = new ToolStripMenuItem();
            thôngTinCáNhânToolStripMenuItem = new ToolStripMenuItem();
            lịchLàmViệcToolStripMenuItem = new ToolStripMenuItem();
            báoCáoToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            panel6 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { adminToolStripMenuItem, thôngTinCáNhânToolStripMenuItem, lịchLàmViệcToolStripMenuItem, báoCáoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1010, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            adminToolStripMenuItem.Size = new Size(55, 20);
            adminToolStripMenuItem.Text = "Admin";
            // 
            // thôngTinCáNhânToolStripMenuItem
            // 
            thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
            thôngTinCáNhânToolStripMenuItem.Size = new Size(115, 20);
            thôngTinCáNhânToolStripMenuItem.Text = "Thông tin cá nhân";
            // 
            // lịchLàmViệcToolStripMenuItem
            // 
            lịchLàmViệcToolStripMenuItem.Name = "lịchLàmViệcToolStripMenuItem";
            lịchLàmViệcToolStripMenuItem.Size = new Size(85, 20);
            lịchLàmViệcToolStripMenuItem.Text = "lịch làm việc";
            // 
            // báoCáoToolStripMenuItem
            // 
            báoCáoToolStripMenuItem.Name = "báoCáoToolStripMenuItem";
            báoCáoToolStripMenuItem.Size = new Size(66, 20);
            báoCáoToolStripMenuItem.Text = "thống kê";
            // 
            // panel1
            // 
            panel1.Controls.Add(panel6);
            panel1.Location = new Point(0, 63);
            panel1.Name = "panel1";
            panel1.Size = new Size(699, 261);
            panel1.TabIndex = 4;
            // 
            // panel6
            // 
            panel6.Location = new Point(39, 30);
            panel6.Name = "panel6";
            panel6.Size = new Size(81, 55);
            panel6.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Location = new Point(0, 392);
            panel2.Name = "panel2";
            panel2.Size = new Size(699, 229);
            panel2.TabIndex = 6;
            // 
            // panel3
            // 
            panel3.Location = new Point(715, 63);
            panel3.Name = "panel3";
            panel3.Size = new Size(295, 476);
            panel3.TabIndex = 7;
            // 
            // panel4
            // 
            panel4.Location = new Point(715, 545);
            panel4.Name = "panel4";
            panel4.Size = new Size(295, 76);
            panel4.TabIndex = 8;
            // 
            // panel5
            // 
            panel5.Location = new Point(0, 330);
            panel5.Name = "panel5";
            panel5.Size = new Size(699, 56);
            panel5.TabIndex = 9;
            // 
            // htableManger
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1010, 620);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "htableManger";
            Text = "Hệ thống quản lí quán caffe";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem adminToolStripMenuItem;
        private ToolStripMenuItem thôngTinCáNhânToolStripMenuItem;
        private ToolStripMenuItem lịchLàmViệcToolStripMenuItem;
        private ToolStripMenuItem báoCáoToolStripMenuItem;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel6;
        private Panel panel5;
    }
}