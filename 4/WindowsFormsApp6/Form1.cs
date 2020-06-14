using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лаб_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Оттенки серого
        /// </summary>
        /// <param name="output"></param>
        public void Gray(PictureBox output)
        {
            int brightness;
            Bitmap bmp = new Bitmap(original.Image);
            Color pixel;
            for (int i = 1; i < bmp.Width; i++)
            {
                for (int j = 1; j < bmp.Height; j++)
                {
                    pixel = bmp.GetPixel(i, j);
                    brightness = (int)(0.29 * pixel.R + 0.59 * pixel.G + 0.11 * pixel.B);
                    bmp.SetPixel(i, j, Color.FromArgb(brightness, brightness, brightness));
                }
            }
            output.Image = bmp;
        }
     
        /// <summary>
        /// Пороговая обработка
        /// </summary>
        private void Threshold() 
        {
            Bitmap bmp = new Bitmap(original.Image);
            float min = 1; float max = 0;
            Color c;
            //for (int i = 0; i < bmp.Width; i++)
            //{
            //    for (int j = 0; j < bmp.Height; j++)
            //    {
            //        c = bmp.GetPixel(i, j);
            //        if (c.GetBrightness() <= min)
            //        {
            //            min = c.GetBrightness();
            //        }
            //        else if (c.GetBrightness() >= max)
            //        {
            //            max = c.GetBrightness();
            //        }
            //    }
            //}
            //int b = (int)((min + max) * 127.5f);  
            int.TryParse(textBox1.Text, out int b);          
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    int newR, newG, newB;
                    c = bmp.GetPixel(i, j);
                    //если яркость выше средней то устанавливаем максимальное значение, если меньше то оставляем исходный цвет
                    if((c.R + c.G + c.B)/3 > b)
                    {
                        newR = 255;
                        newG = 255;
                        newB = 255;
                    }
                    else
                    {
                        newG = c.G;
                        newR = c.R;
                        newB = c.B;
                    }
                    //if (c.R > b)
                    //{
                    //    newR = 255;
                    //}
                    //else
                    //{
                    //    newR = c.R;
                    //}
                    //if (c.B > b) 
                    //{
                    //    newB = 255;
                    //}
                    //else
                    //{
                    //    newB = c.B;
                    //}
                    //if (c.G > b)
                    //{
                    //    newG = 255;
                    //}
                    //else
                    //{
                    //    newG = c.G;
                    //}
                    bmp.SetPixel(i, j, Color.FromArgb(c.A, newR, newG, newB));
                }
                processed.Image = bmp;
            }
        }

        /// <summary>
        /// Масочная фильтрация
        /// </summary>
        private void MaskFilter()
        {
            Bitmap source = new Bitmap(original.Image);
            Bitmap bmp = new Bitmap(source.Width, source.Height);
            int R, G, B;
            Color c;
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    R = 0;
                    G = 0;
                    B = 0;
                    for (int i1 = Math.Max(i - 1, 0); i1 <= Math.Min(i + 1, source.Width - 1); i1++)
                    {
                        for (int j1 = Math.Max(j - 1, 0); j1 <= Math.Min(j + 1, source.Height - 1); j1++)
                        {
                            c = source.GetPixel(i1, j1);
                            R += c.R;
                            G += c.G;
                            B += c.B;
                            ;
                        }
                    }
                    bmp.SetPixel(i, j, Color.FromArgb(R / 9, G / 9, B / 9));
                }
            }
            processed.Image = bmp;
        }

        /// <summary>
        /// Открыть
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Openbutton_Click(object sender, EventArgs e)
        {
            OpenFileDialog open_dialog = new OpenFileDialog(); //создание диалогового окна для выбора файла
            open_dialog.Filter = ("Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*"); //формат загружаемого файла
            if (open_dialog.ShowDialog() == DialogResult.OK) //если в окне была нажата кнопка "ОК"
            {
                try
                {
                    original.Image = new Bitmap(open_dialog.FileName);
                }
                catch
                {
                    DialogResult rezult = MessageBox.Show("Невозможно открыть выбранный файл",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        /// <summary>
        /// Сохранить
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (processed.Image != null) // если изображение в pictureBox2 имеется
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Title = "Сохранить картинку как...";
                save.OverwritePrompt = true; // показывать ли "Перезаписать файл" если пользователь указывает имя файла, который уже существует
                save.CheckPathExists = true; // отображает ли диалоговое окно предупреждение, если пользователь указывает путь, который не существует
                                             // фильтр форматов файлов
                save.Filter = "Image Files(*.BMP)|*.BMP|Image Files(*.JPG)|*.JPG|Image Files(*.GIF)|*.GIF|Image Files(*.PNG)|*.PNG|All files (*.*)|*.*";
                save.ShowHelp = true; // отображается ли кнопка Справка в диалоговом окне
                                      // если в диалоге была нажата кнопка ОК
                if (save.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        processed.Image.Save(save.FileName);
                    }
                    catch
                    {
                        MessageBox.Show("Невозможно сохранить изображение", "Ошибка",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
 
        private void info_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Лаб. 4. Вариант 5,15 Власов Георгий, гр. 6203");
        }

        private void make_it_gray_Click(object sender, EventArgs e)
        {
            if (original.Image != null)
            {
                Gray(processed);
            }
        }

        private void ThresholdButton_Click(object sender, EventArgs e)
        {
            if (original.Image != null)
            {
                Threshold();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (original.Image != null)
            {
                MaskFilter();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
      
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void original_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
       

        
   

