using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Costumes

{
    public partial class Form1 : Form
    {
        /*Adószám:    Az adózót azonosító 7 jegyű szám + 1 ellenőrző szám
                      XXXXXXXX-Y-ZZ
                      Y: ÁFA kód
                      ZZ: két számjegyű területi kód
        */
        List<Jelmez> jelmezek = new List<Jelmez>();
        Jelmez PestisDoctor = new Jelmez(1, "Pestis Doktor", "XS", 3400, false);
        Jelmez gyilkos = new Jelmez(2, "A Gyilkos", "XL", 12800, false);
        Jelmez palcaFigura = new Jelmez(3, "Pálca figura", "M", 2300, false);
        Jelmez YIFF = new Jelmez(4, "YIFF", "M", 5500, false);
        string hozzaad = string.Empty;
        
        public Form1()
        {
            InitializeComponent();
            GetJelmez();
            jelmezek.Add(PestisDoctor);
            jelmezek.Add(gyilkos);
            jelmezek.Add(palcaFigura);
            jelmezek.Add(YIFF);

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            SetTextBoxColor();
            SetTextBoxText();
            TestBoxDisable();
            GroupBoxDisable();
        }
        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Vezetéknév") { textBox1.Text = ""; }
            textBox1.ForeColor = Color.Black;
        }
        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "") { textBox1.Text = "Vezetéknév"; textBox1.ForeColor = Color.Black; }
        }
        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Keresztnév") { textBox2.Text = ""; }
            textBox2.ForeColor = Color.Black;
        }
        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "") { textBox2.Text = "Keresztnév"; textBox2.ForeColor = Color.Black; }
        }
        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text == "Irányítószám") { textBox3.Text = ""; }
            textBox3.ForeColor = Color.Black;
        }
        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text == "") { textBox3.Text = "Irányítószám"; textBox3.ForeColor = Color.Gray; }
        }
        private void textBox4_Enter(object sender, EventArgs e)
        {
            if (textBox4.Text == "Város") { textBox4.Text = ""; }
            textBox4.ForeColor = Color.Black;
        }
        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (textBox4.Text == "") { textBox4.Text = "Város"; textBox4.ForeColor = Color.Gray; }
        }
        private void textBox5_Enter(object sender, EventArgs e)
        {
            if (textBox5.Text == "Utca") { textBox5.Text = ""; }
            textBox5.ForeColor = Color.Black;
        }
        private void textBox5_Leave(object sender, EventArgs e)
        {
            if (textBox5.Text == "") { textBox5.Text = "Utca"; textBox5.ForeColor = Color.Gray; }

        }
        private void textBox6_Enter(object sender, EventArgs e)
        {
            if (textBox6.Text == "Ház szám") { textBox6.Text = ""; }
            textBox6.ForeColor = Color.Black;
        }
        private void textBox6_Leave(object sender, EventArgs e)
        {
            if (textBox6.Text == "") { textBox6.Text = "Ház szám"; textBox6.ForeColor = Color.Gray; }

        }
        private void textBox7_Enter(object sender, EventArgs e)
        {
            if (textBox7.Text == "00000000") { textBox7.Text = ""; }
            textBox7.ForeColor = Color.Black;
        }
        private void textBox7_Leave(object sender, EventArgs e)
        {
            if (textBox7.Text == "") { textBox7.Text = "00000000"; textBox7.ForeColor = Color.Gray; }
        }
        private void textBox8_Enter(object sender, EventArgs e)
        {
            if (textBox8.Text == "0") { textBox8.Text = ""; }
            textBox8.ForeColor = Color.Black;
        }
        private void textBox8_Leave(object sender, EventArgs e)
        {
            if (textBox8.Text == "") { textBox8.Text = "0"; textBox8.ForeColor = Color.Gray; }
        }
        private void textBox9_Enter(object sender, EventArgs e)
        {
            if (textBox9.Text == "00") { textBox9.Text = ""; }
            textBox9.ForeColor = Color.Black;
        }
        private void textBox9_Leave(object sender, EventArgs e)
        {
            if (textBox9.Text == "") { textBox9.Text = "00"; textBox9.ForeColor = Color.Gray; }
        }
        private void textBox10_Enter(object sender, EventArgs e)
        {
            if (textBox10.Text == "pelda@gmail.com") { textBox10.Text = ""; }
            textBox10.ForeColor = Color.Black;
        }
        private void textBox10_Leave(object sender, EventArgs e)
        {
            if (textBox10.Text == "") { textBox10.Text = "pelda@gmail.com"; textBox10.ForeColor = Color.Gray; }
        }
        private void button13_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
            Fizetendo();
        } //Kosár
        private void TestBoxDisable()
        {
            textBox11.Enabled = false;
            textBox16.Enabled = true;
            textBox17.Enabled = false;
            textBox18.Enabled = false;
            textBox19.Enabled = false;
            textBox20.Enabled = false;
            textBox21.Enabled = true;
            textBox22.Enabled = false;
            textBox23.Enabled = false;
            textBox24.Enabled = true;
            textBox25.Enabled = false;
            textBox26.Enabled = false;
            textBox27.Enabled = true;
            textBox40.Enabled = false;
            textBox41.Enabled = false;
            textBox42.Enabled = false;
        }
        private void GroupBoxDisable()
        {
            groupBox2.Enabled = false;
            groupBox3.Enabled = false;
            groupBox3.Enabled = false;
            groupBox4.Enabled = false;
            groupBox5.Enabled = false;
        }
        private void SetTextBoxColor()
        {
            textBox1.ForeColor = Color.Gray;
            textBox2.ForeColor = Color.Gray;
            textBox3.ForeColor = Color.Gray;
            textBox4.ForeColor = Color.Gray;
            textBox5.ForeColor = Color.Gray;
            textBox6.ForeColor = Color.Gray;
            textBox7.ForeColor = Color.Gray;
            textBox8.ForeColor = Color.Gray;
            textBox9.ForeColor = Color.Gray;
            textBox10.ForeColor = Color.Gray;
        }
        private void SetTextBoxText()
        {
            textBox1.Text = "Vezetéknév";
            textBox2.Text = "Keresztnév";
            textBox3.Text = "Irányítószám";
            textBox4.Text = "Város";
            textBox5.Text = "Utca";
            textBox6.Text = "Ház szám";
            textBox7.Text = "00000000";
            textBox8.Text = "0";
            textBox9.Text = "00";
            textBox10.Text = "Emailcím@email.hu";
        }
        private void button5_Click(object sender, EventArgs e)
        {
            string meret = PestisDoctor.meret;
            string nev = PestisDoctor.elnevezes;
            int id = PestisDoctor.sorszam;
            int napi_ar = PestisDoctor.napi_ar;
            int napok_szama = (int)numericUpDown2.Value;
            listBox1.Items.Add(napok_szama);
            listBox3.Items.Add(id);
            listBox4.Items.Add(nev);
            listBox5.Items.Add(meret);
            int osszes_ar = napok_szama * napi_ar;
            listBox2.Items.Add(osszes_ar);
            radioButton4.Checked = true; 
            PestisDoctor.kolcsonozve = true;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            string meret = gyilkos.meret;
            string nev = gyilkos.elnevezes;
            int id = gyilkos.sorszam;
            int napi_ar = gyilkos.napi_ar;
            int napok_szama = (int)numericUpDown3.Value;
            listBox1.Items.Add(napok_szama);
            int osszes_ar = napok_szama * napi_ar;
            listBox3.Items.Add(id);
            listBox4.Items.Add(nev);
            listBox5.Items.Add(meret);
            listBox2.Items.Add(osszes_ar);
            radioButton5.Checked = true;
            gyilkos.kolcsonozve = true;
        }
        private void button7_Click(object sender, EventArgs e)
        {
            string meret = palcaFigura.meret;
            string nev = palcaFigura.elnevezes;
            int id = palcaFigura.sorszam;
            int napi_ar = palcaFigura.napi_ar;
            int napok_szama = (int)numericUpDown4.Value;
            listBox1.Items.Add(napok_szama);
            int osszes_ar = napok_szama * napi_ar;
            listBox3.Items.Add(id);
            listBox4.Items.Add(nev);
            listBox5.Items.Add(meret);
            listBox2.Items.Add(osszes_ar);
            radioButton7.Checked = true; 
            palcaFigura.kolcsonozve = true;
        }
        private void button8_Click(object sender, EventArgs e)
        {
            string meret = YIFF.meret;
            string nev = YIFF.elnevezes;
            int id = YIFF.sorszam;
            int napi_ar = YIFF.napi_ar;
            int napok_szama = (int)numericUpDown5.Value;
            listBox1.Items.Add(napok_szama);
            int osszes_ar = napok_szama * napi_ar;
            listBox3.Items.Add(id);
            listBox4.Items.Add(nev);
            listBox5.Items.Add(meret);
            listBox2.Items.Add(osszes_ar);
            radioButton9.Checked = true; 
            YIFF.kolcsonozve = true;
        }
        
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) { e.Handled = true; }
        }
        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) { e.Handled = true; }
        }
        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) { e.Handled = true; }
        }
        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) { e.Handled = true; }
        }
        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) { e.Handled = true; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = 0;
            id++;

            List<string> jelmeznev = new List<string>() { };
            List<Jelmez> jelmezek = new List<Jelmez>() { };
            foreach (var item in listBox4.Items)
            {
                jelmeznev.Add(item.ToString());
            }
            for (int i = 0; i < 3; i++)
            { 
                jelmezek.Add(new Jelmez(i,"Név" + "nev", "meret" + "s", i + i, false ));
            }

            DataTable dt = new DataTable();
           
            dt.Columns.Add("Név");

            foreach (var data in jelmezek)
            {
                DataRow dr = dt.NewRow();
                dr["Név"] = "Title:" + data.elnevezes + "\nsorszam:" + data.sorszam + "\nAuthor:" + data.meret;
                dt.Rows.Add(dr);
            }

            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
           
            int napi_ar = 0;
            if (listBox4.Items.Contains(PestisDoctor.elnevezes) == true) { napi_ar = PestisDoctor.napi_ar; }
            if (listBox4.Items.Contains(palcaFigura.elnevezes) == true ) { napi_ar = palcaFigura.napi_ar; }
            if (listBox4.Items.Contains(gyilkos.elnevezes) == true) { napi_ar = gyilkos.napi_ar; }
            if (listBox4.Items.Contains(YIFF.elnevezes) == true) { napi_ar = YIFF.napi_ar; }
        }

        public void Fizetendo()
        {
            int fizetendo = 0;
            foreach (var item in listBox2.Items)
            {
                fizetendo += (int)item;
            }
            textBox12.Text = fizetendo.ToString();
        }
        public void GetJelmez()
        {
            textBox16.Text = PestisDoctor.sorszam.ToString();
            textBox17.Text = PestisDoctor.elnevezes;
            textBox18.Text = PestisDoctor.napi_ar.ToString();
            textBox11.Text = PestisDoctor.meret;

            textBox20.Text = gyilkos.sorszam.ToString();
            textBox20.Text = gyilkos.elnevezes;
            textBox19.Text = gyilkos.napi_ar.ToString();
            textBox40.Text = gyilkos.meret;

            textBox24.Text = palcaFigura.sorszam.ToString();
            textBox23.Text = palcaFigura.elnevezes;
            textBox22.Text = palcaFigura.napi_ar.ToString();
            textBox41.Text = palcaFigura.meret;

            textBox27.Text = YIFF.sorszam.ToString();
            textBox26.Text = YIFF.elnevezes;
            textBox25.Text = YIFF.napi_ar.ToString();
            textBox42.Text = YIFF.meret;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool elerheto = false;
        }

        private void listBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
