using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ö
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public class Node
        {
           
            public int sayı;
            public Node sonraki;
        }
        Node ilk;
      

        private void button1_Click(object sender, EventArgs e)
        {
            Node yeni = new Node();
            yeni.sayı = Convert.ToInt32(textBox1.Text);
            if (ilk == null)
            {
                ilk = yeni;
                ilk.sonraki = null;
            }
            else
            {
                yeni.sonraki = ilk;
                ilk = yeni;
            } 
            yıgınGöster();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Node geçici = new Node();
            if (ilk== null)
            {
                MessageBox.Show("yıgın boş");
                return;
                  
            }
            else
            {
                geçici = ilk.sonraki;
                ilk = null;
                ilk = geçici;
                
            }
           // ilk= ilk.sonraki;
            yıgınGöster();
        }

        private void yıgınGöster()
        {
            textBox2.Text = null;
           
            if (ilk == null)
            {
                MessageBox.Show("gösterilecek eleman yok");
                return;
            }
            else
            {
                Node geçici = ilk;
                while (geçici != null)
                {
                    textBox2.Text += geçici.sayı + "\r\n";
                    geçici = geçici.sonraki;
                }
            }
        }


        
    
    }
}
