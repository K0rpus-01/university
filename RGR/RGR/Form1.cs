using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RGR
{
    public partial class Form1 : Form
    {
        private TabPage tabpage1, tabpage2, tabpage3, tabpage4, tabpage5;
        private TabControl tabControl;
        private TextBox tBox1, tBox2, tBox3, tBox4,Textbox;
        private Label label1, label2, label3, label4, label5, Slable;
        private Button button;
        private TextBox[] textboxarray = new TextBox[10];
        private TextBox[,] textboxarray2 = new TextBox[6, 5];
        private Label[] lableArray = new Label[6];
        private Button SButton;
        private Label Work1, Work11,Work12,Work13, Work2, Work22, Work3, Work4, Work5;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            this.tabControl = new TabControl();
            this.tabpage5 = new TabPage();
            this.tabpage4 = new TabPage();
            this.tabpage3 = new TabPage();
            this.tabpage2 = new TabPage();
            this.tabpage1 = new TabPage();
            this.tBox1 = new TextBox();
            this.tBox2 = new TextBox();
            this.tBox3 = new TextBox();
            this.tBox4 = new TextBox();
            this.label1 = new Label();
            this.label2 = new Label();
            this.label3 = new Label();
            this.label4 = new Label();
            this.Work1 = new Label();
            this.Work11 = new Label();
            this.Work12 = new Label();
            this.Work13 = new Label();
            this.Work2 = new Label();
            this.Work22 = new Label();
            this.Work3 = new Label();
            this.Work4 = new Label();
            this.Work5 = new Label();
            this.button = new Button();
            this.label5 = new Label();
            this.Textbox = new TextBox();
            this.SButton = new Button();
            this.Slable = new Label();

            tabControl.Location = new Point(0, 0);
            tabControl.Size = new Size(1200, 600);
            tabControl.SelectedIndex = 0;
            tabControl.TabIndex = 0;

            tabpage1.Text = "OOP";
            tabpage1.Size = new Size(250, 215);
            tabpage1.TabIndex = 0;
            tBox1.Location = new Point(100, 200);
            tBox1.Size = new Size(100, 100);
            tBox1.TextChanged += Moneycount;
            tBox2.Location = new Point(250, 200);
            tBox2.Size = new Size(100, 100);
            tBox2.TextChanged += Moneycount;
            tBox3.Location = new Point(400, 200);
            tBox3.Size = new Size(100, 100);
            Work1.Location = new Point(20, 20);
            Work1.Size = new Size(600, 15);
            Work1.Text = "Введіть номінал купюри(1,2,5,10,20,50,100,200,чи 500) і кількість купюр. В результаті отримаєте суму купюр";
            Work11.Location = new Point(100, 175);
            Work11.Size = new Size(100, 15);
            Work11.Text = "Купюри";
            Work12.Location = new Point(250, 175);
            Work12.Size = new Size(100, 15);
            Work12.Text = "Кількість";
            Work13.Location = new Point(400, 175);
            Work13.Size = new Size(100, 15);
            Work13.Text = "Результат";

            tabpage2.Text = "IF";
            tabpage2.Size = new Size(250, 215);
            tabpage2.TabIndex = 1;
            tBox4.Size = new Size(100, 100);
            tBox4.Location = new Point(20, 150);
            button.Size = new Size(100, 50);
            button.Location = new Point(20, 175);
            button.Text = "Дізнатись результат";
            button.MouseClick += btnClick;
            label4.Size = new Size(100, 100);
            label4.Location = new Point(20,100);
            Work2.Location = new Point(20, 20);
            Work2.Size = new Size(500, 15);
            Work2.Text = "Введіть x та натисніть кнопку. Після цього буде знайдений у.";
            Work22.Location = new Point(20, 40);
            Work22.Size = new Size(500, 100);
            Work22.Text = "Якщо число менше 0, то у=x^2+1.\nЯкщо число менше 2 та більше або рівне 0, то y = x^2-1.\nЯкщо число більше2, то y = x.";

            tabpage3.Text = "Array";
            tabpage3.Size = new Size(250, 215);
            tabpage3.TabIndex = 2;
            int x = 50;
            int y = 150;
            for (int i = 0; i < 10; i++)
            {
                textboxarray[i] = new TextBox();
                textboxarray[i].Location = new Point(x, y);
                textboxarray[i].Size = new Size(50, 100);
                tabpage3.Controls.Add(this.textboxarray[i]);
                textboxarray[i].TextChanged += Change;
                x += 65;
            }
            label5.Location = new Point(300, y + 50);
            label5.Size = new Size(250, 100);
            Work3.Location = new Point(20, 20);
            Work3.Size = new Size(500, 50);
            Work3.Text = "Введіть елементи масиву. Автоматично буде проведення сортування елементів на парних позиціях в порядку зростання ";

            tabpage4.Text = "Array 2D";
            tabpage4.Size = new Size(1200, 215);
            tabpage4.TabIndex = 3;
            x = 25;
            y = 100;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    textboxarray2[i, j] = new TextBox();
                    textboxarray2[i, j].Location = new Point(x, y);
                    textboxarray2[i, j].Size = new Size(75, 100);
                    tabpage4.Controls.Add(this.textboxarray2[i, j]);
                    textboxarray2[i, j].TextChanged += Check;
                    x += 100;
                }
                x = 25;
                y += 40;
            }
            x = 520;
            y = 100;
            for (int i = 0; i < 4; i++)
            {
                lableArray[i] = new Label();
                lableArray[i].Size = new Size(250, 20);
                lableArray[i].Location = new Point(x, y);
                tabpage4.Controls.Add(this.lableArray[i]);
                y += 40;
            }
            Work4.Location = new Point(20, 20);
            Work4.Size = new Size(500, 100);
            Work4.Text = "Введіть елементи двувимірного масиву. Автоматично\n буде знайдено кількість повторів значення елементів першого стовпця.";

            tabpage5.Text = "String";
            tabpage5.Size = new Size(600, 300);
            tabpage5.TabIndex = 4;
            Textbox.Location = new Point(50, 25);
            Textbox.AutoSize = false;
            Textbox.Size = new Size(685, 200);
            SButton.Size = new Size(95, 50);
            SButton.Location = new Point(350, 235);
            SButton.Text = "Перевірка";
            SButton.Click += Balance;
            Work5.Location = new Point(50, 235);
            Work5.Size = new Size(350, 50);
            Work5.Text = "Після вводу даних та натиснення на кнопку \nбуде визначено чи збалансовані дужки";
            Slable.Location = new Point(470, 235);
            Slable.Size = new Size(150, 50);

            this.Controls.Add(this.tabControl);
            tabControl.Controls.Add(this.tabpage1);
            tabControl.Controls.Add(this.tabpage2);
            tabControl.Controls.Add(this.tabpage3);
            tabControl.Controls.Add(this.tabpage4);
            tabControl.Controls.Add(this.tabpage5);
            tabpage1.Controls.Add(this.tBox1);
            tabpage1.Controls.Add(this.label1);
            tabpage1.Controls.Add(this.label2);
            tabpage1.Controls.Add(this.label3);
            tabpage1.Controls.Add(this.tBox2);
            tabpage1.Controls.Add(this.tBox3);
            tabpage1.Controls.Add(this.Work1);
            tabpage1.Controls.Add(this.Work12);
            tabpage1.Controls.Add(this.Work13);
            tabpage1.Controls.Add(this.Work11);
            tabpage2.Controls.Add(this.tBox4);
            tabpage2.Controls.Add(this.button);
            tabpage2.Controls.Add(this.label4);
            tabpage2.Controls.Add(this.Work2);
            tabpage2.Controls.Add(this.Work22);
            tabpage3.Controls.Add(this.label5);
            tabpage3.Controls.Add(this.Work3);
            tabpage4.Controls.Add(this.Work4);
            tabpage5.Controls.Add(this.Textbox);
            tabpage5.Controls.Add(this.SButton);
            tabpage5.Controls.Add(this.Work5);
            tabpage5.Controls.Add(this.Slable);

        }
        private void Moneycount(object sender, EventArgs e)
        {
            int a, b;
            if (tBox1.Text != String.Empty && tBox2.Text != String.Empty)
            { int help = int.Parse(tBox1.Text);
                if (help == 1 | help == 2 | help==5 | help==10 | help==20| help==50 | help==100 | help==200 | help==500)
                {
                    a = int.Parse(tBox1.Text);
                    b = int.Parse(tBox2.Text);
                    tBox3.Text = Convert.ToString(a * b);
                }
            }
        }
        private void btnClick(object sender, EventArgs e)
        {
            double a = double.Parse(tBox4.Text);
            if (a < 0)
            {
                a =Math.Pow(a,2) + 1;
                label4.Text = $"y = x^2+1 \n y = {a}";
            }
            else
            {
                if (a >= -10 && a < 2)
                {
                    a = Math.Pow(a, 2) - 1;
                    label4.Text = $"y = x^2-1 \n y = {a}";
                }
                else
                { if(a>2)
                    {
                        
                        label4.Text = $"y = x \n y = {a}";
                    }
                }
            }
        }
        private void Change(object sender, EventArgs e)
        { 
            bool help = true;
            for (int i = 0; i < 10; i++)
            {
                if (textboxarray[i].Text == String.Empty)
                {
                    help = false;
                }
            } 
            if (help)
            {
                double a = 0;
                double sort = double.Parse(textboxarray[0].Text);
                for (int i = 0; i < 8; i+=2)
                {
                    if (Convert.ToDouble(textboxarray[i].Text) > Convert.ToDouble(textboxarray[i+2].Text))
                    {
                        a = double.Parse(textboxarray[i].Text);
                        textboxarray[i].Text = textboxarray[i + 2].Text;
                       textboxarray[i + 2].Text = Convert.ToString(a);  
                    }
                }
                label5.Text = "Сортування пройшло успішно"; 
            }
        }
        private void Check(object sender, EventArgs e)
        {
            bool help=true;
            int first=-1, second=-1, third=-1, forth=-1;
            for (int i = 0; i <4; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (textboxarray2[i, j].Text == String.Empty)
                    {
                        help = false;
                    }
                }
            }
            if (help)
            {
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (Convert.ToDouble(textboxarray2[0, 0].Text) == Convert.ToDouble(textboxarray2[i, j].Text))
                        {
                            first++;
                            lableArray[0].Text = $"К-сть повторень елемента (1:1)-{first}";
                        }
                        if (Convert.ToDouble(textboxarray2[1, 0].Text) == Convert.ToDouble(textboxarray2[i, j].Text))
                        {
                            second++;
                            lableArray[1].Text = $"К-сть повторень елемента (2:1)-{second}";
                        }
                        if (Convert.ToDouble(textboxarray2[2, 0].Text) == Convert.ToDouble(textboxarray2[i, j].Text))
                        {
                            third++;
                            lableArray[2].Text = $"К-сть повторень елемента (3:1)-{third}";
                        }
                        if (Convert.ToDouble(textboxarray2[3, 0].Text) == Convert.ToDouble(textboxarray2[i, j].Text))
                        {
                            forth++;
                            lableArray[3].Text = $"К-сть повторень елемента (4:1)-{forth}";
                        }
                    }
                }  
            }
        }
        private void Balance(object sender, EventArgs e)
        {
            int balance = 0, left = 0, right = 0;
            string str = Textbox.Text;
            foreach(char c in str)
            {
                if(c=='(')
                {
                    balance++;
                    left++;
                }
                if (c == ')')
                {
                    balance--;
                    right++;
                }
                if (balance == 0)
                    Slable.Text = "Дужки збалансовано";
                MessageBox.Show(
                    "Повідомляємо",
                "Дужки збалансовано",
                    MessageBoxButtons.OK);           
                

                if(balance>0)
                 { Slable.Text = $"Незбалансовано. Лівих дужок більше на {left-right} "; }
                if(balance<0)
                 { Slable.Text = $"Незбалансовано. Правих дужок більше на {right - left} "; }
            }
        }
    }
}
