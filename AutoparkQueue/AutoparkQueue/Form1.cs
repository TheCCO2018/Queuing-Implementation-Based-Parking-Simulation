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
            //Node curr = ll.front;

            //Car C;
            //Node n;
            //Random r = new Random();
            //C = new Car(r.Next(1, 10), r.Next(10, 300));
            //C.parkTime += C.exitTime;
            //for (int i = 0; i < ll.size; i++)
            //{
            //    C.parkTime += curr.Data.exitTime;
            //    if (curr.Next != null)
            //    {
            //        curr = curr.Next;
            //    }
            //}  
            //n = new Node(C, null);
            //ll.Insert(n);
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
    }
}
