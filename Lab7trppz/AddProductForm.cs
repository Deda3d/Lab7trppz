using Lab7trppz.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7trppz
{
    public partial class AddProductForm : Form
    {
        private MainForm mainForm;

        public AddProductForm(MainForm form)
        {
            InitializeComponent();
            mainForm = form;  

        }
        List<Product> products = new List<Product>();
        public AddProductForm()
        {
            InitializeComponent();
        }

        private void AddProductForm_Load(object sender, EventArgs e)
        {
            ProductMaterialComboBox.Items.AddRange(Part.materials);
            ProductMaterialComboBox.SelectedIndex = 0;
        }
        // Метод для обработки события нажатия на кнопку добавления продукта
        private void ProductAddButton_Click(object sender, EventArgs e)
        {
            // Считываем данные из элементов управления
            string name = ProductNameTextBox.Text;
            string material = ProductMaterialComboBox.SelectedItem?.ToString(); // Выбираем материал из ComboBox
            double weight;
            double.TryParse(ProductWeightTextBox.Text, out weight); // Преобразуем текст в число
            string function = ProductFunctionTextBox.Text;
            int movingParts;
            int.TryParse(MovingPartsTextBox.Text, out movingParts); // Преобразуем текст в число
            int componentsCount;
            int.TryParse(ComponentsCountTextBox.Text, out componentsCount); // Преобразуем текст в число
            string assemblyType = AssemblyTypeTextBox.Text;
            string productType = ProductTypeTextBox.Text;
            string manufacturer = ManufacturerTextBox.Text; // Получаем производителя из нового текстового поля

            // Проверяем, чтобы обязательные поля не были пустыми
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(material) || string.IsNullOrEmpty(function) ||
                string.IsNullOrEmpty(assemblyType) || string.IsNullOrEmpty(productType) || string.IsNullOrEmpty(manufacturer))
            {
                MessageBox.Show("Пожалуйста, заполните все обязательные поля.");
                return;
            }

            // Создаём новый объект Product
            Product newProduct = new Product(
                name,
                material,
                weight,
                function,
                movingParts,
                componentsCount,
                assemblyType,
                productType,
                manufacturer // Добавляем производителя
            );

            // Добавляем продукт в список
            products.Add(newProduct);

            // Опционально, выводим информацию о продукте в консоль или обновляем UI
            Console.WriteLine(newProduct.GetInfo());

            // Очистка полей ввода после добавления продукта
            ClearInputFields();

            string productsInfo = GetProductsInfo(products);
            mainForm.UpdateRichTextBox(productsInfo);
            UpdateProductBlocks();
        }

        // Метод для очистки полей ввода после добавления продукта
        private void ClearInputFields()
        {
            ProductNameTextBox.Clear();
            ProductMaterialComboBox.SelectedIndex = -1;
            ProductWeightTextBox.Clear();
            ProductFunctionTextBox.Clear();
            MovingPartsTextBox.Clear();
            ComponentsCountTextBox.Clear();
            AssemblyTypeTextBox.Clear();
            ProductTypeTextBox.Clear();
            ManufacturerTextBox.Clear(); // Очищаем поле для производителя
        }
        // Метод для преобразования списка продуктов в строку
        public string GetProductsInfo(List<Product> products)
        {
            StringBuilder sb = new StringBuilder();  // Используем StringBuilder для эффективной конкатенации строк

            foreach (var product in products)
            {
                // Формируем строку для каждого продукта, используя его GetInfo() или создавая собственный формат
                sb.AppendLine(product.GetInfo());  // Добавляем информацию о продукте в строку
            }

            return sb.ToString();  // Возвращаем всю информацию как строку
        }
        private void UpdateProductBlocks()
        {
            // Очистим текущие элементы в панели
            mainForm.panel1.Controls.Clear();

            int y = 10; // Начальная позиция для размещения блоков

            for (int index = 0; index < products.Count; index++)
            {
                var product = products[index];

                // Создаем блок для продукта
                GroupBox productBlock = new GroupBox
                {
                    Text = product.Name, // Название продукта как заголовок блока
                    Width = mainForm.panel1.Width - 30, // Размер блока
                    Height = 100,
                    Location = new Point(10, y) // Позиция блока
                };

                // Добавляем текстовые поля с информацией о продукте
                Label productInfo = new Label
                {
                    Text = $"Материал: {product.Material}\n" +
                           $"Вес: {product.Weight} кг\n" +
                           $"Функция: {product.Function}\n" +
                           $"Тип: {product.ProductType}\n" +
                           $"Производитель: {product.Manufacturer}",
                    AutoSize = true,
                    Location = new Point(10, 20)
                };
                productBlock.Controls.Add(productInfo); // Добавляем информацию в блок

                // Добавляем кнопку удаления
                Button deleteButton = new Button
                {
                    Text = "Удалить",
                    Size = new Size(75, 30),
                    Location = new Point(productBlock.Width - 90, 30) // Рядом с правым краем блока
                };

                // Привязываем событие клика к кнопке удаления
                int currentIndex = index; // Фиксируем текущий индекс
                deleteButton.Click += (s, e) =>
                {
                    // Удаляем продукт из списка
                    products.RemoveAt(currentIndex);

                    // Обновляем панель
                    UpdateProductBlocks();
                };

                productBlock.Controls.Add(deleteButton); // Добавляем кнопку в блок
                mainForm.panel1.Controls.Add(productBlock); // Добавляем блок в Panel

                y += 110; // Смещаемся вниз для следующего блока
            }
        }
        public void SaveProductsToFile()
        {
            try
            {
                // Получаем путь к рабочему столу
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string filePath = Path.Combine(desktopPath, "Products.txt");

                // Открываем или создаём файл для записи
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    // Записываем заголовок
                    writer.WriteLine("Список продуктів:");
                    writer.WriteLine("=================");

                    // Записываем каждый продукт из списка
                    foreach (var product in products)
                    {
                        writer.WriteLine($"Назва: {product.Name}");
                        writer.WriteLine($"Матеріал: {product.Material}");
                        writer.WriteLine($"Вага: {product.Weight} кг");
                        writer.WriteLine($"Функція: {product.Function}");
                        writer.WriteLine($"Рухомих частин: {product.MovingParts}");
                        writer.WriteLine($"Кількість компонентів: {product.ComponentsCount}");
                        writer.WriteLine($"Тип складання: {product.AssemblyType}");
                        writer.WriteLine($"Тип виробу: {product.ProductType}");
                        writer.WriteLine($"Виробник: {product.Manufacturer}");
                        writer.WriteLine("-----------------");
                    }

                    // Сообщение о завершении записи
                    writer.WriteLine("Запис завершено.");
                }

                // Вывод сообщения о сохранении
                Console.WriteLine($"Файл успішно збережено за шляхом: {filePath}");
                MessageBox.Show($"Файл успішно збережено!\nШлях: {filePath}", "Збереження успішне", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                // Обработка исключений
                Console.WriteLine($"Сталася помилка при записі файлу: {ex.Message}");
            }
        }


    }
}
