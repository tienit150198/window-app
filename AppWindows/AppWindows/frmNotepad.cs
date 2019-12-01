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
using Microsoft.VisualBasic;
namespace AppWindows
{
    public partial class frmNotepad : Form
    {
        String nameFont;
        float sizeFont = 12;
        Color colorText = Color.Black, colorBackGround = Color.White;
        String textCopy = "";
        Stack<String> storageUndo = null, storageRedo = null;
        string textFind = "";
        bool ignoreChange = false;
        bool isHide = true;
        public frmNotepad()
        {
            InitializeComponent();
            initializeText();
            initializeColor();
        }

        private void initializeColor()
        {
            btnBackgroundCorlor.BackColor = colorBackGround;
            btnColor.BackColor = colorText;
            storageUndo = new Stack<String>();
            storageRedo = new Stack<String>();
            ignoreChange = false;
        }

        private void initializeText()
        {
            foreach (FontFamily f in FontFamily.Families)
            {
                cbbFont.Items.Add(f.Name);
                if (f.Name.Equals("Times New Roman"))
                {
                    cbbFont.Text = f.Name;
                }
            }

            for(int i = 10; i <= 72; i++)
            {
                if (i >= 15)
                    i++;
                if (i > 30)
                    i += 5;
                cbbSize.Items.Add(i + "");
            }

            // ------------------- set default ------------------------//
            cbbSize.Text = "12";
            txtEditor.Hide();
            isHide = true;
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if(!isHide)
                saveFile();
        }

        public void saveFile()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            DialogResult result = saveFileDialog.ShowDialog();

            saveFileDialog.Filter = "Text Files (*.txt)|*.txt";

            if (result == DialogResult.OK)
            {
                String file = saveFileDialog.FileName;
                StreamWriter sw = new StreamWriter(file + ".txt");
                sw.WriteLine(txtEditor.Text);

                sw.Close();
            }
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            cutText();
        }

        private void frmNotepad_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            Redo();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            oldFile();
            newFile();
        }

        public void newFile()
        {
            txtEditor.ResetText();
            txtEditor.Show();
            isHide = false;
        }

        public void openFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*.txt)|*.txt";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtEditor.Text = File.ReadAllText(openFileDialog.FileName);
            }
        }

        private void cbbFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                nameFont = cbbFont.SelectedIndex.ToString();
                txtEditor.SelectionFont = new Font(nameFont, sizeFont);
            }
            catch
            {
                MessageBox.Show(null, "Font " + nameFont + " không hỗ trợ", "Message");
            }
            
        }

        private void cbbSize_SelectedValueChanged(object sender, EventArgs e)
        {
            sizeFont = float.Parse(cbbSize.SelectedItem.ToString());
            txtEditor.SelectionFont = new Font(nameFont, sizeFont);
        }

        private void btnBackgroundCorlor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                colorBackGround = colorDialog.Color;
                btnBackgroundCorlor.BackColor = colorBackGround;

                txtEditor.SelectionBackColor = colorBackGround;
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            oldFile();
            openFile();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFile();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            oldFile();
            newFile();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFile();
        }

        private void seletecAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtEditor.SelectAll();
        }

        private void pasteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!isHide)
                copyText();
        }

        public void copyText()
        {
            textCopy = txtEditor.Text.Substring(txtEditor.SelectionStart, txtEditor.SelectionLength);
        }

        private void pasteToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (!isHide)
                pasteText();
        }

        public void pasteText()
        {
            string textTmp = txtEditor.Text.ToString();
            textTmp = textTmp.Insert(txtEditor.SelectionStart, textCopy);

            txtEditor.Text = textTmp;
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isHide)
            {
                FontDialog fontDialog = new FontDialog();

                if (fontDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        nameFont = fontDialog.Font.Name;
                        sizeFont = fontDialog.Font.Size;
                        txtEditor.SelectionFont = new Font(nameFont, sizeFont);

                        cbbFont.Text = nameFont;
                        cbbSize.Text = (Math.Ceiling(fontDialog.Font.Size) + "");
                    }
                    catch
                    {
                        MessageBox.Show(null, "Font " + nameFont + " không hỗ trợ", "Message");
                    }

                }
            }
            
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isHide)
            {
                ColorDialog colorDialog = new ColorDialog();
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    colorBackGround = colorDialog.Color;
                    btnBackgroundCorlor.BackColor = colorBackGround;

                    txtEditor.SelectionBackColor = colorBackGround;
                }
            }
            
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            if (!isHide)
                Undo();
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if(colorDialog.ShowDialog() == DialogResult.OK)
            {
                colorText = colorDialog.Color;
                btnColor.BackColor = colorText;
                
                txtEditor.SelectionColor = colorText;
            }
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isHide)
                Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isHide)
                Redo();
        }

        private void btnZoomIn_Click(object sender, EventArgs e)
        {
            if(!isHide)
                zoomIn();
        }

        public void zoomIn()
        {
            if(txtEditor.ZoomFactor <= 64)
                txtEditor.ZoomFactor = txtEditor.ZoomFactor + (float)0.2;
        }

        public void zoomOut()
        {
            if(txtEditor.ZoomFactor >= 0.5)
                txtEditor.ZoomFactor = txtEditor.ZoomFactor - (float)0.2;
        }

        private void btnZoomOut_Click(object sender, EventArgs e)
        {
            if (!isHide)
                zoomOut();
        }

        private void zoomInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isHide)
                zoomIn();
        }

        private void zoomOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isHide)
                zoomOut();
        }

        private void cutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!isHide)
                cutText();
        }

        public void cutText()
        {
            textCopy = txtEditor.Text.Substring(txtEditor.SelectionStart, txtEditor.SelectionLength);
            string textTmp = txtEditor.Text.ToString();
            textTmp = textTmp.Remove(txtEditor.SelectionStart, textCopy.Length);

            txtEditor.Text = textTmp;
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isHide)
                cutText();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isHide)
                copyText();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isHide)
                pasteText();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isHide)
                oldFile();
        }

        public void cancel()
        {
            txtEditor.ResetText();
            txtEditor.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (!isHide)
                oldFile();
        }

        public void oldFile()
        {
            if (!isHide)
            {
                DialogResult result = MessageBox.Show(null, "Bạn có muốn lưu lại chương trình không?", "Thông báo", MessageBoxButtons.OKCancel);

                if (result == DialogResult.OK)
                {
                    isHide = true;
                    saveFile();
                }
                else
                {
                    isHide = true;
                    cancel();
                }
            }
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(!isHide)
                findText();
            else
            {
                MessageBox.Show("Vui lòng tạo file mới trước khi tìm kiếm");
            }
        }

        public void findText()
        {
            textFind = Interaction.InputBox("", "Nhập text cần tìm", "", -1, -1);

            if (!textFind.Trim().Equals("")) { 
                // clear text hightlight before find
                clearBeforeFind(false);
                hightlightAllText(txtEditor, textFind, Color.Yellow);


            }
        }
        public void replaceText()
        {
            string textReplace = Interaction.InputBox("", "Nhập text cần thay thế", "", -1, -1);
            if (!textReplace.Trim().Equals(""))
            {
                // clear text hightlight before find
                clearBeforeFind(false);
                hightlightAllText(txtEditor, textFind, Color.Yellow);

                DialogResult result = MessageBox.Show("Bạn có muốn thay thế toàn bộ hay không?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(result == DialogResult.Yes)
                    replaceAllText(txtEditor, textFind, textReplace);

            }
        }

        public void replaceAllText(RichTextBox txtEditor, string textFind, string textReplace)
        {
               string textTemp = txtEditor.Text.Replace(textFind, textReplace);
               txtEditor.Text = textTemp;
        }

        public void hightlightAllText(RichTextBox txtEditor, string textFind, Color _color)
        {
            int index = 0;
            while (index < txtEditor.Text.LastIndexOf(textFind))
            {
                txtEditor.Find(textFind.Trim(), index, txtEditor.TextLength, RichTextBoxFinds.None);
                //       txtEditor.SelectionLength = textFind.Length;
                txtEditor.SelectionBackColor = _color;
                index = txtEditor.Text.IndexOf(textFind, index) + 1;
            }
        }

        public void clearBeforeFind(bool flag)
        {
            hightlightAllText(txtEditor, textFind, Color.White);
            if (flag)
            {
                textFind = "";
                txtEditor.SelectionStart = 0;
                txtEditor.SelectionLength = 0;
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string textTmp = txtEditor.Text.ToString();
            textTmp = textTmp.Remove(txtEditor.SelectionStart, textCopy.Length);

            txtEditor.Text = textTmp;
        }

        private void txtEditor_Click(object sender, EventArgs e)
        {
            if (textFind.Trim().Length > 0)
                clearBeforeFind(true);
        }

        private void txtText_TextChanged(object sender, EventArgs e)
        {
            if (!ignoreChange)
            {
                storageUndo.Push(txtEditor.Text);
            }
        }

        private void replaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isHide)
            {
                findText();
                replaceText();
            }
            else
            {
                MessageBox.Show("Vui lòng tạo file mới trước khi tìm kiếm");
            }
        }

        public void Undo()
        {
            if(storageUndo.Count > 0)
            {
                ignoreChange = true;
                storageRedo.Push(storageUndo.Peek());
                storageUndo.Pop();
                txtEditor.Text = storageUndo.Peek();
                ignoreChange = false;
            }
        }

        public void Redo()
        {
            if(storageRedo.Count > 0)
            {
                txtEditor.Text = storageRedo.Peek();
                storageUndo.Push(storageRedo.Peek());
                storageRedo.Pop();
            }
        }
    }
}
