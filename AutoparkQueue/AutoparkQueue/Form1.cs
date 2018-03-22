using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Animations;
using MaterialSkin.Controls;

namespace AutoparkQueue
{
    public partial class Form_Screen : MaterialSkin.Controls.MaterialForm
    {
      
        public Form_Screen()
        {
            InitializeComponent();
            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        PQList _PQL = new PQList();
        FIFOList _FLL = new FIFOList();

        private void Form1_Load(object sender, EventArgs e)
        {
            pnlWelcome.Visible = true;
            pnlMainOperations.Visible = false;

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
            pnlMainOperations.Visible = true;
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
        int i = 1;
        public void AracSil()
        {
            pnlInformations.Visible = true;
            Node Remove_PQL;
            Node Remove_FLL;
            Remove_PQL = _PQL.Remove();
            Remove_FLL = _FLL.Remove();

            if(Remove_PQL != null)
            {
                int imageIndex = ilistPQ.Images.IndexOfKey(Remove_PQL.Data.id.ToString());
                picPQLeavingCar.BackgroundImage = ilistPQ.Images[imageIndex];
                lblPQLeavingCar.Text = "45 CCO " + Remove_PQL.Data.id + " has left the Priority Park.";

            }
            if(Remove_FLL != null)
            {
                int imageIndex = ilistFIFO.Images.IndexOfKey(Remove_FLL.Data.id.ToString());
                picFIFOLeavingCar.BackgroundImage = ilistFIFO.Images[imageIndex];
                lblFIFOLeavingCarInfo.Text = "45 CCO " + Remove_FLL.Data.id + " has left the FIFO Park.";
            }
            Listele(_FLL);
            Listele(_PQL);
        }
        int index = 0;

        Random Rng = new Random();
        public void AracEkle()
        {
            Car car;
            Node node_PQL;
            Node node_FLL;

            car = new Car(Rng.Next(1, 15), Rng.Next(10, 300)){id = index++};
            node_PQL = new Node(car, null);
            node_FLL = new Node(car, null);

            _PQL.Insert(node_PQL);
            Node curNode_PQL = _PQL.front;
            if (_PQL.front == node_PQL)
            {
                node_PQL.Data.parkedTime = node_PQL.Data.exitTime;
            }
            else
            {
                ////for (int i = 0; i < _PQL.count; i++ )
                //while (curNode_PQL.Next != node_PQL)
                //{
                //    node_PQL.Data.parkedTime += curNode_PQL.Data.exitTime;
                //    curNode_PQL = curNode_PQL.Next;
                //}
            }
            if(node_PQL.Next != null)
            {
                //curNode_PQL = node_PQL.Next;
                //while (curNode_PQL.Next != null)
                //{
                //    curNode_PQL.Data.parkedTime += node_PQL.Data.exitTime;
                //    curNode_PQL = curNode_PQL.Next;
                //}
            }
            
            _FLL.Insert(node_FLL);
            Node curNode_FLL = _FLL.front;
           // node_FLL.Data.parkedTime = node_FLL.Data.exitTime;
            //while(curNode_FLL.Next != null)
            //{
            //    node_FLL.Data.parkedTime += curNode_FLL.Data.exitTime;
                
            //    curNode_FLL = curNode_FLL.Next;
            //}
            ilistFIFO.Images.Add(node_FLL.Data.id.ToString(), Image.FromFile(node_FLL.Data.imageUrl));
            ilistPQ.Images.Add(node_PQL.Data.id.ToString(), Image.FromFile(node_PQL.Data.imageUrl));
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
                if (LL is FIFOList)
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
                LastItem.ImageIndex = LL.rear.Data.id;
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
    }
}
