using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D311_OTEL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            
        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label6.Text = DateTime.Now.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        { 
                MessageBox.Show("Tüm Kayıtlar Silindi.");
                listBox1.Items.Clear();           
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "") {
                MessageBox.Show("Lütfen isminizi giriniz.");
            }
            else if(textBox2.Text == "")
            {
                MessageBox.Show("Lütfen soyisminizi giriniz.");
            }
            else if (comboBox2.Text == "")
            {
                MessageBox.Show("Lütfen cinsiyetinizi seçiniz");
            }
            else if (dateTimePicker1.Text == "")
            {
                MessageBox.Show("Lütfen doğum tarihinizi giriniz.");
            }
            else if (maskedTextBox2.Text == "")
            {
                MessageBox.Show("Lütfen TC kimlik numaranızı giriniz.");
            }
            else if (maskedTextBox1.Text == "")
            {
                MessageBox.Show("Lütfen telefon numaranızı giriniz.");
            }
            else if (comboBox1.Text == "")
            {
                MessageBox.Show("Lütfen oda tipini seçiniz.");
            }
            else if (dateTimePicker2.Text == "")
            {
                MessageBox.Show("Lütfen giriş tarihinizi giriniz.");
            }
            else if (dateTimePicker3.Text == "")
            {
                MessageBox.Show("Lütfen çıkış tarihinizi giriniz.");
            }
            else if (radioButton3.Checked == false && radioButton4.Checked == false)
            {
                MessageBox.Show("Lütfen ödeme şeklini seçiniz.");
            }
            else if (textBox3.Text == "")
            {
                MessageBox.Show("Lütfen ödenecek tutarı giriniz.");
            }
            else
            { 
            MessageBox.Show("Kayıt Oluşturuldu.");
            listBox1.Items.Add("İsim: " + textBox1.Text);
            listBox1.Items.Add("Soyisim: " + textBox2.Text);
            listBox1.Items.Add("Cinsiyet: " + comboBox2.Text);
            listBox1.Items.Add("Doğum Tarihi: " + dateTimePicker1.Text);
            listBox1.Items.Add("Tc Kimlik no: " + maskedTextBox2.Text);
            listBox1.Items.Add("Telefon no " + maskedTextBox1.Text);
            listBox1.Items.Add("Oda Tipi: " + comboBox1.Text);
            listBox1.Items.Add("Giriş Tarihi: " + dateTimePicker2.Text);
            listBox1.Items.Add("Çıkış Tarihi: " + dateTimePicker3.Text);
                if (radioButton3.Checked == true)
                {
                    listBox1.Items.Add("Ödeme Şekli: " + radioButton3.Text);
                }            
                else if(radioButton4.Checked == true)
                {
                    listBox1.Items.Add("Ödeme Şekli: " + radioButton4.Text);
                }
                else
                {
                    MessageBox.Show("Lütfen ödeme şeklini seçiniz.");
                }
            listBox1.Items.Add("Ödenecek Tutar: " + textBox3.Text);

            }



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton3.Checked == false && radioButton4.Checked == false)
            {
                MessageBox.Show("Lütfen ödeme şeklini seçiniz.");
            }
            else if (textBox3.Text == "")
            {
                MessageBox.Show("Lütfen ödenecek tutarı giriniz.");
            }
            else
            {
                MessageBox.Show("Ödeme İşemi Başarıyla Gerçekleşti.");

                if (radioButton3.Checked == true)
                {
                    listBox1.Items.Add("Ödeme Şekli: " + radioButton3.Text);
                }
                else if (radioButton4.Checked == true)
                {
                    listBox1.Items.Add("Ödeme Şekli: " + radioButton4.Text);
                }
                else
                {
                    MessageBox.Show("Lütfen ödeme şeklini seçiniz.");
                }

                listBox1.Items.Add("Ödenen Tutar: " + textBox3.Text);
            }


            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                if (listBox1.Items[i].ToString().ToLower().Contains(textBox4.Text.ToLower()))
                {
                    listBox1.SetSelected(i, true);
                }
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
