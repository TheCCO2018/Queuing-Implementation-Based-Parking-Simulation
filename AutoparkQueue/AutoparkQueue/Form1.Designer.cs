namespace AutoparkQueue
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MainPanel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.topPanel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.exitBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.SecondPanel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.listView2 = new System.Windows.Forms.ListView();
            this.listView1 = new System.Windows.Forms.ListView();
            this.btnAracEkle = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnAracsil = new Bunifu.Framework.UI.BunifuThinButton2();
            this.MainPanel.SuspendLayout();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exitBtn)).BeginInit();
            this.SecondPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.MainPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MainPanel.BackgroundImage")));
            this.MainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MainPanel.Controls.Add(this.bunifuThinButton21);
            this.MainPanel.Controls.Add(this.bunifuCustomLabel2);
            this.MainPanel.Controls.Add(this.bunifuCustomLabel1);
            this.MainPanel.GradientBottomLeft = System.Drawing.Color.White;
            this.MainPanel.GradientBottomRight = System.Drawing.Color.White;
            this.MainPanel.GradientTopLeft = System.Drawing.Color.White;
            this.MainPanel.GradientTopRight = System.Drawing.Color.White;
            this.MainPanel.Location = new System.Drawing.Point(0, 40);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Quality = 10;
            this.MainPanel.Size = new System.Drawing.Size(800, 460);
            this.MainPanel.TabIndex = 0;
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.DodgerBlue;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.DodgerBlue;
            this.bunifuThinButton21.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Devam Et";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.DodgerBlue;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.DodgerBlue;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.DodgerBlue;
            this.bunifuThinButton21.Location = new System.Drawing.Point(605, 396);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(181, 41);
            this.bunifuThinButton21.TabIndex = 2;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(26, 115);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(744, 230);
            this.bunifuCustomLabel2.TabIndex = 1;
            this.bunifuCustomLabel2.Text = "Otopark Similasyon Sistemini\r\nkullanmak için Devam Et\r\n\r\nOnat Aktaş-Cengiz Cebeci" +
    "-Canberk Ateş\r\n\r\n";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(27, 27);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(190, 39);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "Hoşgeldin !";
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.topPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("topPanel.BackgroundImage")));
            this.topPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.topPanel.Controls.Add(this.exitBtn);
            this.topPanel.GradientBottomLeft = System.Drawing.Color.DodgerBlue;
            this.topPanel.GradientBottomRight = System.Drawing.Color.DodgerBlue;
            this.topPanel.GradientTopLeft = System.Drawing.Color.DodgerBlue;
            this.topPanel.GradientTopRight = System.Drawing.Color.DodgerBlue;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Quality = 10;
            this.topPanel.Size = new System.Drawing.Size(800, 40);
            this.topPanel.TabIndex = 1;
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.exitBtn.Image = ((System.Drawing.Image)(resources.GetObject("exitBtn.Image")));
            this.exitBtn.ImageActive = null;
            this.exitBtn.Location = new System.Drawing.Point(757, 3);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(40, 34);
            this.exitBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exitBtn.TabIndex = 0;
            this.exitBtn.TabStop = false;
            this.exitBtn.Zoom = 10;
            this.exitBtn.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.topPanel;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // SecondPanel
            // 
            this.SecondPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SecondPanel.BackgroundImage")));
            this.SecondPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SecondPanel.Controls.Add(this.btnAracsil);
            this.SecondPanel.Controls.Add(this.btnAracEkle);
            this.SecondPanel.Controls.Add(this.listView2);
            this.SecondPanel.Controls.Add(this.listView1);
            this.SecondPanel.GradientBottomLeft = System.Drawing.Color.White;
            this.SecondPanel.GradientBottomRight = System.Drawing.Color.White;
            this.SecondPanel.GradientTopLeft = System.Drawing.Color.White;
            this.SecondPanel.GradientTopRight = System.Drawing.Color.White;
            this.SecondPanel.Location = new System.Drawing.Point(0, 40);
            this.SecondPanel.Name = "SecondPanel";
            this.SecondPanel.Quality = 10;
            this.SecondPanel.Size = new System.Drawing.Size(800, 460);
            this.SecondPanel.TabIndex = 2;
            // 
            // listView2
            // 
            this.listView2.Location = new System.Drawing.Point(464, 27);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(324, 174);
            this.listView2.TabIndex = 1;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(12, 27);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(324, 174);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // btnAracEkle
            // 
            this.btnAracEkle.ActiveBorderThickness = 1;
            this.btnAracEkle.ActiveCornerRadius = 20;
            this.btnAracEkle.ActiveFillColor = System.Drawing.Color.DodgerBlue;
            this.btnAracEkle.ActiveForecolor = System.Drawing.Color.White;
            this.btnAracEkle.ActiveLineColor = System.Drawing.Color.DodgerBlue;
            this.btnAracEkle.BackColor = System.Drawing.SystemColors.Control;
            this.btnAracEkle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAracEkle.BackgroundImage")));
            this.btnAracEkle.ButtonText = "Araç Ekle";
            this.btnAracEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAracEkle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAracEkle.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnAracEkle.IdleBorderThickness = 1;
            this.btnAracEkle.IdleCornerRadius = 20;
            this.btnAracEkle.IdleFillColor = System.Drawing.Color.White;
            this.btnAracEkle.IdleForecolor = System.Drawing.Color.DodgerBlue;
            this.btnAracEkle.IdleLineColor = System.Drawing.Color.DodgerBlue;
            this.btnAracEkle.Location = new System.Drawing.Point(310, 209);
            this.btnAracEkle.Margin = new System.Windows.Forms.Padding(5);
            this.btnAracEkle.Name = "btnAracEkle";
            this.btnAracEkle.Size = new System.Drawing.Size(181, 41);
            this.btnAracEkle.TabIndex = 2;
            this.btnAracEkle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAracEkle.Click += new System.EventHandler(this.btnAracEkle_Click);
            // 
            // btnAracsil
            // 
            this.btnAracsil.ActiveBorderThickness = 1;
            this.btnAracsil.ActiveCornerRadius = 20;
            this.btnAracsil.ActiveFillColor = System.Drawing.Color.DodgerBlue;
            this.btnAracsil.ActiveForecolor = System.Drawing.Color.White;
            this.btnAracsil.ActiveLineColor = System.Drawing.Color.DodgerBlue;
            this.btnAracsil.BackColor = System.Drawing.SystemColors.Control;
            this.btnAracsil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAracsil.BackgroundImage")));
            this.btnAracsil.ButtonText = "Araç Sil";
            this.btnAracsil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAracsil.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAracsil.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnAracsil.IdleBorderThickness = 1;
            this.btnAracsil.IdleCornerRadius = 20;
            this.btnAracsil.IdleFillColor = System.Drawing.Color.White;
            this.btnAracsil.IdleForecolor = System.Drawing.Color.DodgerBlue;
            this.btnAracsil.IdleLineColor = System.Drawing.Color.DodgerBlue;
            this.btnAracsil.Location = new System.Drawing.Point(310, 260);
            this.btnAracsil.Margin = new System.Windows.Forms.Padding(5);
            this.btnAracsil.Name = "btnAracsil";
            this.btnAracsil.Size = new System.Drawing.Size(181, 41);
            this.btnAracsil.TabIndex = 3;
            this.btnAracsil.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAracsil.Click += new System.EventHandler(this.btnAracsil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.SecondPanel);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "C";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.topPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.exitBtn)).EndInit();
            this.SecondPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel MainPanel;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuGradientPanel topPanel;
        private Bunifu.Framework.UI.BunifuImageButton exitBtn;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private Bunifu.Framework.UI.BunifuGradientPanel SecondPanel;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ListView listView1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAracEkle;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAracsil;
    }
}

