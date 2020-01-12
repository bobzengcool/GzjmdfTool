using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.src;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void select_file_button_Click(object sender, EventArgs e)    
        {
            OpenFileDialog dialog = new OpenFileDialog();
            //dialog.Multiselect = true;//该值确定是否可以选择多个文件
            dialog.Multiselect = false;//该值确定是否可以选择多个文件
            dialog.Title = "请选择需要校验的待加密文件";
            dialog.Filter = "待加密的csv文件（*.csv）|*.csv";
            //dialog.Filter = "所有文件(*.*)|*.*";

            
            //MessageBox.Show(file);
            
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string file = dialog.FileName;
                file_path_textbox.Text = file;
                this.check_file_button.Enabled = true;
            }
            else 
            {
                if(FileToolClass.FileExists(file_path_textbox.Text))
                {
                    this.check_file_button.Enabled = true;
                }
                else
                {
                    this.check_file_button.Enabled = false;
                }
            }
            result_text.Text = "";
            
        }

        private void check_file_button_Click(object sender, EventArgs e)
        {
            string file_path = file_path_textbox.Text;
            if(!FileToolClass.FileExists(file_path))
            {
                MessageBox.Show("文件["+file_path+"]不存在");
                return;

            }

            if (FileToolClass.getFileLine(file_path) > 1000)
            {
                MessageBox.Show("文件记录数不能多于1000条");
                return;
            }

           List<string> fileLineList =  FileToolClass.ReadTextFileToList(file_path);

           int i = 0;
           foreach (string str in fileLineList)
           {
            FileLine fileline= new FileLine(str,i);
            //MessageBox.Show(str);
            
            string result = fileline.checkLine();
            if (result != null)
            {
                this.result_text.Text = result;
                return;
            }

            i++; 
            
           }
           this.result_text.Text = "恭喜你，文件格式完全正确，可以使用加密软件进行加密了。";
 
                
        }


    }
}
