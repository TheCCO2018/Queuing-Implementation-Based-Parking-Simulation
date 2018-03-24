using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MaterialSkin;

namespace AutoparkQueue
{
    public partial class Form_Screen : MaterialSkin.Controls.MaterialForm
    {
      
        public Form_Screen()
        {
            InitializeComponent();
            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            pnlWelcome.Visible = true;
            pnlMainOperations.Visible = false;
            btnEnglish_Click(this, null);
        }

        PQList _PQL = new PQList();
        FIFOList _FLL = new FIFOList();

        private void Form1_Load(object sender, EventArgs e)
        {
            ilistFIFO.Images.Clear();
            ilistPQ.Images.Clear();

            for (int i = 0; i < 10; i++)
            {
                AracEkle();
            }
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDevamEt_Click(object sender, EventArgs e)
        {
            pnlWelcome.Visible = false;
            lblControlHead.Visible = true;
            pnlMainOperations.Visible = true;
            btnTurkish.Visible = false;
            btnEnglish.Visible = false;
            pnlMainOperations.BringToFront();
            mlvwTablesOfCars.Items.Clear();
            Listele(_FLL);
            Listele(_PQL);
        }

        private void btnAracEkle_Click(object sender, EventArgs e)
        {
            if(pnlInformations.Visible != true)
            {
                pnlInformations.Visible = true;
            }
            AracEkle();

            int imageIndex = ilistFIFO.Images.IndexOfKey(_FLL.rear.Data.id.ToString());
            picFIFOQueuedCar.BackgroundImage = ilistFIFO.Images[imageIndex];
            lblFIFOInlinedCarInfo.Text = "45 CCO " +_FLL.rear.Data.id + " parked.";
            picPQQueuedCar.BackgroundImage = ilistFIFO.Images[imageIndex];
            lblPQQueuedCar.Text = "45 CCO " + _FLL.rear.Data.id + " parked.";

            Listele(_FLL);
            Listele(_PQL);
        }

        int tableIndex = 1;
        List<Node> removedNodes = new List<Node>();
        public void AracSil()
        {
            pnlInformations.Visible = true;
            Node Remove_PQL;
            Node Remove_FLL;
            Remove_PQL = _PQL.Remove();
            Remove_FLL = _FLL.Remove();
            removedNodes.Add(Remove_PQL);

            if (Remove_PQL != null)
            {
                // ** Deleted Car Informations as a PictureBox and Text Display**
                int imageIndex = ilistPQ.Images.IndexOfKey(Remove_PQL.Data.id.ToString());
                picPQLeavingCar.BackgroundImage = ilistPQ.Images[imageIndex];
                lblPQLeavingCar.Text = "45 CCO " + Remove_PQL.Data.id + " has left the Priority Park.";

                // ** Deleted Car Informations as a Table Content **
                if (Remove_PQL.Data.id >= Remove_FLL.Data.id)
                {
                    ListViewItem Item = new ListViewItem(tableIndex.ToString(), Remove_PQL.Data.carType);
                    Item.ImageKey = Remove_PQL.Data.id.ToString();
                    Item.SubItems.Add("45 CCO " + Remove_PQL.Data.id);
                    Item.SubItems.Add("   " + TimeSpan.FromSeconds(Remove_PQL.Data.exitTime).ToString());
                    Node last = Remove_FLL;
                    while (last.Next != Remove_FLL)
                    {
                        if (Remove_PQL.Data.id == last.Data.id)
                        {
                            Item.SubItems.Add("   " + TimeSpan.FromSeconds(last.Data.parkedTime).ToString());
                            break;
                        }
                        last = last.Next;
                    }
                    Item.SubItems.Add("   " + TimeSpan.FromSeconds(Remove_PQL.Data.parkedTime).ToString());
                    if (last.Data.parkedTime < Remove_PQL.Data.parkedTime)
                    {
                        Item.SubItems.Add("Simple Queue");
                    }
                    else if (last.Data.parkedTime > Remove_PQL.Data.parkedTime)
                    {
                        Item.SubItems.Add("Priority Queue");
                    }
                    else
                    {
                        Item.SubItems.Add("Equal");
                    }
                    mlvwTablesOfCars.Items.Add(Item);
                    tableIndex++;
                }
            }
            if (Remove_FLL != null)
            {
                // ** Deleted Car Informations as a PictureBox and Text Display**
                int imageIndex = ilistFIFO.Images.IndexOfKey(Remove_FLL.Data.id.ToString());
                picFIFOLeavingCar.BackgroundImage = ilistFIFO.Images[imageIndex];
                lblFIFOLeavingCarInfo.Text = "45 CCO " + Remove_FLL.Data.id + " has left the FIFO Park.";


                // ** Deleted Car Informations as a Table Content **
                bool flag = false;
                for (int i = 0; i < removedNodes.Count; i++)
                {
                    if (removedNodes[i].Data.id == Remove_FLL.Data.id)
                    {
                        flag = true;
                        break;
                    }
                }
                if (!flag)
                {
                    ListViewItem Item = new ListViewItem(tableIndex.ToString(), Remove_FLL.Data.carType);
                        Item.ImageKey = Remove_FLL.Data.id.ToString();
                        Item.SubItems.Add("45 CCO " + Remove_FLL.Data.id);
                        Item.SubItems.Add("   " + TimeSpan.FromSeconds(Remove_FLL.Data.exitTime).ToString());
                        Item.SubItems.Add("   " + TimeSpan.FromSeconds(Remove_FLL.Data.parkedTime).ToString());
                    Node last = Remove_PQL;
                    while (last.Next != Remove_PQL)
                    {
                        if (Remove_FLL.Data.id == last.Data.id)
                        {
                            Item.SubItems.Add("   " + TimeSpan.FromSeconds(last.Data.parkedTime).ToString());
                            break;
                        }
                        last = last.Next;
                    }
                    if (last.Data.parkedTime > Remove_FLL.Data.parkedTime)
                    {
                        Item.SubItems.Add("Simple Queue");
                    }
                    else if (last.Data.parkedTime < Remove_FLL.Data.parkedTime)
                    {
                        Item.SubItems.Add("Priority Queue");
                    }
                    else
                    {
                        Item.SubItems.Add("Equal");
                    }
                    mlvwTablesOfCars.Items.Add(Item);
                    tableIndex++;
                }
            }
            Listele(_FLL);
            Listele(_PQL);
        }
        int index = 0;

        Random Rng = new Random();
        public void AracEkle()
        {
            Car pqlCar = new Car(Rng.Next(0, 15), Rng.Next(10, 300)) { id = index++ };
            Car fllCar = new Car(pqlCar.carType, pqlCar.exitTime) { id = pqlCar.id };
            Node node_PQL;
            Node node_FLL;
            
            node_PQL = new Node(pqlCar, null);
            node_FLL = new Node(fllCar, null);

            _PQL.Insert(node_PQL);
            Node curNode_PQL = _PQL.front;
            if (_PQL.front == node_PQL)
            {
                node_PQL.Data.parkedTime = node_PQL.Data.exitTime;
            }
            else
            {
                while (curNode_PQL != node_PQL)
                {
                    node_PQL.Data.parkedTime += curNode_PQL.Data.exitTime;
                    curNode_PQL = curNode_PQL.Next;
                }
                node_PQL.Data.parkedTime += curNode_PQL.Data.exitTime;
            }
            if(node_PQL.Next != null)
            {
                curNode_PQL = node_PQL.Next;
                while (curNode_PQL.Next != null)
                {
                    curNode_PQL.Data.parkedTime += node_PQL.Data.exitTime;
                    curNode_PQL = curNode_PQL.Next;
                }
            }
            ilistPQ.Images.Add(node_PQL.Data.id.ToString(), Image.FromFile(node_PQL.Data.imageUrl));

            _FLL.Insert(node_FLL);
            Node curNode_FLL = _FLL.front;
            node_FLL.Data.parkedTime = node_FLL.Data.exitTime;
            while(curNode_FLL != node_FLL)
            {
                node_FLL.Data.parkedTime += curNode_FLL.Data.exitTime;             
                curNode_FLL = curNode_FLL.Next;
            }
            ilistFIFO.Images.Add(node_FLL.Data.id.ToString(), Image.FromFile(node_FLL.Data.imageUrl));
        }

        private void btnAracsil_Click(object sender, EventArgs e)
        {
            AracSil();
        }
        public void Listele(LinkedList LL)
        {
            if(LL.count != 0)
            {

                if (LL is PQList)
                {
                    lvwPriorityQueue.Visible = true;
                    lvwPriorityQueue.BringToFront();
                    lvwPriorityQueue.Items.Clear();
                    Node last = LL.front;
                    while (last.Next != null)
                    {
                        ListViewItem Item = new ListViewItem();
                        Item.ImageKey = last.Data.id.ToString();
                        Item.Text = last.Data.id.ToString();
                        lvwPriorityQueue.Items.Add(Item);
                        last = last.Next;
                    }
                }
                else if (LL is FIFOList)
                {
                    lvwSimpleQueue.Visible = true;
                    lvwSimpleQueue.BringToFront();
                    lvwSimpleQueue.Items.Clear();
                    Node last = LL.front;
                    while (last.Next != null)
                    {
                        ListViewItem Item = new ListViewItem();
                        Item.ImageKey = last.Data.id.ToString();
                        Item.Tag = last.Data.id.ToString();
                        Item.Text = last.Data.id.ToString();
                        lvwSimpleQueue.Items.Add(Item);
                        last = last.Next;
                    }
                }
                ListViewItem LastItem = new ListViewItem();
                LastItem.ImageKey = LL.rear.Data.id.ToString();
                LastItem.Text = LL.rear.Data.id.ToString();
                if (LL is PQList)
                {
                    lvwPriorityQueue.Items.Add(LastItem);
                }
                if (LL is FIFOList)
                {
                    lvwSimpleQueue.Items.Add(LastItem);
                }
            }
            else
            {
                if(LL is PQList)
                {
                    pnlPQEmptyInfo.BringToFront();
                    lvwPriorityQueue.Visible = false;
                }
                if (LL is FIFOList)
                {
                    pnlFIFOEmptyInfo.BringToFront();
                    lvwSimpleQueue.Visible = false;
                }
            }
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            lvwPriorityQueue.Items.Clear();
            lvwSimpleQueue.Items.Clear();
            mlvwTablesOfCars.Items.Clear();
            pnlInformations.Visible = false;
            lblFIFOInlinedCarInfo.Text = "";
            lblPQQueuedCar.Text = "";
            index = 0;
            tableIndex = 1;
            removedNodes = new List<Node>();
            _FLL = new FIFOList();
            _PQL = new PQList();
            this.Form1_Load(this, null);
            Listele(_FLL);
            Listele(_PQL);
        }

        private void btnEnglish_Click(object sender, EventArgs e)
        {
            pnlEnglish.Visible = true;
            btnDevamEt.ButtonText = "Continue";
        }

        private void btnTurkish_Click(object sender, EventArgs e)
        {
            pnlEnglish.Visible = false;
            btnDevamEt.ButtonText = "Devam Et";
        }
    }
}
