using Lab7trppz.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Lab7trppz
{
    public partial class MainForm : Form
    {
        AddProductForm addProductForm;
        private List<Part> partsCollection = new List<Part>();
        private int currentIndex = -1;
        public MainForm()
        {
            InitializeComponent();
        }
        public void UpdateRichTextBox(string text)
        {
            richTextBox1.AppendText(text + Environment.NewLine);  // Добавляем текст в RichTextBox
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MaterialComboBox.Items.AddRange(Part.materials);
            MaterialComboBox.SelectedIndex = 0;
         

        }
        private void AddPartButtonClick(object sender, EventArgs e)
        {
            // Отримання значень із полів форми
            string partName = PartNameTextBox.Text.Trim(); // Назва деталі
            string material = MaterialComboBox.SelectedItem?.ToString(); // Матеріал
            string weightText = PartWeightTextBox.Text; // Получаем текст из TextBox
            double weight;

            if (!double.TryParse(weightText, out weight))
            {
                MessageBox.Show("Введена вага некоректна. Введіть правильне значення.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            // Перевірка даних
            if (string.IsNullOrWhiteSpace(partName))
            {
                MessageBox.Show("Будь ласка, введіть назву деталі.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(material))
            {
                MessageBox.Show("Будь ласка, оберіть матеріал.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (weight <= 0)
            {
                MessageBox.Show("Вага повинна бути більшою за 0.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Створення нового об'єкта Part
            Part newPart = new Part(partName, material, weight);

            // Додавання об'єкта до колекції (наприклад, список деталей)
            partsCollection.Add(newPart);

            // Повідомлення про успіх
            MessageBox.Show($"Деталь '{newPart.Name}' успішно додано!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Очистка полів введення
            PartNameTextBox.Clear();
            MaterialComboBox.SelectedIndex = -1; // Скидаємо вибір
            PartWeightTextBox.Clear();

        }
        private void UpdatePartDetails()
        {
            if (currentIndex >= 0 && currentIndex < partsCollection.Count)
            {
                var currentPart = partsCollection[currentIndex];

                // Виведення деталей у текстові поля
                AddedPartNameTextBox.Text = currentPart.Name;
                AddedPartMaterialTextBox.Text = currentPart.Material;
                AddedPartWeightTextBox.Text = currentPart.Weight.ToString();
            }
            else
            {
                // Якщо немає деталей в колекції, очищуємо поля
                AddedPartNameTextBox.Clear();
                AddedPartMaterialTextBox.Clear();
                AddedPartWeightTextBox.Clear();
            }
        }
        private void PartViewRightButtonClick(object sender, EventArgs e)
        {
            // Якщо поточний індекс останній, переміщаємося на перший елемент
            if (currentIndex < partsCollection.Count - 1)
            {
                currentIndex++;
            }
            else
            {
                currentIndex = 0; // Переходимо до першої деталі
            }
            UpdatePartDetails();
        }

        private void PartViewLeftButtonClick(object sender, EventArgs e)
        {
            // Якщо поточний індекс перший, переміщаємося на останній елемент
            if (currentIndex > 0)
            {
                currentIndex--;
            }
            else
            {
                currentIndex = partsCollection.Count - 1; // Переходимо до останньої деталі
            }
            UpdatePartDetails();
        }

        private void PartViewDeleteButtonClick(object sender, EventArgs e)
        {
            if (currentIndex >= 0 && currentIndex < partsCollection.Count)
            {
                // Отримуємо назву поточної деталі, щоб показати її в повідомленні
                string partName = partsCollection[currentIndex].Name;

                // Видаляємо поточну деталь
                partsCollection.RemoveAt(currentIndex);

                // Якщо список порожній або індекс виходить за межі, очищаємо текстові поля
                if (partsCollection.Count == 0)
                {
                    currentIndex = -1;
                    UpdatePartDetails();
                }
                else
                {
                    // Якщо після видалення залишились елементи, переміщаємося до попередньої чи наступної деталі
                    if (currentIndex >= partsCollection.Count)
                        currentIndex = partsCollection.Count - 1;

                    UpdatePartDetails();
                }

                // Показуємо повідомлення, що деталь була видалена
                MessageBox.Show($"Деталь '{partName}' була успішно видалена.", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Немає вибраної деталі для видалення.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        private void AddProductFormOpener(object sender, EventArgs e)
        {
            AddProductForm addProductForm = new AddProductForm(this);
            this.addProductForm = addProductForm;
            addProductForm.Show();
        }

        public void UpdateRichTextBox(List<Product> products)
        {
            // Очищаем RichTextBox перед обновлением
            richTextBox1.Clear();

            // Проходим по всем продуктам и добавляем их информацию в RichTextBox
            foreach (var product in products)
            {
                richTextBox1.AppendText(product.GetInfo() + "\n\n"); // Добавляем информацию о каждом продукте
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addProductForm.SaveProductsToFile();
        }
    }
}
