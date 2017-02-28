using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14253607HW3
{
    public partial class Form1 : Form
    {
        ArrayList liste = new ArrayList();
        ArrayList mat = new ArrayList();
        ArrayList fiz = new ArrayList();
        ArrayList kim = new ArrayList();
        ArrayList tar = new ArrayList();
        ArrayList edeb = new ArrayList();
        ArrayList ogrno = new ArrayList();
        ArrayList ad = new ArrayList();
        ArrayList bolumu = new ArrayList();
        decimal matematik;
        decimal fizik;
        decimal kimya;
        decimal tarih;
        decimal edebiyat;
        decimal sayac;
        decimal toplam;

        public Form1(decimal matematik = 0, decimal fizik = 0, decimal kimya = 0, decimal tarih = 0, decimal edebiyat = 0 )
        {
            this.matematik = matematik;
            this.fizik = fizik;
            this.kimya = kimya;
            this.tarih = tarih;
            this.edebiyat = edebiyat;
            this.sayac = sayac;
            this.toplam = toplam;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void kaydet_Click(object sender, EventArgs e)
        {
            int ogrencino = Convert.ToInt32(textBox1.Text);
            string isim = textBox2.Text;
            string bolum = textBox3.Text;
            int not1 = Convert.ToInt32(textBox4.Text);
            int not2 = Convert.ToInt32(textBox5.Text);
            int not3 = Convert.ToInt32(textBox6.Text);


            listBox1.Items.Add(ogrencino.ToString() + " " + isim.ToString() + " " + bolum.ToString() + " " + comboBox1.Text + "=" + not1.ToString() + " " + comboBox2.Text + "=" + not2.ToString() + " " + comboBox3.Text + "=" + not3.ToString());

           
            ogrno.Add(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            
            
            ad.Add(textBox2.Text);
            textBox2.Clear();
            textBox2.Focus();

            bolumu.Add(textBox3.Text);
            textBox3.Clear();
            textBox3.Focus();

            if (comboBox1.SelectedIndex == 0)
            {
                mat.Add(textBox4.Text);
                textBox4.Clear();
                textBox4.Focus();
            }
            if (comboBox1.SelectedIndex == 1)
            {
                fiz.Add(textBox4.Text);
                textBox4.Clear();
                textBox4.Focus();
            }
            if (comboBox1.SelectedIndex == 2)
            {
                kim.Add(textBox4.Text);
                textBox4.Clear();
                textBox4.Focus();
            }
            if (comboBox1.SelectedIndex == 3)
            {
                tar.Add(textBox4.Text);
                textBox4.Clear();
                textBox4.Focus();
            }
            if (comboBox1.SelectedIndex == 4)
            {
                edeb.Add(textBox4.Text);
                textBox4.Clear();
                textBox4.Focus();
            }

            if (comboBox2.SelectedIndex == 0)
            {
                mat.Add(textBox5.Text);
                textBox5.Clear();
                textBox5.Focus();
            }
            if (comboBox2.SelectedIndex == 1)
            {
                fiz.Add(textBox5.Text);
                textBox4.Clear();
                textBox4.Focus();
            }
            if (comboBox2.SelectedIndex == 2)
            {
                kim.Add(textBox5.Text);
                textBox5.Clear();
                textBox5.Focus();
            }
            if (comboBox2.SelectedIndex == 3)
            {
                tar.Add(textBox5.Text);
                textBox5.Clear();
                textBox5.Focus();
            }
            if (comboBox2.SelectedIndex == 4)
            {
                edeb.Add(textBox5.Text);
                textBox5.Clear();
                textBox5.Focus();
            }

            if (comboBox3.SelectedIndex == 0)
            {
                mat.Add(textBox6.Text);
                textBox6.Clear();
                textBox6.Focus();
            }
            if (comboBox3.SelectedIndex == 1)
            {
                fiz.Add(textBox6.Text);
                textBox6.Clear();
                textBox6.Focus();
            }
            if (comboBox3.SelectedIndex == 2)
            {
                kim.Add(textBox6.Text);
                textBox6.Clear();
                textBox6.Focus();
            }
            if (comboBox3.SelectedIndex == 3)
            {
                tar.Add(textBox6.Text);
                textBox6.Clear();
                textBox6.Focus();
            }
            if (comboBox3.SelectedIndex == 4)
            {
                edeb.Add(textBox6.Text);
                textBox6.Clear();
                textBox6.Focus();
            }


            liste.Add(comboBox1.SelectedIndex);

            liste.Add(comboBox2.SelectedIndex);

            liste.Add(comboBox3.SelectedIndex);

           


        }

        private void button1_Click(object sender, EventArgs e)
        {

            decimal sayac = 0;
            decimal toplam = 0;
            if (comboBox4.SelectedIndex == 0)
            {
                for (int i = 0; i < mat.Count; i++)
                {
                    matematik += Convert.ToInt32(mat[i]);
                    sayac++;
                    toplam = matematik / sayac;
                }
                              
                label13.Text = toplam.ToString();
                label13.Visible = true;
                label14.Text = sayac.ToString();
                label14.Visible = true;
            }

                if (comboBox4.SelectedIndex == 1)
                {
                    for (int i = 0; i < fiz.Count; i++)
                    {
                        fizik += Convert.ToInt32(fiz[i]);
                        sayac++;
                        toplam = fizik / sayac;
                    }
                label13.Text = toplam.ToString();
                label13.Visible = true;
                label14.Text = sayac.ToString();
                label14.Visible = true;
            }

            if (comboBox4.SelectedIndex == 2)
            {
                for (int i = 0; i < kim.Count; i++)
                {
                    kimya += Convert.ToInt32(kim[i]);
                    sayac++;
                    toplam = kimya / sayac;
                }
                label13.Text = toplam.ToString();
                label13.Visible = true;
                label14.Text = sayac.ToString();
                label14.Visible = true;
            }

            if (comboBox4.SelectedIndex == 3)
            {
                for (int i = 0; i < tar.Count; i++)
                {
                    tarih += Convert.ToInt32(tar[i]);
                    sayac++;
                    toplam = tarih / sayac;
                }
                label13.Text = toplam.ToString();
                label13.Visible = true;
                label14.Text = sayac.ToString();
                label14.Visible = true;
            }

            if (comboBox4.SelectedIndex == 4)
            {
                for (int i = 0; i < edeb.Count; i++)
                {
                    edebiyat += Convert.ToInt32(edeb[i]);
                    sayac++;
                    toplam = edebiyat / sayac;
                }
                label13.Text = toplam.ToString();
                label13.Visible = true;
                label14.Text = sayac.ToString();
                label14.Visible = true;
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox5.SelectedIndex == 0)
            {
                
               
            }

            if (comboBox5.SelectedIndex == 1)
            {
                
            }

            if (comboBox5.SelectedIndex == 2)
            {

            }

            if (comboBox5.SelectedIndex == 3)
            {

            }

            if (comboBox5.SelectedIndex == 4)
            {

            }

            

        }

        private void button3_Click(object sender, EventArgs e )
        {
            int[] mateler = new int[mat.Count];
            int[] fizikler = new int[fiz.Count];
            int[] kimyalar = new int[kim.Count];
            int[] tarihler = new int[tar.Count];
            int[] edebiyatlar = new int[edeb.Count];
            for (int i = 0; i < mat.Count; i++)
            {
                mateler[i] = Convert.ToInt32(mat[i]);
                                
            }
            for (int i = 0; i < fiz.Count; i++)
            {
                fizikler[i] = Convert.ToInt32(fiz[i]);
            }

            for (int i = 0; i < kim.Count; i++)
            {
                kimyalar[i] = Convert.ToInt32(kim[i]);
            }
            for (int i = 0; i < tar.Count; i++)
            {
                tarihler[i] = Convert.ToInt32(tar[i]);
            }
            for (int i = 0; i < edeb.Count; i++)
            {
                edebiyatlar[i] = Convert.ToInt32(edeb[i]);
            }

            
            if (comboBox6.SelectedIndex == 0)
            {
                int max = mateler[0];

                for (int i = 0; i < mateler.Length; i++)
                {
                    
                    if (mateler[i] > max )
                    {
                        max = mateler[i];
                        listBox3.Items.Add( comboBox6.Text +  max.ToString());
                    }
                }
            }

            if (comboBox6.SelectedIndex == 1)
            {
                int max = fizikler[0];

                for (int i = 0; i < fizikler.Length; i++)
                {

                    if (fizikler[i] > max)
                    {
                        max = fizikler[i];
                        listBox3.Items.Add(comboBox6.Text + max.ToString());
                    }
                }
            }

            if (comboBox6.SelectedIndex == 2)
            {
                int max = kimyalar[0];

                for (int i = 0; i < kimyalar.Length; i++)
                {

                    if (kimyalar[i] > max)
                    {
                        max = kimyalar[i];
                        listBox3.Items.Add(comboBox6.Text + max.ToString());
                    }
                }
            }

            if (comboBox6.SelectedIndex == 3)
            {
                int max = tarihler[0];

                for (int i = 0; i < tarihler.Length; i++)
                {

                    if (tarihler[i] > max)
                    {
                        max = tarihler[i];
                        listBox3.Items.Add(comboBox6.Text + max.ToString());
                    }
                }
            }

            if (comboBox6.SelectedIndex == 4)
            {
                int max = edebiyatlar[0];

                for (int i = 0; i < edebiyatlar.Length; i++)
                {

                    if (mateler[i] > max)
                    {
                        max = edebiyatlar[i];
                        listBox3.Items.Add(comboBox6.Text + max.ToString());
                    }
                }
            }
        }
    }
    }
