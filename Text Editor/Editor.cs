using System;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Text_Editor
{
    
    public partial class Editor : Form
    {
        private static readonly char[] delimiterChars = { ' ', ',', '.', ':', ';', '!', '?', '-', ')', '(', '"' };

        private static void RemoveWord(int maxLength, string filePathRead, string filePathWrite, bool deletePunctuation)
        {
            StreamWriter streamWriter = new StreamWriter(filePathWrite);

            foreach(string lineRaw in File.ReadLines(filePathRead, Encoding.Default))
            {
                string lineComplete = string.Empty;
                string word = string.Empty;
                foreach (char element in lineRaw)
                {                    
                    if (!Array.Exists(delimiterChars, delimiter => delimiter == element))
                        {
                        word += element;
                    }
                    else
                    {
                        if (word.Length >= maxLength)
                        {
                            lineComplete += word;                             
                        }

                        word = string.Empty;

                        if (element == ' ')
                        {
                            lineComplete += ' ';
                        }
                        else if (!deletePunctuation)
                        {
                            lineComplete += element;
                        }                    
                    }
                }
                streamWriter.WriteLine(lineComplete);
            }
            streamWriter.Close();
        }

        private bool deletePunctuation = false;
        private string filePathRead = string.Empty;
        private string filePathWrite = string.Empty;
        private int maxLength = -1;

        public Editor()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender; 
            deletePunctuation = checkBox.Checked;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            filePathRead = openFileDialog1.FileName;
            if (filePathRead == "")
            {
                return;
            }
                if (filePathRead.Substring(filePathRead.Length-3) != "txt")
            {
                MessageBox.Show("Файл должен быть в формате .txt!", "Ошибка!");
                return;
            }

            label5.Text = filePathRead;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            filePathWrite = saveFileDialog1.FileName;
            if(filePathWrite == "")
            {
                return;
            }
            if (filePathWrite.Substring(filePathWrite.Length - 4) != ".txt")
            {
                filePathWrite += ".txt";
            }
            label6.Text = filePathWrite;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                maxLength = Convert.ToInt32(textBox1.Text);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(maxLength == -1)
            {
                MessageBox.Show("Введите максимальную длину удаляемых слов!", "Ошибка!");
                return;
            }
            if(filePathRead == string.Empty)
            {
                MessageBox.Show("Укажите путь к файлу!", "Ошибка!");
                return;
            }
            if (filePathWrite == string.Empty)
            {
                MessageBox.Show("Укажите путь сохранения и название файла!", "Ошибка!");
                return;
            }
            RemoveWord(maxLength, filePathRead, filePathWrite, deletePunctuation);
            MessageBox.Show("Готово!", "Сообщение");
            this.Close(); 
        }
    }
}
