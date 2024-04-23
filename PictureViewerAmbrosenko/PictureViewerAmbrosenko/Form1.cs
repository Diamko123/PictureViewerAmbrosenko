using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureViewerAmbrosenko
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            // Показывает диалоговое окно «Открыть файл».
            // Если пользователь нажмет «ОК», загрузит изображение,
            // которое выбрал пользователь.
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog1.FileName);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Очистит картинку.
            pictureBox1.Image = null;
        }

        private void backgroundButton_Click(object sender, EventArgs e)
        {
            // Показывает диалоговое окно цвета.
            // Если пользователь нажмет кнопку «ОК»,
            // изменит фон элемента управления PictureBox на цвет,
            // выбранный пользователем.
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                pictureBox1.BackColor = colorDialog1.Color;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            // Закрывает форму.
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // Если пользователь устанавливает флажок «Растянуть»,
            // изменяет свойство SizeMode PictureBox на «Растянуть».
            
            if (checkBox1.Checked)
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            else // Если пользователь снимает флажок, изменяет его на «Нормальный».
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
        }

        private void растянутьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage; // Растягивает изображение
        }

        private void нормалToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.Normal; // Возвращает изображение в нормальное
        }
    }
}
