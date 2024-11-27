﻿namespace GoodsCatalog
{
    public partial class Form2 : Form
    {
        Tovar t;
        bool addnew;
        public Form2(Tovar t, bool addnew)
        {
            InitializeComponent();
            this.addnew = addnew;
            this.t = t;//Запомнили ссылку на товар
            if (!addnew)
            {/* если форма открывается для редактирования,
               то сначала занесем информацию об изменяемом 
              товаре в текстовые поля */
                textBox1.Text = t.Name;
                textBox2.Text = t.Made_in;
                textBox3.Text = t.Price.ToString();
                Text = "Редактирование товара";//меняем заголовок
            }
            else
                Text = "Добавление товара";//меняем заголовок, если создание товара
        }

        private void OK_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {//Проверка заполнения полей
                MessageBox.Show("Заполните все поля");
                return;
            }
            t.Name = textBox1.Text;
            t.Made_in = textBox2.Text;
            try
            {/* При преобразовании из строки в вещественное число
              произойдет ошибка, если строка неверного формата*/
                t.Price = Convert.ToDouble(textBox3.Text);
            }
            catch
            {
                MessageBox.Show("Цена указана неверно");
                return;
            }

        }
    }
}
