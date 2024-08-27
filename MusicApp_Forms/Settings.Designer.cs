namespace MusicApp_Forms
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            panel2 = new Panel();
            label1 = new Label();
            MinApp_pb = new PictureBox();
            MaxApp_pb = new PictureBox();
            RestApp_pb = new PictureBox();
            CloseApp_pb = new PictureBox();
            panel3 = new Panel();
            label2 = new Label();
            panel1 = new Panel();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MinApp_pb).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MaxApp_pb).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RestApp_pb).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CloseApp_pb).BeginInit();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.Yellow;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(MinApp_pb);
            panel2.Controls.Add(MaxApp_pb);
            panel2.Controls.Add(RestApp_pb);
            panel2.Controls.Add(CloseApp_pb);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(412, 35);
            panel2.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(74, 19);
            label1.TabIndex = 16;
            label1.Text = "Settings";
            // 
            // MinApp_pb
            // 
            MinApp_pb.BackColor = Color.Yellow;
            MinApp_pb.BackgroundImage = (Image)resources.GetObject("MinApp_pb.BackgroundImage");
            MinApp_pb.BackgroundImageLayout = ImageLayout.Stretch;
            MinApp_pb.Location = new Point(271, 3);
            MinApp_pb.Name = "MinApp_pb";
            MinApp_pb.Size = new Size(30, 30);
            MinApp_pb.SizeMode = PictureBoxSizeMode.StretchImage;
            MinApp_pb.TabIndex = 13;
            MinApp_pb.TabStop = false;
            // 
            // MaxApp_pb
            // 
            MaxApp_pb.BackColor = Color.Yellow;
            MaxApp_pb.BackgroundImage = (Image)resources.GetObject("MaxApp_pb.BackgroundImage");
            MaxApp_pb.BackgroundImageLayout = ImageLayout.Stretch;
            MaxApp_pb.Location = new Point(343, 3);
            MaxApp_pb.Name = "MaxApp_pb";
            MaxApp_pb.Size = new Size(30, 30);
            MaxApp_pb.SizeMode = PictureBoxSizeMode.StretchImage;
            MaxApp_pb.TabIndex = 12;
            MaxApp_pb.TabStop = false;
            // 
            // RestApp_pb
            // 
            RestApp_pb.BackColor = Color.Yellow;
            RestApp_pb.BackgroundImage = (Image)resources.GetObject("RestApp_pb.BackgroundImage");
            RestApp_pb.BackgroundImageLayout = ImageLayout.Stretch;
            RestApp_pb.Location = new Point(307, 3);
            RestApp_pb.Name = "RestApp_pb";
            RestApp_pb.Size = new Size(30, 30);
            RestApp_pb.SizeMode = PictureBoxSizeMode.StretchImage;
            RestApp_pb.TabIndex = 11;
            RestApp_pb.TabStop = false;
            // 
            // CloseApp_pb
            // 
            CloseApp_pb.BackColor = Color.Yellow;
            CloseApp_pb.BackgroundImage = (Image)resources.GetObject("CloseApp_pb.BackgroundImage");
            CloseApp_pb.BackgroundImageLayout = ImageLayout.Stretch;
            CloseApp_pb.Location = new Point(379, 3);
            CloseApp_pb.Name = "CloseApp_pb";
            CloseApp_pb.Size = new Size(30, 30);
            CloseApp_pb.SizeMode = PictureBoxSizeMode.StretchImage;
            CloseApp_pb.TabIndex = 10;
            CloseApp_pb.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Yellow;
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(258, 34);
            panel3.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(142, 19);
            label2.TabIndex = 17;
            label2.Text = "Display Settings:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(panel3);
            panel1.ForeColor = Color.Yellow;
            panel1.Location = new Point(12, 54);
            panel1.Name = "panel1";
            panel1.Size = new Size(258, 262);
            panel1.TabIndex = 16;
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(412, 510);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Settings";
            Text = "Settings";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MinApp_pb).EndInit();
            ((System.ComponentModel.ISupportInitialize)MaxApp_pb).EndInit();
            ((System.ComponentModel.ISupportInitialize)RestApp_pb).EndInit();
            ((System.ComponentModel.ISupportInitialize)CloseApp_pb).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private PictureBox MinApp_pb;
        private PictureBox MaxApp_pb;
        private PictureBox RestApp_pb;
        private PictureBox CloseApp_pb;
        private Label label1;
        private Panel panel3;
        private Label label2;
        private Panel panel1;
    }
}