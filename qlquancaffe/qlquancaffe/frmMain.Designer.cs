namespace qlquancaffe
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            quanrToolStripMenuItem = new ToolStripMenuItem();
            errorProvider1 = new ErrorProvider(components);
            khuVựcToolStripMenuItem = new ToolStripMenuItem();
            đồUốngToolStripMenuItem = new ToolStripMenuItem();
            nhânViênToolStripMenuItem = new ToolStripMenuItem();
            loginToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem, quanrToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { loginToolStripMenuItem });
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(50, 20);
            menuToolStripMenuItem.Text = "Menu";
            // 
            // quanrToolStripMenuItem
            // 
            quanrToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { khuVựcToolStripMenuItem, đồUốngToolStripMenuItem, nhânViênToolStripMenuItem });
            quanrToolStripMenuItem.Name = "quanrToolStripMenuItem";
            quanrToolStripMenuItem.Size = new Size(58, 20);
            quanrToolStripMenuItem.Text = "quản lý";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // khuVựcToolStripMenuItem
            // 
            khuVựcToolStripMenuItem.Name = "khuVựcToolStripMenuItem";
            khuVựcToolStripMenuItem.Size = new Size(180, 22);
            khuVựcToolStripMenuItem.Text = "khu vực";
            // 
            // đồUốngToolStripMenuItem
            // 
            đồUốngToolStripMenuItem.Name = "đồUốngToolStripMenuItem";
            đồUốngToolStripMenuItem.Size = new Size(180, 22);
            đồUốngToolStripMenuItem.Text = "đồ uống";
            // 
            // nhânViênToolStripMenuItem
            // 
            nhânViênToolStripMenuItem.Name = "nhânViênToolStripMenuItem";
            nhânViênToolStripMenuItem.Size = new Size(180, 22);
            nhânViênToolStripMenuItem.Text = "nhân viên";
            // 
            // loginToolStripMenuItem
            // 
            loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            loginToolStripMenuItem.Size = new Size(180, 22);
            loginToolStripMenuItem.Text = "login";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "frmMain";
            Text = "frmMain";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem loginToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem quanrToolStripMenuItem;
        private ToolStripMenuItem khuVựcToolStripMenuItem;
        private ToolStripMenuItem đồUốngToolStripMenuItem;
        private ToolStripMenuItem nhânViênToolStripMenuItem;
        private ErrorProvider errorProvider1;
    }
}