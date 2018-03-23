namespace AutoparkQueue
{
    partial class Form_Screen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Screen));
            this.pnlWelcome = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.lblWelcomeContext7 = new System.Windows.Forms.Label();
            this.lblWelcomeContext6 = new System.Windows.Forms.Label();
            this.lblWelcomeContext5 = new System.Windows.Forms.Label();
            this.lblWelcomeContext4 = new System.Windows.Forms.Label();
            this.lblWelcomeContext3 = new System.Windows.Forms.Label();
            this.lblWelcomeContext2 = new System.Windows.Forms.Label();
            this.lblWelcomeContext1 = new System.Windows.Forms.Label();
            this.lblWelcomHead = new System.Windows.Forms.Label();
            this.btnDevamEt = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pnlMainOperations = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.mlvwTablesOfCars = new MaterialSkin.Controls.MaterialListView();
            this.numbOfCar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.carPlate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.parkedTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.exitFIFOTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.exitPQTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ilistResult = new System.Windows.Forms.ImageList(this.components);
            this.pnlPQEmptyInfo = new Bunifu.Framework.UI.BunifuTileButton();
            this.pnlFIFOEmptyInfo = new Bunifu.Framework.UI.BunifuTileButton();
            this.lvwSimpleQueue = new System.Windows.Forms.ListView();
            this.ilistFIFO = new System.Windows.Forms.ImageList(this.components);
            this.btnRemoveCar = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnAddCar = new Bunifu.Framework.UI.BunifuImageButton();
            this.pnlInformations = new System.Windows.Forms.Panel();
            this.picPQExitIcon = new System.Windows.Forms.PictureBox();
            this.lblPQQueuedCar = new System.Windows.Forms.Label();
            this.picPQQueuedCar = new System.Windows.Forms.PictureBox();
            this.lblPQLeavingCar = new System.Windows.Forms.Label();
            this.picPQLeavingCar = new System.Windows.Forms.PictureBox();
            this.picPQInlinedIcon = new System.Windows.Forms.PictureBox();
            this.picFIFOExitIcon = new System.Windows.Forms.PictureBox();
            this.lblFIFOInlinedCarInfo = new System.Windows.Forms.Label();
            this.picFIFOQueuedCar = new System.Windows.Forms.PictureBox();
            this.lblFIFOLeavingCarInfo = new System.Windows.Forms.Label();
            this.picFIFOLeavingCar = new System.Windows.Forms.PictureBox();
            this.picFIFOInlinedIcon = new System.Windows.Forms.PictureBox();
            this.lvwPriorityQueue = new System.Windows.Forms.ListView();
            this.ilistPQ = new System.Windows.Forms.ImageList(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.pnlControl = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnExit = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnlWelcome.SuspendLayout();
            this.pnlMainOperations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRemoveCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddCar)).BeginInit();
            this.pnlInformations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPQExitIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPQQueuedCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPQLeavingCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPQInlinedIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFIFOExitIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFIFOQueuedCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFIFOLeavingCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFIFOInlinedIcon)).BeginInit();
            this.pnlControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlWelcome
            // 
            this.pnlWelcome.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlWelcome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlWelcome.BackgroundImage")));
            this.pnlWelcome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlWelcome.Controls.Add(this.lblWelcomeContext7);
            this.pnlWelcome.Controls.Add(this.lblWelcomeContext6);
            this.pnlWelcome.Controls.Add(this.lblWelcomeContext5);
            this.pnlWelcome.Controls.Add(this.lblWelcomeContext4);
            this.pnlWelcome.Controls.Add(this.lblWelcomeContext3);
            this.pnlWelcome.Controls.Add(this.lblWelcomeContext2);
            this.pnlWelcome.Controls.Add(this.lblWelcomeContext1);
            this.pnlWelcome.Controls.Add(this.lblWelcomHead);
            this.pnlWelcome.Controls.Add(this.btnDevamEt);
            this.pnlWelcome.GradientBottomLeft = System.Drawing.Color.White;
            this.pnlWelcome.GradientBottomRight = System.Drawing.Color.White;
            this.pnlWelcome.GradientTopLeft = System.Drawing.Color.White;
            this.pnlWelcome.GradientTopRight = System.Drawing.Color.White;
            this.pnlWelcome.Location = new System.Drawing.Point(0, 25);
            this.pnlWelcome.Margin = new System.Windows.Forms.Padding(0);
            this.pnlWelcome.Name = "pnlWelcome";
            this.pnlWelcome.Quality = 10;
            this.pnlWelcome.Size = new System.Drawing.Size(800, 475);
            this.pnlWelcome.TabIndex = 0;
            // 
            // lblWelcomeContext7
            // 
            this.lblWelcomeContext7.AutoSize = true;
            this.lblWelcomeContext7.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblWelcomeContext7.Location = new System.Drawing.Point(59, 326);
            this.lblWelcomeContext7.Name = "lblWelcomeContext7";
            this.lblWelcomeContext7.Size = new System.Drawing.Size(684, 30);
            this.lblWelcomeContext7.TabIndex = 10;
            this.lblWelcomeContext7.Text = "gereğince bir Otopark alan adı altında somutlaştırılmıştır.";
            // 
            // lblWelcomeContext6
            // 
            this.lblWelcomeContext6.AutoSize = true;
            this.lblWelcomeContext6.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblWelcomeContext6.Location = new System.Drawing.Point(59, 287);
            this.lblWelcomeContext6.Name = "lblWelcomeContext6";
            this.lblWelcomeContext6.Size = new System.Drawing.Size(712, 30);
            this.lblWelcomeContext6.TabIndex = 9;
            this.lblWelcomeContext6.Text = "işlemlerini gerçekleştirecektir. Tüm bu işlemler ödev içeriği ";
            // 
            // lblWelcomeContext5
            // 
            this.lblWelcomeContext5.AutoSize = true;
            this.lblWelcomeContext5.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblWelcomeContext5.Location = new System.Drawing.Point(59, 248);
            this.lblWelcomeContext5.Name = "lblWelcomeContext5";
            this.lblWelcomeContext5.Size = new System.Drawing.Size(734, 30);
            this.lblWelcomeContext5.TabIndex = 8;
            this.lblWelcomeContext5.Text = "gerçekleştirilince kuyruktan ayrılma sürelerinin karşılaştırılması";
            // 
            // lblWelcomeContext4
            // 
            this.lblWelcomeContext4.AutoSize = true;
            this.lblWelcomeContext4.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblWelcomeContext4.Location = new System.Drawing.Point(59, 210);
            this.lblWelcomeContext4.Name = "lblWelcomeContext4";
            this.lblWelcomeContext4.Size = new System.Drawing.Size(694, 30);
            this.lblWelcomeContext4.TabIndex = 7;
            this.lblWelcomeContext4.Text = "yapısında tutulan aynı verilerin kuyruktan ayrılma işlemleri";
            // 
            // lblWelcomeContext3
            // 
            this.lblWelcomeContext3.AutoSize = true;
            this.lblWelcomeContext3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblWelcomeContext3.Location = new System.Drawing.Point(59, 173);
            this.lblWelcomeContext3.Name = "lblWelcomeContext3";
            this.lblWelcomeContext3.Size = new System.Drawing.Size(670, 30);
            this.lblWelcomeContext3.TabIndex = 6;
            this.lblWelcomeContext3.Text = "Bu program basit bir kuyruk yapısı ile öncelikli bir kuyruk ";
            // 
            // lblWelcomeContext2
            // 
            this.lblWelcomeContext2.AutoSize = true;
            this.lblWelcomeContext2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblWelcomeContext2.Location = new System.Drawing.Point(59, 136);
            this.lblWelcomeContext2.Name = "lblWelcomeContext2";
            this.lblWelcomeContext2.Size = new System.Drawing.Size(664, 30);
            this.lblWelcomeContext2.TabIndex = 5;
            this.lblWelcomeContext2.Text = "Cengiz CEBECİ ve Onat AKTAŞ tarafından geliştirilmiştir.";
            // 
            // lblWelcomeContext1
            // 
            this.lblWelcomeContext1.AutoSize = true;
            this.lblWelcomeContext1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblWelcomeContext1.Location = new System.Drawing.Point(81, 98);
            this.lblWelcomeContext1.Name = "lblWelcomeContext1";
            this.lblWelcomeContext1.Size = new System.Drawing.Size(593, 30);
            this.lblWelcomeContext1.TabIndex = 4;
            this.lblWelcomeContext1.Text = "Bu program, Veri Yapıları dersi için Canberk Ateş,";
            // 
            // lblWelcomHead
            // 
            this.lblWelcomHead.AutoSize = true;
            this.lblWelcomHead.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblWelcomHead.Location = new System.Drawing.Point(58, 43);
            this.lblWelcomHead.Name = "lblWelcomHead";
            this.lblWelcomHead.Size = new System.Drawing.Size(170, 33);
            this.lblWelcomHead.TabIndex = 3;
            this.lblWelcomHead.Text = "Hoşgeldiniz!";
            // 
            // btnDevamEt
            // 
            this.btnDevamEt.ActiveBorderThickness = 1;
            this.btnDevamEt.ActiveCornerRadius = 20;
            this.btnDevamEt.ActiveFillColor = System.Drawing.Color.DodgerBlue;
            this.btnDevamEt.ActiveForecolor = System.Drawing.Color.White;
            this.btnDevamEt.ActiveLineColor = System.Drawing.Color.DodgerBlue;
            this.btnDevamEt.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDevamEt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDevamEt.BackgroundImage")));
            this.btnDevamEt.ButtonText = "Devam Et";
            this.btnDevamEt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDevamEt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDevamEt.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnDevamEt.IdleBorderThickness = 1;
            this.btnDevamEt.IdleCornerRadius = 20;
            this.btnDevamEt.IdleFillColor = System.Drawing.Color.White;
            this.btnDevamEt.IdleForecolor = System.Drawing.Color.DodgerBlue;
            this.btnDevamEt.IdleLineColor = System.Drawing.Color.DodgerBlue;
            this.btnDevamEt.Location = new System.Drawing.Point(641, 373);
            this.btnDevamEt.Margin = new System.Windows.Forms.Padding(4);
            this.btnDevamEt.Name = "btnDevamEt";
            this.btnDevamEt.Size = new System.Drawing.Size(146, 50);
            this.btnDevamEt.TabIndex = 2;
            this.btnDevamEt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDevamEt.Click += new System.EventHandler(this.btnDevamEt_Click);
            // 
            // pnlMainOperations
            // 
            this.pnlMainOperations.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlMainOperations.BackgroundImage")));
            this.pnlMainOperations.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlMainOperations.Controls.Add(this.mlvwTablesOfCars);
            this.pnlMainOperations.Controls.Add(this.pnlPQEmptyInfo);
            this.pnlMainOperations.Controls.Add(this.pnlFIFOEmptyInfo);
            this.pnlMainOperations.Controls.Add(this.lvwSimpleQueue);
            this.pnlMainOperations.Controls.Add(this.btnRemoveCar);
            this.pnlMainOperations.Controls.Add(this.btnAddCar);
            this.pnlMainOperations.Controls.Add(this.pnlInformations);
            this.pnlMainOperations.Controls.Add(this.lvwPriorityQueue);
            this.pnlMainOperations.GradientBottomLeft = System.Drawing.Color.White;
            this.pnlMainOperations.GradientBottomRight = System.Drawing.Color.White;
            this.pnlMainOperations.GradientTopLeft = System.Drawing.Color.White;
            this.pnlMainOperations.GradientTopRight = System.Drawing.Color.White;
            this.pnlMainOperations.Location = new System.Drawing.Point(0, 25);
            this.pnlMainOperations.Margin = new System.Windows.Forms.Padding(0);
            this.pnlMainOperations.Name = "pnlMainOperations";
            this.pnlMainOperations.Quality = 10;
            this.pnlMainOperations.Size = new System.Drawing.Size(800, 475);
            this.pnlMainOperations.TabIndex = 2;
            // 
            // mlvwTablesOfCars
            // 
            this.mlvwTablesOfCars.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.mlvwTablesOfCars.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mlvwTablesOfCars.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.numbOfCar,
            this.carPlate,
            this.parkedTime,
            this.exitFIFOTime,
            this.exitPQTime});
            this.mlvwTablesOfCars.Depth = 0;
            this.mlvwTablesOfCars.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mlvwTablesOfCars.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.mlvwTablesOfCars.ForeColor = System.Drawing.Color.White;
            this.mlvwTablesOfCars.FullRowSelect = true;
            this.mlvwTablesOfCars.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.mlvwTablesOfCars.HoverSelection = true;
            this.mlvwTablesOfCars.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.mlvwTablesOfCars.Location = new System.Drawing.Point(0, 294);
            this.mlvwTablesOfCars.Margin = new System.Windows.Forms.Padding(0);
            this.mlvwTablesOfCars.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mlvwTablesOfCars.MouseState = MaterialSkin.MouseState.OUT;
            this.mlvwTablesOfCars.Name = "mlvwTablesOfCars";
            this.mlvwTablesOfCars.OwnerDraw = true;
            this.mlvwTablesOfCars.Size = new System.Drawing.Size(800, 181);
            this.mlvwTablesOfCars.SmallImageList = this.ilistResult;
            this.mlvwTablesOfCars.TabIndex = 41;
            this.mlvwTablesOfCars.UseCompatibleStateImageBehavior = false;
            this.mlvwTablesOfCars.View = System.Windows.Forms.View.Details;
            // 
            // numbOfCar
            // 
            this.numbOfCar.Text = "#";
            this.numbOfCar.Width = 40;
            // 
            // carPlate
            // 
            this.carPlate.Text = "Plate";
            this.carPlate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.carPlate.Width = 140;
            // 
            // parkedTime
            // 
            this.parkedTime.Text = "Parked Time";
            this.parkedTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.parkedTime.Width = 215;
            // 
            // exitFIFOTime
            // 
            this.exitFIFOTime.Text = "Exit From FIFO";
            this.exitFIFOTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.exitFIFOTime.Width = 200;
            // 
            // exitPQTime
            // 
            this.exitPQTime.Text = "Exit From PQ";
            this.exitPQTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.exitPQTime.Width = 205;
            // 
            // ilistResult
            // 
            this.ilistResult.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilistResult.ImageStream")));
            this.ilistResult.TransparentColor = System.Drawing.Color.Transparent;
            this.ilistResult.Images.SetKeyName(0, "car-0.png");
            this.ilistResult.Images.SetKeyName(1, "car-1.png");
            this.ilistResult.Images.SetKeyName(2, "car-2.png");
            this.ilistResult.Images.SetKeyName(3, "Car-3.png");
            this.ilistResult.Images.SetKeyName(4, "car-4.png");
            this.ilistResult.Images.SetKeyName(5, "car-5.png");
            this.ilistResult.Images.SetKeyName(6, "car-6.png");
            this.ilistResult.Images.SetKeyName(7, "car-7.png");
            this.ilistResult.Images.SetKeyName(8, "car-8.png");
            this.ilistResult.Images.SetKeyName(9, "car-9.png");
            this.ilistResult.Images.SetKeyName(10, "car-10.png");
            this.ilistResult.Images.SetKeyName(11, "car-11.png");
            this.ilistResult.Images.SetKeyName(12, "car-12.png");
            this.ilistResult.Images.SetKeyName(13, "car-13.png");
            this.ilistResult.Images.SetKeyName(14, "car-14.png");
            // 
            // pnlPQEmptyInfo
            // 
            this.pnlPQEmptyInfo.BackColor = System.Drawing.Color.Transparent;
            this.pnlPQEmptyInfo.color = System.Drawing.Color.Transparent;
            this.pnlPQEmptyInfo.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.pnlPQEmptyInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlPQEmptyInfo.Enabled = false;
            this.pnlPQEmptyInfo.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.pnlPQEmptyInfo.ForeColor = System.Drawing.Color.Black;
            this.pnlPQEmptyInfo.Image = ((System.Drawing.Image)(resources.GetObject("pnlPQEmptyInfo.Image")));
            this.pnlPQEmptyInfo.ImagePosition = 20;
            this.pnlPQEmptyInfo.ImageZoom = 20;
            this.pnlPQEmptyInfo.LabelPosition = 41;
            this.pnlPQEmptyInfo.LabelText = "The Autopark has no cars";
            this.pnlPQEmptyInfo.Location = new System.Drawing.Point(420, 37);
            this.pnlPQEmptyInfo.Margin = new System.Windows.Forms.Padding(6);
            this.pnlPQEmptyInfo.Name = "pnlPQEmptyInfo";
            this.pnlPQEmptyInfo.Size = new System.Drawing.Size(370, 150);
            this.pnlPQEmptyInfo.TabIndex = 40;
            // 
            // pnlFIFOEmptyInfo
            // 
            this.pnlFIFOEmptyInfo.BackColor = System.Drawing.Color.Transparent;
            this.pnlFIFOEmptyInfo.color = System.Drawing.Color.Transparent;
            this.pnlFIFOEmptyInfo.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.pnlFIFOEmptyInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlFIFOEmptyInfo.Enabled = false;
            this.pnlFIFOEmptyInfo.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.pnlFIFOEmptyInfo.ForeColor = System.Drawing.Color.Black;
            this.pnlFIFOEmptyInfo.Image = ((System.Drawing.Image)(resources.GetObject("pnlFIFOEmptyInfo.Image")));
            this.pnlFIFOEmptyInfo.ImagePosition = 20;
            this.pnlFIFOEmptyInfo.ImageZoom = 20;
            this.pnlFIFOEmptyInfo.LabelPosition = 41;
            this.pnlFIFOEmptyInfo.LabelText = "The Autopark has no cars";
            this.pnlFIFOEmptyInfo.Location = new System.Drawing.Point(10, 37);
            this.pnlFIFOEmptyInfo.Margin = new System.Windows.Forms.Padding(6);
            this.pnlFIFOEmptyInfo.Name = "pnlFIFOEmptyInfo";
            this.pnlFIFOEmptyInfo.Size = new System.Drawing.Size(370, 150);
            this.pnlFIFOEmptyInfo.TabIndex = 1;
            // 
            // lvwSimpleQueue
            // 
            this.lvwSimpleQueue.LargeImageList = this.ilistFIFO;
            this.lvwSimpleQueue.Location = new System.Drawing.Point(10, 37);
            this.lvwSimpleQueue.Margin = new System.Windows.Forms.Padding(0);
            this.lvwSimpleQueue.Name = "lvwSimpleQueue";
            this.lvwSimpleQueue.Size = new System.Drawing.Size(370, 150);
            this.lvwSimpleQueue.TabIndex = 0;
            this.lvwSimpleQueue.UseCompatibleStateImageBehavior = false;
            // 
            // ilistFIFO
            // 
            this.ilistFIFO.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.ilistFIFO.ImageSize = new System.Drawing.Size(40, 40);
            this.ilistFIFO.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btnRemoveCar
            // 
            this.btnRemoveCar.BackColor = System.Drawing.Color.Transparent;
            this.btnRemoveCar.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoveCar.Image")));
            this.btnRemoveCar.ImageActive = null;
            this.btnRemoveCar.Location = new System.Drawing.Point(383, 111);
            this.btnRemoveCar.Margin = new System.Windows.Forms.Padding(0);
            this.btnRemoveCar.Name = "btnRemoveCar";
            this.btnRemoveCar.Size = new System.Drawing.Size(35, 35);
            this.btnRemoveCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRemoveCar.TabIndex = 38;
            this.btnRemoveCar.TabStop = false;
            this.btnRemoveCar.Zoom = 10;
            this.btnRemoveCar.Click += new System.EventHandler(this.btnAracsil_Click);
            // 
            // btnAddCar
            // 
            this.btnAddCar.BackColor = System.Drawing.Color.Transparent;
            this.btnAddCar.Image = ((System.Drawing.Image)(resources.GetObject("btnAddCar.Image")));
            this.btnAddCar.ImageActive = null;
            this.btnAddCar.Location = new System.Drawing.Point(383, 70);
            this.btnAddCar.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddCar.Name = "btnAddCar";
            this.btnAddCar.Size = new System.Drawing.Size(35, 35);
            this.btnAddCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAddCar.TabIndex = 37;
            this.btnAddCar.TabStop = false;
            this.btnAddCar.Zoom = 10;
            this.btnAddCar.Click += new System.EventHandler(this.btnAracEkle_Click);
            // 
            // pnlInformations
            // 
            this.pnlInformations.BackColor = System.Drawing.Color.Transparent;
            this.pnlInformations.Controls.Add(this.picPQExitIcon);
            this.pnlInformations.Controls.Add(this.lblPQQueuedCar);
            this.pnlInformations.Controls.Add(this.picPQQueuedCar);
            this.pnlInformations.Controls.Add(this.lblPQLeavingCar);
            this.pnlInformations.Controls.Add(this.picPQLeavingCar);
            this.pnlInformations.Controls.Add(this.picPQInlinedIcon);
            this.pnlInformations.Controls.Add(this.picFIFOExitIcon);
            this.pnlInformations.Controls.Add(this.lblFIFOInlinedCarInfo);
            this.pnlInformations.Controls.Add(this.picFIFOQueuedCar);
            this.pnlInformations.Controls.Add(this.lblFIFOLeavingCarInfo);
            this.pnlInformations.Controls.Add(this.picFIFOLeavingCar);
            this.pnlInformations.Controls.Add(this.picFIFOInlinedIcon);
            this.pnlInformations.Location = new System.Drawing.Point(10, 191);
            this.pnlInformations.Name = "pnlInformations";
            this.pnlInformations.Size = new System.Drawing.Size(780, 92);
            this.pnlInformations.TabIndex = 36;
            this.pnlInformations.Visible = false;
            // 
            // picPQExitIcon
            // 
            this.picPQExitIcon.BackColor = System.Drawing.Color.Transparent;
            this.picPQExitIcon.Image = ((System.Drawing.Image)(resources.GetObject("picPQExitIcon.Image")));
            this.picPQExitIcon.Location = new System.Drawing.Point(410, 1);
            this.picPQExitIcon.Name = "picPQExitIcon";
            this.picPQExitIcon.Size = new System.Drawing.Size(40, 40);
            this.picPQExitIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPQExitIcon.TabIndex = 37;
            this.picPQExitIcon.TabStop = false;
            // 
            // lblPQQueuedCar
            // 
            this.lblPQQueuedCar.AutoSize = true;
            this.lblPQQueuedCar.BackColor = System.Drawing.Color.Transparent;
            this.lblPQQueuedCar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPQQueuedCar.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblPQQueuedCar.Location = new System.Drawing.Point(502, 59);
            this.lblPQQueuedCar.Name = "lblPQQueuedCar";
            this.lblPQQueuedCar.Size = new System.Drawing.Size(0, 21);
            this.lblPQQueuedCar.TabIndex = 40;
            // 
            // picPQQueuedCar
            // 
            this.picPQQueuedCar.BackColor = System.Drawing.Color.Transparent;
            this.picPQQueuedCar.Location = new System.Drawing.Point(456, 47);
            this.picPQQueuedCar.Name = "picPQQueuedCar";
            this.picPQQueuedCar.Size = new System.Drawing.Size(40, 40);
            this.picPQQueuedCar.TabIndex = 35;
            this.picPQQueuedCar.TabStop = false;
            // 
            // lblPQLeavingCar
            // 
            this.lblPQLeavingCar.AutoSize = true;
            this.lblPQLeavingCar.BackColor = System.Drawing.Color.Transparent;
            this.lblPQLeavingCar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPQLeavingCar.ForeColor = System.Drawing.Color.Red;
            this.lblPQLeavingCar.Location = new System.Drawing.Point(502, 13);
            this.lblPQLeavingCar.Name = "lblPQLeavingCar";
            this.lblPQLeavingCar.Size = new System.Drawing.Size(0, 21);
            this.lblPQLeavingCar.TabIndex = 39;
            // 
            // picPQLeavingCar
            // 
            this.picPQLeavingCar.BackColor = System.Drawing.Color.Transparent;
            this.picPQLeavingCar.Location = new System.Drawing.Point(456, 1);
            this.picPQLeavingCar.Name = "picPQLeavingCar";
            this.picPQLeavingCar.Size = new System.Drawing.Size(40, 40);
            this.picPQLeavingCar.TabIndex = 36;
            this.picPQLeavingCar.TabStop = false;
            // 
            // picPQInlinedIcon
            // 
            this.picPQInlinedIcon.BackColor = System.Drawing.Color.Transparent;
            this.picPQInlinedIcon.Image = ((System.Drawing.Image)(resources.GetObject("picPQInlinedIcon.Image")));
            this.picPQInlinedIcon.Location = new System.Drawing.Point(410, 47);
            this.picPQInlinedIcon.Name = "picPQInlinedIcon";
            this.picPQInlinedIcon.Size = new System.Drawing.Size(40, 40);
            this.picPQInlinedIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPQInlinedIcon.TabIndex = 38;
            this.picPQInlinedIcon.TabStop = false;
            // 
            // picFIFOExitIcon
            // 
            this.picFIFOExitIcon.BackColor = System.Drawing.Color.Transparent;
            this.picFIFOExitIcon.Image = ((System.Drawing.Image)(resources.GetObject("picFIFOExitIcon.Image")));
            this.picFIFOExitIcon.Location = new System.Drawing.Point(0, 3);
            this.picFIFOExitIcon.Name = "picFIFOExitIcon";
            this.picFIFOExitIcon.Size = new System.Drawing.Size(40, 40);
            this.picFIFOExitIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFIFOExitIcon.TabIndex = 31;
            this.picFIFOExitIcon.TabStop = false;
            // 
            // lblFIFOInlinedCarInfo
            // 
            this.lblFIFOInlinedCarInfo.AutoSize = true;
            this.lblFIFOInlinedCarInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblFIFOInlinedCarInfo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFIFOInlinedCarInfo.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblFIFOInlinedCarInfo.Location = new System.Drawing.Point(92, 61);
            this.lblFIFOInlinedCarInfo.Name = "lblFIFOInlinedCarInfo";
            this.lblFIFOInlinedCarInfo.Size = new System.Drawing.Size(0, 21);
            this.lblFIFOInlinedCarInfo.TabIndex = 34;
            // 
            // picFIFOQueuedCar
            // 
            this.picFIFOQueuedCar.BackColor = System.Drawing.Color.Transparent;
            this.picFIFOQueuedCar.Location = new System.Drawing.Point(46, 49);
            this.picFIFOQueuedCar.Name = "picFIFOQueuedCar";
            this.picFIFOQueuedCar.Size = new System.Drawing.Size(40, 40);
            this.picFIFOQueuedCar.TabIndex = 29;
            this.picFIFOQueuedCar.TabStop = false;
            // 
            // lblFIFOLeavingCarInfo
            // 
            this.lblFIFOLeavingCarInfo.AutoSize = true;
            this.lblFIFOLeavingCarInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblFIFOLeavingCarInfo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFIFOLeavingCarInfo.ForeColor = System.Drawing.Color.Red;
            this.lblFIFOLeavingCarInfo.Location = new System.Drawing.Point(92, 15);
            this.lblFIFOLeavingCarInfo.Name = "lblFIFOLeavingCarInfo";
            this.lblFIFOLeavingCarInfo.Size = new System.Drawing.Size(0, 21);
            this.lblFIFOLeavingCarInfo.TabIndex = 33;
            // 
            // picFIFOLeavingCar
            // 
            this.picFIFOLeavingCar.BackColor = System.Drawing.Color.Transparent;
            this.picFIFOLeavingCar.Location = new System.Drawing.Point(46, 3);
            this.picFIFOLeavingCar.Name = "picFIFOLeavingCar";
            this.picFIFOLeavingCar.Size = new System.Drawing.Size(40, 40);
            this.picFIFOLeavingCar.TabIndex = 30;
            this.picFIFOLeavingCar.TabStop = false;
            // 
            // picFIFOInlinedIcon
            // 
            this.picFIFOInlinedIcon.BackColor = System.Drawing.Color.Transparent;
            this.picFIFOInlinedIcon.Image = ((System.Drawing.Image)(resources.GetObject("picFIFOInlinedIcon.Image")));
            this.picFIFOInlinedIcon.Location = new System.Drawing.Point(0, 49);
            this.picFIFOInlinedIcon.Name = "picFIFOInlinedIcon";
            this.picFIFOInlinedIcon.Size = new System.Drawing.Size(40, 40);
            this.picFIFOInlinedIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFIFOInlinedIcon.TabIndex = 32;
            this.picFIFOInlinedIcon.TabStop = false;
            // 
            // lvwPriorityQueue
            // 
            this.lvwPriorityQueue.LargeImageList = this.ilistPQ;
            this.lvwPriorityQueue.Location = new System.Drawing.Point(420, 37);
            this.lvwPriorityQueue.Margin = new System.Windows.Forms.Padding(0);
            this.lvwPriorityQueue.Name = "lvwPriorityQueue";
            this.lvwPriorityQueue.Size = new System.Drawing.Size(370, 150);
            this.lvwPriorityQueue.TabIndex = 1;
            this.lvwPriorityQueue.UseCompatibleStateImageBehavior = false;
            // 
            // ilistPQ
            // 
            this.ilistPQ.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.ilistPQ.ImageSize = new System.Drawing.Size(40, 40);
            this.ilistPQ.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // pnlControl
            // 
            this.pnlControl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlControl.BackgroundImage")));
            this.pnlControl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlControl.Controls.Add(this.btnExit);
            this.pnlControl.GradientBottomLeft = System.Drawing.Color.DodgerBlue;
            this.pnlControl.GradientBottomRight = System.Drawing.Color.DodgerBlue;
            this.pnlControl.GradientTopLeft = System.Drawing.Color.DodgerBlue;
            this.pnlControl.GradientTopRight = System.Drawing.Color.DodgerBlue;
            this.pnlControl.Location = new System.Drawing.Point(0, 0);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Quality = 10;
            this.pnlControl.Size = new System.Drawing.Size(800, 25);
            this.pnlControl.TabIndex = 4;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageActive = null;
            this.btnExit.Location = new System.Drawing.Point(774, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(23, 23);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExit.TabIndex = 0;
            this.btnExit.TabStop = false;
            this.btnExit.Zoom = 10;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Form_Screen
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.pnlControl);
            this.Controls.Add(this.pnlMainOperations);
            this.Controls.Add(this.pnlWelcome);
            this.Name = "Form_Screen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlWelcome.ResumeLayout(false);
            this.pnlWelcome.PerformLayout();
            this.pnlMainOperations.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnRemoveCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddCar)).EndInit();
            this.pnlInformations.ResumeLayout(false);
            this.pnlInformations.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPQExitIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPQQueuedCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPQLeavingCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPQInlinedIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFIFOExitIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFIFOQueuedCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFIFOLeavingCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFIFOInlinedIcon)).EndInit();
            this.pnlControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel pnlWelcome;
        private Bunifu.Framework.UI.BunifuThinButton2 btnDevamEt;
        private Bunifu.Framework.UI.BunifuGradientPanel pnlMainOperations;
        private System.Windows.Forms.ListView lvwPriorityQueue;
        private System.Windows.Forms.ListView lvwSimpleQueue;
        private System.Windows.Forms.Label lblWelcomHead;
        private System.Windows.Forms.Label lblWelcomeContext7;
        private System.Windows.Forms.Label lblWelcomeContext6;
        private System.Windows.Forms.Label lblWelcomeContext5;
        private System.Windows.Forms.Label lblWelcomeContext4;
        private System.Windows.Forms.Label lblWelcomeContext3;
        private System.Windows.Forms.Label lblWelcomeContext2;
        private System.Windows.Forms.Label lblWelcomeContext1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuGradientPanel pnlControl;
        private Bunifu.Framework.UI.BunifuImageButton btnExit;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.ImageList ilistFIFO;
        private System.Windows.Forms.ImageList ilistPQ;
        private System.Windows.Forms.Panel pnlInformations;
        private System.Windows.Forms.PictureBox picPQExitIcon;
        private System.Windows.Forms.Label lblPQQueuedCar;
        private System.Windows.Forms.PictureBox picPQQueuedCar;
        private System.Windows.Forms.Label lblPQLeavingCar;
        private System.Windows.Forms.PictureBox picPQLeavingCar;
        private System.Windows.Forms.PictureBox picPQInlinedIcon;
        private System.Windows.Forms.PictureBox picFIFOExitIcon;
        private System.Windows.Forms.Label lblFIFOInlinedCarInfo;
        private System.Windows.Forms.PictureBox picFIFOQueuedCar;
        private System.Windows.Forms.Label lblFIFOLeavingCarInfo;
        private System.Windows.Forms.PictureBox picFIFOLeavingCar;
        private System.Windows.Forms.PictureBox picFIFOInlinedIcon;
        private Bunifu.Framework.UI.BunifuImageButton btnRemoveCar;
        private Bunifu.Framework.UI.BunifuImageButton btnAddCar;
        private Bunifu.Framework.UI.BunifuTileButton pnlPQEmptyInfo;
        private Bunifu.Framework.UI.BunifuTileButton pnlFIFOEmptyInfo;
        private MaterialSkin.Controls.MaterialListView mlvwTablesOfCars;
        private System.Windows.Forms.ColumnHeader numbOfCar;
        private System.Windows.Forms.ColumnHeader carPlate;
        private System.Windows.Forms.ColumnHeader parkedTime;
        private System.Windows.Forms.ColumnHeader exitFIFOTime;
        private System.Windows.Forms.ColumnHeader exitPQTime;
        private System.Windows.Forms.ImageList ilistResult;
    }
}

