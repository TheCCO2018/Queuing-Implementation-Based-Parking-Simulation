using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoparkQueue
{
    public partial class Form1 : Form
    {
      


        public Form1()
        {
            InitializeComponent();
        }

        PQList _PQL = new PQList();
        FIFOList _FLL = new FIFOList();



        private void button1_Click(object sender, EventArgs e)
        {
            //txtCarList.Text = "";
            //Node curr = PQL.front;
            //for (int i = 0; i < PQL.size; i++)
            //{
            //    txtCarList.Text += curr.Data.carType.ToString() + "\t" + curr.Data.exitTime.ToString() + Environment.NewLine;
            //    if (curr.Next != null)
            //    {
            //        curr = curr.Next;
            //    }
            //}
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MainPanel.Visible = true;
            SecondPanel.Visible=false;
            //Car C;
            //Node n;
            //Random r = new Random();
            //for (int i = 0; i < 5; i++)
            //{
            //    C = new Car(r.Next(1,10), r.Next(10,300));
            //    n = new Node(C,null);
            //    PQL.Insert(n);
            //}
        }

        int index = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            //Node deletedCar = PQL.Remove();
            ////deletedCar.Data.parkTime += deletedCar.Data.exitTime;
            ////if(deletedCar.Next != null)
            ////{
            ////    deletedCar.Next.Data.parkTime += deletedCar.Data.parkTime;
            ////}
           
            //MessageBox.Show("Car ID"+index+"Geçen Süre: "+deletedCar.Data.parkTime.ToString());
            //index++; 
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
         
            
         
            
           
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            MainPanel.Visible = false;
            SecondPanel.Visible = true;
            SecondPanel.BringToFront();
            
        }

        private void btnAracEkle_Click(object sender, EventArgs e)
        {
            AracEkle();
        }
        
        public void AracSil()
        {
            Node Remove_PQL;
            Node Remove_FLL;
            Remove_PQL = _PQL.Remove();
            Remove_FLL = _FLL.Remove();
        }

        public void AracEkle()
        {
            Node curNode_PQL = _PQL.front;
            Node curNode_FLL = _FLL.front;
            Car car;
            Node node_PQL;
            Node node_FLL;

            Random Rng = new Random();
            car = new Car(Rng.Next(1, 10), Rng.Next(10, 300));
            node_PQL = new Node(car, null);
            node_FLL = new Node(car, null);

            node_PQL.Data.parkTime = node_PQL.Data.exitTime;

            for (int i = 0; i < _PQL.size; i++)
            {
                node_PQL.Data.parkTime += curNode_PQL.Data.exitTime;
                if (curNode_PQL.Next != null)
                {
                    curNode_PQL = curNode_PQL.Next;
                }
            }

            node_FLL.Data.parkTime = node_FLL.Data.exitTime;
            for (int i = 0; i < _FLL.size; i++)
            {
                node_FLL.Data.parkTime += curNode_FLL.Data.exitTime;
                if (curNode_PQL.Next != null)
                {
                    curNode_FLL = curNode_FLL.Next;
                }
            }


            _FLL.Insert(node_PQL);
            _PQL.Insert(node_FLL);

        }

        private void btnAracsil_Click(object sender, EventArgs e)
        {
            AracSil();
        }
    }
}
