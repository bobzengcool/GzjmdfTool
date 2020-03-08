using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.src
{
    class FileLine
    {
        private string khbm; //客户编码
        private string zhdh; //账户代号
        private string khmc;//客户名称
        private string jyje;//交易金额
        private int num;//编号


        public FileLine(string line ,int number)
        {
            this.Num = number;
            string[] splitFild = line.Split(new string[] { ","}, StringSplitOptions.None);
            this.Khbm = splitFild[0];
            this.Zhdh = splitFild[1];
            this.Khmc = splitFild[2];
            this.Jyje = splitFild[3];
        }

        public void Filed2String() {
            System.Console.WriteLine("客户编号="+Khbm+" 账户代号="+Zhdh+" 客户名称="+Khmc+" 交易金额="+Jyje +" num="+num);
        }

        
        private string checkKhbm() 
        {
            if (string.IsNullOrWhiteSpace(khbm))
            {
                   return "文件第【" + num + "】行，原始文件中客户编码字段为空，请修改\n";
            }

            try
            {
                int ikhbm = int.Parse(khbm);
                if (num != ikhbm)
                {
                    return "文件第【" + num + "】行，原始文件中客户编码字段不连续，请修改\n";
                }
            }
            catch (Exception)
            {
                return "文件第【" + num + "】行，原始文件中客户编码字段不是数字，请修改\n";
            }
            return null;
        }

        private string checkZhdh()
        {
            if (string.IsNullOrWhiteSpace(zhdh))
            {
                return "文件第【" + num + "】行，原始文件中账户代号字段为空，请修改\n";
            }


            if (!StringToolClass.IsNumeric(zhdh))
            {
                if(zhdh.Contains("E"))
                {
                    return "文件第【" + num + "】行，原始文件中账户代号字段不是数字，请检查原始EXCEL文件账户代号列是否变成了科学计数法，或者文件转换成csv格式后不要双击打开\n";
                }
                return "文件第【" + num + "】行，原始文件中账户代号字段不是数字，请修改\n";
            }
            return null;
        }

        private string checkKhmc()
        {
            if (string.IsNullOrWhiteSpace(khmc))
            {
                return "文件第【" + num + "】行，原始文件中客户名称字段为空，请修改\n";
            }

            string skhmc = khmc.Trim();
            if (skhmc.Contains(" "))
            {
                return "文件第【" + num + "】行，原始文件中客户名称列，名字中间有空格，请修改\n";
            }

            return null;
        }

        private string checkJyje()
        {

            if (string.IsNullOrWhiteSpace(jyje))
            {
                return "文件第【" + num + "】行，原始文件中交易金额字段为空，请修改\n";
            }

            if (!StringToolClass.IsNumeric(jyje.Trim()))
            {
                if (jyje.Contains("\""))
                {
                    return "文件第【" + num + "】行，原始文件中交易金额列格式不正确，有可能是EXCEL文档中金额字段列格式不为文本格式，请修改\n";
                }
                else 
                {
                    return "文件第【" + num + "】行，原始文件中交易金额列格式不正确，请修改\n";
                }

            }
            return null;
        }

        public  string checkLine()
        {
            Filed2String();
            if (num == 0)
            {
                return null;
            }
            string results = null;

            if (  checkKhbm() != null || checkZhdh() != null|| checkKhmc() != null ||  checkJyje() != null) 
            {
                results = checkKhbm()+ "\r\n" +checkZhdh() + "\r\n"+ checkKhmc() +"\r\n" + checkJyje() + "\r\n";
                return results;
            }

            return null; 
        }

        public int Num
        {
            get { return num; }
            set { num = value; }
        }


        public string Khbm
        {
            get { return khbm; }
            set { khbm = value; }
        }
       

        public string Zhdh
        {
            get { return zhdh; }
            set { zhdh = value; }
        }
      

        public string Khmc
        {
            get { return khmc; }
            set { khmc = value; }
        }
        

        public string Jyje
        {
            get { return jyje; }
            set { jyje = value; }
        }



    }
   
}
