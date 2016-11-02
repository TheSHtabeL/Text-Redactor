using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
//using Novacode;
//using DocumentFormat.OpenXml;

using Word = Microsoft.Office.Interop.Word;
using Spire.Doc;
//using DocumentFormat.OpenXml.Wordprocessing;
//using DocumentFormat.OpenXml.Packaging;
//using GemBox.Document;

namespace TextRedactor
{
    public partial class WrITe : Form
    {
        public WrITe()
        {
            InitializeComponent();
        }

        private void файлToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuOpenDocument(object sender, EventArgs e)
        {
            OpenFileDialog dialog = openFileDialog;
            dialog.DefaultExt = "";
            dialog.Filter = "*.txt|*.txt|*.doc|*.doc|*.docx|*.docx|Все файлы|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string filepath = dialog.FileName.ToString();
                if (filepath.EndsWith(".docx"))
                {
                    ReadDocX(filepath);
                    currentDocument.setFormat(".docx");
                }
                else if (filepath.EndsWith(".doc"))
                {
                    ReadDocX(filepath);
                    currentDocument.setFormat(".doc");
                }
                else if(filepath.EndsWith(".txt"))
                {
                    ReadTxt(filepath);
                    currentDocument.setFormat(".txt");
                }else
                {
                    MessageBox.Show("Ошибка при открытии файла: неверный формат", "Error", MessageBoxButtons.OK);
                    return;
                }
                Text = filepath;
                currentDocument.setFilepath(filepath);
                currentDocument.setStatus(true);
                currentDocument.setChanges(false);
                CheckTitle();
            }
        }

        private void текстToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            RichTextBox rich = (RichTextBox)sender;
            int i = rich.TextLength;
            BottomSymbolsCount.Text = "Количество символов: " + i + ".";
            currentDocument.setChanges(true);
            if(!currentDocument.getStatus() && Text.StartsWith("WrIte"))
            {
                Text = "Новый документ";
            }
            CheckTitle();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click_1(object sender, EventArgs e)
        {
           
        }
     
        private void MenuDocumentSave_Click(object sender, EventArgs e)
        {
            //Сохранить в файл
            if (currentDocument.getStatus())
            {
                Save();
            }else
            {
                SaveToFile();
            }
        }

        private void MenuDocumentSaveAs_Click(object sender, EventArgs e)
        {
            SaveToFile();
        }

        private void SaveToFile()
        {
            SaveFileDialog dialog = saveFileDialog;
            dialog.DefaultExt = "";
            dialog.Filter = "*.txt|*.txt|*.doc|*.doc|*.docx|*.docx|Все файлы|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string filepath = dialog.FileName.ToString();
                if (filepath.EndsWith(".docx"))
                {
                    currentDocument.setFormat(".docx");
                }
                else if (filepath.EndsWith(".doc"))
                {
                    currentDocument.setFormat(".doc");
                }
                else if (filepath.EndsWith(".txt"))
                {
                    currentDocument.setFormat(".txt");
                }
                else
                {
                    MessageBox.Show("Ошибка при открытии файла: неверный формат", "Error", MessageBoxButtons.OK);
                    return;
                }
                currentDocument.setFilepath(filepath);
                currentDocument.setStatus(true);
                Save();
                Text = filepath;
                CheckTitle();
            }
        }

        private void MenuSizeText_ValueChanged(object sender, EventArgs e)
        {
            int i = (int)MenuSizeText.Value;
            MainTextWindow.SelectionFont = new System.Drawing.Font(MainTextWindow.SelectionFont.FontFamily, i);
           
        }

        private void MainTextWindow_MouseClick(object sender, MouseEventArgs e)
        {
            if (MainTextWindow.SelectionFont != null)
            {
                MenuSizeText.Value = (int)MainTextWindow.SelectionFont.Size;
            }
        }

        private void MenuAlignmentLeft_Click(object sender, EventArgs e)
        {
            MainTextWindow.SelectionAlignment = System.Windows.Forms.HorizontalAlignment.Left;
        }

        private void MenuAlignmentCenter_Click(object sender, EventArgs e)
        {
            MainTextWindow.SelectionAlignment = System.Windows.Forms.HorizontalAlignment.Center;
        }

        private void MenuAlignmentRight_Click(object sender, EventArgs e)
        {
            MainTextWindow.SelectionAlignment = System.Windows.Forms.HorizontalAlignment.Right;
        }

        private void MenuDocumentNew_Click(object sender, EventArgs e)
        {
            if (!currentDocument.getStatus())
            {
                if (MainTextWindow.Text.Length != 0)
                {
                    DialogResult result = MessageBox.Show("Имеется несохранённый текст. Сохранить в документ?", "Сохранить изменения?", MessageBoxButtons.YesNoCancel);
                    if(result == DialogResult.Cancel)
                    {
                        return;
                    }else if(result == DialogResult.Yes)
                    {
                        SaveToFile();
                        MainTextWindow.Text = "";
                    }
                }
                Text = "Новый документ";
            }
            else if(currentDocument.getChanges()) {
                DialogResult result = MessageBox.Show("В файле имеются несохранённые изменения. Сохранить в документ?", "Сохранить изменения?", MessageBoxButtons.YesNoCancel);
                if(result == DialogResult.Cancel)
                {
                    return;
                }else if (result == DialogResult.Yes)
                {
                    Save();
                }
                currentDocument.clearData();
                MainTextWindow.Text = "";
                Text = "Новый документ";
            }
        }
        private void ReadTxt (string filepath)
        {
            MainTextWindow.LoadFile(filepath, RichTextBoxStreamType.PlainText);
        }
        
        private void Save()
        {
            if (currentDocument.getFormat() == ".docx")
            {
                //MainTextWindow.SelectAll();
                //if (MainTextWindow.Text.Length != 0)
                //{
                //    MainTextWindow.Copy();
                //}
                //Word.Application docx = new Word.Application();
                //Word.Document document;
                //if (System.IO.File.Exists(currentDocument.getFilepath()))
                //{
                //    document = docx.Documents.Open(currentDocument.getFilepath());
                //}else
                //{
                //    document = docx.Documents.Add();
                //}
                //document.SaveAs(currentDocument.getFilepath());
                //document.Activate();
                //document.ActiveWindow.Selection.WholeStory();
                //document.ActiveWindow.Selection.Paste();
                //document.Close();
                //docx.Quit();
                MainTextWindow.SaveFile("Temp");
                Spire.Doc.Document source = new Document("Temp");
                Spire.Doc.Document destination;
                if ((currentDocument.getFilepath() != null) && File.Exists(currentDocument.getFilepath()) ) {
                    destination = new Document(currentDocument.getFilepath());
                    destination.Sections[0].Body.ChildObjects.Clear(); //Чистим документ от старого текста
                }else
                {
                    destination = new Document();
                    destination.CreateMinialDocument();
                }
                foreach (Section section in source.Sections)
                {
                    foreach (DocumentObject documentObject in section.Body.ChildObjects)
                    {
                        destination.Sections[0].Body.ChildObjects.Add(documentObject.Clone()); //Загружаем в документ новый текст
                    }
                }
                destination.SaveToFile(currentDocument.getFilepath()); //Сохраняем изменения
                File.Delete("Temp");
            }
            else if (currentDocument.getFormat() == ".doc")
            {
                //Word.Application docx = new Word.Application();
                //Word.Document document = new Word.Document();
                //document = docx.Documents.Add();
                //document.Activate();
                //docx.Selection.TypeText(MainTextWindow.Text);
                //document.SaveAs(currentDocument.getFilepath());
                //document.Close();
                //docx.Quit();
                MainTextWindow.SaveFile("Temp");
                Spire.Doc.Document source = new Document("Temp");
                Spire.Doc.Document destination;
                if ((currentDocument.getFilepath() != null) && File.Exists(currentDocument.getFilepath()))
                {
                    destination = new Document(currentDocument.getFilepath());
                    destination.Sections[0].Body.ChildObjects.Clear(); //Чистим документ от старого текста
                }
                else
                {
                    destination = new Document();
                    destination.CreateMinialDocument();
                }
                foreach (Section section in source.Sections)
                {
                    foreach (DocumentObject documentObject in section.Body.ChildObjects)
                    {
                        destination.Sections[0].Body.ChildObjects.Add(documentObject.Clone()); //Загружаем в документ новый текст
                    }
                }
                destination.SaveToFile(currentDocument.getFilepath()); //Сохраняем изменения
                File.Delete("Temp");
            }else if(currentDocument.getFormat() == ".txt")
            {
                MainTextWindow.SaveFile(currentDocument.getFilepath(), RichTextBoxStreamType.PlainText);
            }
            currentDocument.setChanges(false);
            CheckTitle();
        }
        private void ReadDocX(string filepath)
        {
            //Метод, в котором мы читаем .docx
            //Word.Application docx = new Word.Application();
            //Word.Document document = docx.Documents.Open(filepath); //Открываем документ docx
            //MainTextWindow.Clear(); //Чистим текстовую область от текста
            //document.ActiveWindow.Selection.WholeStory(); //Получаем контроль над буфером обмена
            //document.ActiveWindow.Selection.Copy(); //Копируем туда содержимое документа
            //MainTextWindow.Paste(); //Вставляем содержимое с форматированием в текстовое окно
            //document.Close();
            //docx.Quit();
            //var document = DocX.Load(filepath);
            //document.
            //MainTextWindow.Paste();
            //WordprocessingDocument document = WordprocessingDocument.Open(filepath, true);
            //Body body = document.MainDocumentPart.Document.Body;

            //ComponentInfo.SetLicense("FREE-LIMITED-KEY");
            //DocumentModel document = DocumentModel.Load(filepath);
            //document.Content.SaveToClipboard();
            //MainTextWindow.Paste();

            Spire.Doc.Document document = new Document(filepath);
            document.SaveToFile("Temp", FileFormat.Rtf);
            MainTextWindow.LoadFile("Temp");
            File.Delete("Temp");
        }
        private void CheckTitle()
        {
            if(!currentDocument.getChanges())
            {
                if (Text.EndsWith("*")){
                    Text = Text.Remove(Text.Length - 1, 1);
                }
            }else if ( (currentDocument.getStatus() || Text.StartsWith("Новый документ") )&& !Text.EndsWith("*") )
            {
                Text += "*";
            }
        }
        
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
        
        class CurrentDocument
        {
            public CurrentDocument()
            {
                format = null;
                filepath = null;
                status = false;
                changes = false;
            }
            public void clearData()
            {
                format = null;
                filepath = null;
                status = false;
                changes = false;
            }
            public string getFormat()
            {
                return format;
            }
            public string getFilepath()
            {
                return filepath;
            }
            public bool getStatus()
            {
                return status;
            }
            public bool getChanges()
            {
                return changes;
            }
            public void setFormat(string format)
            {
                this.format = format;
            }
            public void setFilepath(string filepath)
            {
                this.filepath = filepath;
            }
            public void setStatus(bool status)
            {
                this.status = status;
            }
            
            public void setChanges(bool changes)
            {
                this.changes = changes;
            }
            private bool status;
            private bool changes; // True = есть изменения, False = нет изменений
            private string filepath;
            private string format;
        }
        
        private void MenuDocumentClose_Click(object sender, EventArgs e)
        {
            if (!currentDocument.getStatus())
            {
                if (MainTextWindow.Text.Length != 0)
                {
                    DialogResult result = MessageBox.Show("Имеется несохранённый текст. Сохранить в документ?", "Сохранить изменения?", MessageBoxButtons.YesNoCancel);
                    if (result == DialogResult.Cancel)
                    {
                        return;
                    }
                    else if (result == DialogResult.Yes)
                    {
                        SaveToFile();
                    }
                }
                MainTextWindow.Text = "";
                Text = "WrIte";
            }
            else if (currentDocument.getChanges())
            {
                DialogResult result = MessageBox.Show("В файле имеются несохранённые изменения. Сохранить в документ?", "Сохранить изменения?", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Cancel)
                {
                    return;
                }
                else if (result == DialogResult.Yes)
                {
                    Save();
                }
                currentDocument.clearData();
                MainTextWindow.Text = "";
                Text = "WrIte";
            }
        }

        private void WrITe_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (currentDocument.getChanges())
            {
                MenuDocumentClose_Click(sender, e);
            }
        }
    }
}
