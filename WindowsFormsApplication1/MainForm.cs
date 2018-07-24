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

namespace WindowsFormsApplication1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public static string onePath;
        public static string twoPath;
        public static string orderPath;
        public static string tempPath;

        public string redofilePath { get; set; }

        public bool filecheck = false;

        public void nextImageBox(string deletefilePath)
        {
            if (listBox1_image.Items.Count > listBox1_image.SelectedIndex + 1)
            {
                ++listBox1_image.SelectedIndex;
                pictureBox1.Image = Image.FromFile(Path.Combine(txt_.Text, listBox1_image.Items[listBox1_image.SelectedIndex].ToString()));
                if (pictureBox1.Image.Size.Width < 224 || pictureBox1.Image.Size.Height < 224)
                {
                    lb_SIze.Visible = true;
                }
                else
                {
                    lb_SIze.Visible = false;
                }
            }
            else
            {
                filecheck = true;
            }


            if (File.Exists(deletefilePath))
            {
                if (filecheck == true)
                {
                    pictureBox1.Image = null;
                    lb_SIze.Visible = false;
                }

                GC.Collect();
                GC.WaitForPendingFinalizers();
                File.Delete(deletefilePath);
            }

        }

        public bool checkNextFile()
        {
            if (filecheck == true)
            {
                MessageBox.Show("분류할 이미지가 없습니다");
                return true;
            }
            else if(listBox1_image.SelectedIndex == -1)
            {
                MessageBox.Show("분류할 이미지가 없습니다");
                return true;
            }
            else if( listBox1_image.Items.Count ==0)
            {
                MessageBox.Show("분류할 이미지가 없습니다");
                return true;
            }

            return false;
        }



        private void btn_One_Click(object sender, EventArgs e)
        {
            if (checkNextFile() == true)
                return;

            if(lb_SIze.Visible == true)
            {
                MessageBox.Show("이미지 사이즈 기준미달 !!");
                return;
            }

            string filePathName = Path.Combine(txt_.Text,listBox1_image.Items[listBox1_image.SelectedIndex].ToString());
            string fileName = Path.GetFileName(filePathName);
            try
            {
                redofilePath = Path.Combine(onePath, fileName);
                File.Copy(filePathName, Path.Combine(onePath, fileName));
            }
            catch
            {
            }
            nextImageBox(filePathName);
            //File.Delete(filePathName);
            checksetHeader();
        }

        private void btn_two_Click(object sender, EventArgs e)
        {
            if (checkNextFile() == true)
                return;

            if (lb_SIze.Visible == true)
            {
                MessageBox.Show("이미지 사이즈 기준미달 !!");
                return;
            }

            string filePathName = Path.Combine(txt_.Text, listBox1_image.Items[listBox1_image.SelectedIndex].ToString());
            string fileName = Path.GetFileName(filePathName);
            try
            {
                redofilePath = Path.Combine(twoPath, fileName);
                File.Copy(filePathName, Path.Combine(twoPath, fileName));
            }
            catch
            {
            }
            nextImageBox(filePathName);
            checksetHeader();
        }

        private void btn_order_Click(object sender, EventArgs e)
        {
            if (checkNextFile() == true)
                return;

            if (lb_SIze.Visible == true)
            {
                MessageBox.Show("이미지 사이즈 기준미달 !!");
                return;
            }

            string filePathName = Path.Combine(txt_.Text, listBox1_image.Items[listBox1_image.SelectedIndex].ToString());
            string fileName = Path.GetFileName(filePathName);
            try
            {
                redofilePath = Path.Combine(orderPath, fileName);
                File.Copy(filePathName, Path.Combine(orderPath, fileName));
            }
            catch
            {
            }
            nextImageBox(filePathName);
            checksetHeader();
        }

        private void btn_temp_Click(object sender, EventArgs e)
        {
            if (checkNextFile() == true)
                return;

            if (lb_SIze.Visible == true)
            {
                MessageBox.Show("이미지 사이즈 기준미달 !!");
                return;
            }

            string filePathName = Path.Combine(txt_.Text, listBox1_image.Items[listBox1_image.SelectedIndex].ToString());
            string fileName = Path.GetFileName(filePathName);
            try
            {
                redofilePath = Path.Combine(tempPath, fileName);
                File.Copy(filePathName, Path.Combine(tempPath, fileName));
            }
            catch
            {
            }
            nextImageBox(filePathName);
            checksetHeader();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (checkNextFile() == true)
                return;
            redofilePath = "";
            string filePathName = Path.Combine(txt_.Text, listBox1_image.Items[listBox1_image.SelectedIndex].ToString());
            nextImageBox(filePathName);
            checksetHeader();
        }

        private void btn_getpath_Click(object sender, EventArgs e)
        {
            filecheck = false;
            FolderBrowserDialog fb = new FolderBrowserDialog();

            if (fb.ShowDialog() == DialogResult.OK)
            {
                txt_.Text = fb.SelectedPath;

                //폴더 4개 추가해야함
                onePath = Path.Combine(fb.SelectedPath + @"\01");
                if (!Directory.Exists(Path.Combine(fb.SelectedPath + @"\01")))
                {
                    Directory.CreateDirectory(Path.Combine(fb.SelectedPath + @"\01"));
                }

                twoPath = Path.Combine(fb.SelectedPath + @"\02");
                if (!Directory.Exists(Path.Combine(fb.SelectedPath + @"\02")))
                {
                    Directory.CreateDirectory(Path.Combine(fb.SelectedPath + @"\02"));

                }

                orderPath = Path.Combine(fb.SelectedPath + @"\03");
                if (!Directory.Exists(Path.Combine(fb.SelectedPath + @"\03")))
                {
                    Directory.CreateDirectory(Path.Combine(fb.SelectedPath + @"\03"));
                }

                tempPath = Path.Combine(fb.SelectedPath + @"\04");
                if (!Directory.Exists(Path.Combine(fb.SelectedPath + @"\04")))
                {
                    Directory.CreateDirectory(Path.Combine(fb.SelectedPath + @"\04"));
                }

                listBox1_image.Items.Clear();

               //파일리스트 추가
               DirectoryInfo di = new DirectoryInfo(txt_.Text);
                foreach (FileInfo item in di.GetFiles())
                {
                    listBox1_image.Items.Add(item.Name);
                }

                if (listBox1_image.Items.Count > 0)
                {
                    listBox1_image.SelectedIndex = 0;
                    pictureBox1.Image = Image.FromFile(Path.Combine(txt_.Text, listBox1_image.Items[listBox1_image.SelectedIndex].ToString()));
                    if (pictureBox1.Image.Size.Width < 224 || pictureBox1.Image.Size.Height < 224)
                    {
                        lb_SIze.Visible = true;
                    }
                    else
                    {
                        lb_SIze.Visible = false;
                    }
                }

                //헤더 이름에 이미지 수집 현황을 추가한다.
                checksetHeader();
            }
        }

        public void checksetHeader()
        {
            DirectoryInfo dir = new DirectoryInfo(onePath);

            string header = Path.GetFileNameWithoutExtension(txt_.Text);

            header += " 01 : " + dir.GetFiles().Count() + " / ";

            dir = new DirectoryInfo(twoPath);

            header += " 02 : " + dir.GetFiles().Count() + " / ";

            dir = new DirectoryInfo(orderPath);

            header += " 03 : " + dir.GetFiles().Count();

            this.Text = header;

        }




        public void refreshCombobox()
        {
            filecheck = false;
            listBox1_image.Items.Clear();

            //파일리스트 추가
            DirectoryInfo di = new DirectoryInfo(txt_.Text);
            foreach (FileInfo item in di.GetFiles())
            {
                listBox1_image.Items.Add(item.Name);
            }

            if (listBox1_image.Items.Count > 0)
            {
                listBox1_image.SelectedIndex = 0;
                pictureBox1.Image = Image.FromFile(Path.Combine(txt_.Text, listBox1_image.Items[listBox1_image.SelectedIndex].ToString()));
                if(pictureBox1.Image.Size.Width < 244 || pictureBox1.Image.Size.Height < 244)
                {
                    lb_SIze.Visible = true;
                }
                else
                {
                    lb_SIze.Visible = false;
                }
            }
            checksetHeader();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txt_.Enabled = false;
            this.KeyPreview = true;
            lb_SIze.Visible = false;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if ((listBox1_image.Items.Count < listBox1_image.SelectedIndex + 1))
            {
                MessageBox.Show("분류할 이미지가 없습니다.");
                return;
            }

            if (e.KeyCode == Keys.F1)
            {
                if (lb_SIze.Visible == true)
                {
                    MessageBox.Show("이미지 사이즈 기준미달 !!");
                    return;
                }

                btn_One_Click(null, null);
            }
            else if (e.KeyCode == Keys.F2)
            {
                if (lb_SIze.Visible == true)
                {
                    MessageBox.Show("이미지 사이즈 기준미달 !!");
                    return;
                }

                btn_two_Click(null, null);
            }
            else if (e.KeyCode == Keys.F3)
            {
                if (lb_SIze.Visible == true)
                {
                    MessageBox.Show("이미지 사이즈 기준미달 !!");
                    return;
                }

                btn_order_Click(null, null);
            }
            else if (e.KeyCode == Keys.F4)
            {

                if (lb_SIze.Visible == true)
                {
                    MessageBox.Show("이미지 사이즈 기준미달 !!");
                    return;
                }

                btn_temp_Click(null, null);
            }
            else if (e.KeyCode == Keys.F5)
            {
                btn_delete_Click(null, null);
            }
            else if(e.KeyCode == Keys.F12)
            {
                btn_refresh_Click(null, null);
            }
            else if (e.KeyCode == Keys.F9)
            {
                btn_redo_Click(null, null);
            }

        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            refreshCombobox();
        }

        private void btn_redo_Click(object sender, EventArgs e)
        {
            if (redofilePath == "" || !File.Exists(redofilePath))
            {
                MessageBox.Show("이전 파일은 복구 할 수 없습니다.");
                return;
            }
            else
            {
                string filepath = txt_.Text;
                string fileName = Path.GetFileName(redofilePath);


                File.Copy(redofilePath, Path.Combine(filepath, fileName));
                File.Delete(redofilePath);
                redofilePath = "";
                refreshCombobox();
            }
            checksetHeader();
        }
    }
}
