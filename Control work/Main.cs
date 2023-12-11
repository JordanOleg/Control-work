using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_work
{
    public partial class Main : Form
    {
        List<Detal> detals;
        int index = -1;
        float orderAmount = 0;
        public Main()
        {
            InitializeComponent();
            detals = new List<Detal>();
            listBox_zakaz.ClearSelected();
            listBox_zakaz.Items.Clear();
            label_saveds.Visible = false;
            tabPage2.Visible = false;
            timer.Interval = 3000;
            timer.Tick += (sender, e) => ReadyOff();
        }
        public Main(List<Detal> detal, int index)
        {
            
            InitializeComponent();
            detals = detal;
            this.index = index;
            listBox_zakaz.ClearSelected();
            listBox_zakaz.Items.Clear();
            label_saveds.Visible = false;
            tabPage2.Visible = false;
            timer.Interval = 3000;
            timer.Tick += (sender, e) => ReadyOff();
        }
        void ReadyStart()
        {
            label_ready.Visible = true;
            timer.Start();
        }
        void ReadyOff()
        {
            label_ready.Visible = false;
            timer.Stop();
        }
        void LabelOrderAmout()
        {
            label_amout.Text = "Ціна замовлення: " + orderAmount.ToString();
        }
        void DesignateСheck(int inx)
        {
            listBox_zakaz.Items.Add("Ім'я: " + detals[inx].Name.ToString());
            listBox_zakaz.Items.Add("Сорт : " + detals[inx].SortValue.ToString());
            listBox_zakaz.Items.Add("Дата виг.: " + detals[inx].DateTime.ToShortDateString());
            listBox_zakaz.Items.Add("Кільк: " + detals[inx].Quant.ToString());
            listBox_zakaz.Items.Add("Ціна: " + detals[inx].Cost.ToString());
            listBox_zakaz.Items.Add("------- Сумма замовлення: " + detals[inx].Sum.ToString() + " -------");
        }
        void AddDetal(Detal detal)
        {
            detals.Add(detal);
            detal.SetSum();
            orderAmount += detal.Sum;
            LabelOrderAmout();
            index++;
        }
        private void button_edit_Click(object sender, EventArgs e)
        {

        }
        void Saved()
        {
            label_saveds.Visible = true;
            tabPage2.Visible = true;
            
        }
        private void button_nextItem_Click(object sender, EventArgs e)
        {
            label_saveds.Visible = false;
            tabPage2.Visible = false;
            string name = string.Empty, sort = string.Empty; float cost = 0;
            DateTime dateTime = DateTime.Now;
            int qualy = 0;
            try
            {
                name = textBox_name.Text;
                if (name == "" && name == " " && name == string.Empty) throw new Exception("Ім'я не може бути пустим!");
                dateTime = dateTimePicker_dateCreate.Value;
                sort = comboBox_sort.SelectedItem.ToString();
                qualy = (int)numericUpDown_quant.Value;
                if (qualy == 0) throw new Exception("Мінімальна кількість 1!");
                cost = Convert.ToSingle(textBox_cost.Text);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return;
            }
            AddDetal(new Detal(name, sort, dateTime, qualy, cost));
            ReadyStart();
            DesignateСheck(index);
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            if(detals.Count > 0)
            {
                Saved();
                label15.Text = "Ваше замовлення на суму: " + orderAmount.ToString();
            }
            else
            {
                MessageBox.Show("Ваша корзинка пуста!", "Error!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }

        private void button_confirm_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Дякуємо за покупку!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button_filters_Click(object sender, EventArgs e)
        {
            listBox_filters.Items.Clear();
            listBox_filters.ClearSelected();
            try
            {
                DateTime date = dateTimePicker_filters.Value;
                string str = comboBox_filters.Text;
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message, "Error!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return;
            }
            foreach(Detal item in detals)
            {
                if(item.SortValue.ToString() == comboBox_filters.SelectedItem.ToString() 
                    && item.DateTime.Date == dateTimePicker_filters.Value.Date)
                {
                    listBox_filters.Items.Add("Ім'я: " + item.Name.ToString());
                    listBox_filters.Items.Add("Сорт : " + item.SortValue.ToString());
                    listBox_filters.Items.Add("Дата виг.: " + item.DateTime.ToShortDateString());
                    listBox_filters.Items.Add("Кільк: " + item.Quant.ToString());
                    listBox_filters.Items.Add("Ціна: " + item.Cost.ToString());
                    listBox_filters.Items.Add("------- Сумма замовлення: " + item.Sum.ToString() + " -------");
                }
            }
        }
    }
}
