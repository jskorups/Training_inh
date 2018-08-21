using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Form1 : Form
    {

        //inicjalizacja globalnej zmiiennej w klasie bazowej figura
        private Figura f;


        public Form1()
        {
            InitializeComponent();

            //inicjalizjacja listy
            List<string> listaFigur = new List<string>();
            listaFigur.Add("Kwadrat");
            listaFigur.Add("Prostokąt");
            listaFigur.Add("Trójkąt");

            foreach (string item in listaFigur)
                comboBox1.Items.Add(item);
        }

        // wybór figury
        // przypisanie danych w konstruktorach odpowiednie pola - textboxy
        private void WyborFigury()
        {
            switch (comboBox1.Text)
            {
                case "Trójkąt":
                    f = new Trojkat(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text));
                    break;
                case "Prostokąt":
                    f = new Prostokat(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
                    Prostokat p = new Prostokat();
                    break;
                case "Kwadrat":
                    f = new Kwadrat(Convert.ToInt32(textBox1.Text));
                    break;
                default:
                    f = new Figura();
                    break;   
            }
        }
        // wyswietlanie wyników
        private void ObliczPole_Click(object sender, EventArgs e)
        {
            WyborFigury();
            textBox5.Text = f.Pole().ToString();

        }
        private void obliczObwod_Click(object sender, EventArgs e)
        {
            WyborFigury();
            textBox6.Text = f.Obwod().ToString();
        }

  
        #region Cwiczenia inne

        // Kubek k = new Kubek(1, 2, "moj");
        // k.NazwijKubek("moj2");
        // string test = "sdadas";

        // {
        //     FakturaNaglowek nag = new FakturaNaglowek();
        //     nag.nrFaktury = "1/sp/2018";
        //     nag.waluta = "PLN";


        //     Adres a = new Adres(); 
        //     Kontrahent ks = new Kontrahent("Adidas","323232",a);
        //     List<ElementFaktury> elem = new List<ElementFaktury>();

        //     Faktura f = new Faktura(nag, elem);
        // }


        // MessageBox.Show(k.WysokoscKubka);
        // //MessageBox.Show(k.policzObjetoscKubka().ToString());


        // //Button b = ((Button)sender);
        // Button y = new Button();
        // Button b = sender as Button; // rzutowanie

        // y = b; // wskaznik na element , wskazniki c++
        // b.Tag = "test";
        // //if (b.Name == "button1") MessageBox.Show("pierwszy");
        // //else MessageBox.Show(b.Name);
        // //MessageBox.Show(b.Tag.ToString());
        //// MessageBox.Show(y.Tag.ToString());

        // List<string> lista1 = new List<string>();
        // List<string> lista2 = new List<string>();
        // lista1 = lista2;
        // lista1.Add("test");
        #endregion

   
    }
}
