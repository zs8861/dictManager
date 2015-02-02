using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using System.Collections;
using System.IO;

namespace dictManager
{
    public partial class FormMain : Office2007Form
    {
        private string m_strCommonDic = "Common.dic"; //通用词库表
        private string m_strSynonymDic = "Synonym.dic"; //同义词库表
        private string m_strAbbrCategoryDic = "Abbr_Category.dic"; //缩略词库表
        private string m_strAbbrWordlistDic = "Abbr_Wordlist.dic"; //缩略词库表
        private string m_strDisableDic = "Disable.dic"; //停用词词库表
        private string m_strProductDic = "Product.dic"; //小商品词库表
        private string m_strBrandDic = "Brand.dic"; //品牌词库表
        private string m_strShopDic = "Shop.dic"; //商铺名称词库表
        private string m_strAddressDic = "Addr.dic"; //地名词库表
        
        private ArrayList m_ArrFiles = new ArrayList();
        private HashSet<string> m_dicts = new HashSet<string>();

        private struct Category //类目定义
        {
            private string catId;
            public string CatId
            {
                get { return catId; }
                set { catId = value; }
            }
            private string catName;
            public string CatName
            {
                get { return catName; }
                set { catName = value; }
            }
            private string catParentId;
            public string CatParentId
            {
                get { return catParentId; }
                set { catParentId = value; }
            }
        }

        public FormMain()
        {
            InitializeComponent();
           
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            ConsoleEx.AllocConsole();
            progressBarX1.Value = 100;
            System.Console.Out.WriteLine("---ConsoleEx.AllocConsole()---");
        }
        /***批量导入词库数据***/
        private void buttonX_Import_Click(object sender, EventArgs e)
        {
            m_ArrFiles.Clear();
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Multiselect = true;
            dlg.InitialDirectory = @"c:\";
            dlg.RestoreDirectory = true;
            dlg.Filter = "字典文件(*.dic)|*.dic|所有文件(*.*)|*.*";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string strDisplay = "";
                foreach (string s in dlg.FileNames)
                {
                    m_ArrFiles.Add(s);
                    strDisplay += s + "\r\n";
                }
                textBoxX_Show.Text = strDisplay;
            }
        }

        private void buttonX_ClearData_Click(object sender, EventArgs e)
        {
            m_ArrFiles.Clear();
            textBoxX_Show.Text = "";
            MessageBox.Show("数据清除成功！");
        }

        private void processData(string extName)
        {
            if (m_ArrFiles.Count == 0)
            {
                MessageBox.Show("请先进行词库数据导入！");
                return;
            }
            /***添加单词到词典***/
            progressBarX1.Value = 0;
            m_dicts.Clear();
            foreach (string filename in m_ArrFiles)
            {
                FileStream fs = new FileStream(filename, FileMode.Open);
                StreamReader sr = new StreamReader(fs, Encoding.GetEncoding("utf-8"));
                while (sr.EndOfStream == false)
                {
                    string s = sr.ReadLine().Trim();
                    if (s != "")
                    {
                        m_dicts.Add(s);
                    }
                }
                sr.Close();
                fs.Close();
            }
            /***对词典排序后导出到文件***/
            progressBarX1.Value = 50;
            List<string> dictsList = m_dicts.OrderBy(x => x).ToList();
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "字典文件(*.dic)|*.dic|所有文件(*.*)|*.*";
            dlg.AddExtension = true;
            dlg.RestoreDirectory = true;
            dlg.FileName = extName;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(dlg.FileName, FileMode.Create);
                StreamWriter sw = new StreamWriter(fs, Encoding.GetEncoding("utf-8"));
                foreach (string word in dictsList)
                {
                    sw.WriteLine(word);
                }
                sw.Close();
                fs.Close();
                progressBarX1.Value = 100;
                MessageBox.Show("数据导出成功！");
            }
            else
            {
                progressBarX1.Value = 100;
            }
        }

        // 同义词去重，只要把等号两边完全相同的去重，其他保留即可
        private void processData2(string extName)
        {
            if (m_ArrFiles.Count == 0)
            {                                                                                                  
                MessageBox.Show("请先进行词库数据导入！");
                return;
            }
            /***添加单词到词典***/
            progressBarX1.Value = 0;
            m_dicts.Clear();
            foreach (string filename in m_ArrFiles)
            {
                FileStream fs = new FileStream(filename, FileMode.Open);
                StreamReader sr = new StreamReader(fs, Encoding.GetEncoding("utf-8"));
                while (sr.EndOfStream == false)
                {
                    string s = sr.ReadLine().Trim();
                    if (s != "")
                    {
                        string[] sArray = s.Split('=');
                        if (sArray[0] != sArray[1])
                        {
                            m_dicts.Add(s);
                        }
                        else
                        {
                            System.Console.Out.WriteLine(sArray[0] + "=" + sArray[1]);
                        }
                    }
                }
                sr.Close();
                fs.Close();
            }
            /***对词典排序后导出到文件***/
            progressBarX1.Value = 50;
            List<string> dictsList = m_dicts.OrderBy(x => x).ToList();
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "字典文件(*.dic)|*.dic|所有文件(*.*)|*.*";
            dlg.AddExtension = true;
            dlg.RestoreDirectory = true;
            dlg.FileName = extName;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(dlg.FileName, FileMode.Create);
                StreamWriter sw = new StreamWriter(fs, Encoding.GetEncoding("utf-8"));
                foreach (string word in dictsList)
                {
                    sw.WriteLine(word);
                }
                sw.Close();
                fs.Close();
                progressBarX1.Value = 100;
                MessageBox.Show("数据导出成功！");
            }
            else
            {
                progressBarX1.Value = 100;
            }
        }

        /*
         * 1、将2.txt过滤（先“ ”，再“=”）成一个一个的词，放置于HashSet_1中；
         * 2、将1.txt导入HashSet_2中
         * 3、遍历HashSet_1，将HashSet_1每个元素s在HashSet_2对比，如果s在HashSet_2有相等的元素存在，则删除HashSet_2的
         * 4、将HashSet_2中剩下的元素保留并输出
         */
        private void processData3(string extName)
        {
            progressBarX1.Value = 0; //进度条初始化
            
            //按行读取词典到dict1
            HashSet<string> dict1 = new HashSet<string>();            
            FileStream fs1 = new FileStream(@"C:\1.txt", FileMode.Open);
            StreamReader sr1 = new StreamReader(fs1, Encoding.GetEncoding("utf-8"));
            while (sr1.EndOfStream == false)
            {
                string s = sr1.ReadLine().Trim();
                if (s != "")
                {
                    dict1.Add(s);
                }
            }
            sr1.Close();
            fs1.Close();

            //按行读取词典到dict2
            HashSet<string> dict2 = new HashSet<string>();
            FileStream fs2 = new FileStream(@"C:\2.txt", FileMode.Open);
            StreamReader sr2 = new StreamReader(fs2, Encoding.GetEncoding("utf-8"));
            while (sr2.EndOfStream == false)
            {
                string s = sr2.ReadLine().Trim();
                if (s != "")
                {
                    dict2.Add(s);
                }
            }
            sr2.Close();
            fs2.Close();

            //对2.txt进行过滤
            HashSet<string> dict3 = new HashSet<string>();
            foreach (string word in dict2)
            {
                string[] sArray1 = word.Split(' ');
                string[] sArray2 = sArray1[1].Split('=');
                foreach (string s in sArray2)
                {
                    dict3.Add(s);
                }
            }

            //遍历dict3
            foreach (string word in dict3)
            {
                if (dict1.Contains(word))
                {
                    dict1.Remove(word);
                }                
            }

            //输出剩余的dict1
                       
           
            /***对词典排序后导出到文件***/
            progressBarX1.Value = 50;
            List<string> dictsList = dict1.OrderBy(x => x).ToList();
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "字典文件(*.dic)|*.dic|所有文件(*.*)|*.*";
            dlg.AddExtension = true;
            dlg.RestoreDirectory = true;
            dlg.FileName = extName;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(dlg.FileName, FileMode.Create);
                StreamWriter sw = new StreamWriter(fs, Encoding.GetEncoding("utf-8"));
                foreach (string word in dictsList)
                {
                    sw.WriteLine(word);
                }
                sw.Close();
                fs.Close();
                progressBarX1.Value = 100;
                MessageBox.Show("数据导出成功！");
            }
            else
            {
                progressBarX1.Value = 100;
            }
        }

        /***生成通用词典***/
        private void buttonX_GenCommonDic_Click(object sender, EventArgs e)
        {
            processData(m_strCommonDic);
        }

        /***生成同义词词库***/
        private void buttonX_GenSynonymDic_Click(object sender, EventArgs e)
        {

        }

        /***生成缩略词词库***/
        private void buttonX_GenAbbrDic_Click(object sender, EventArgs e)
        {
            if (m_ArrFiles.Count == 0)
            {
                MessageBox.Show("请先进行词库数据导入！");
                return;
            }
            /***添加单词到词典***/
            progressBarX1.Value = 0;
            m_dicts.Clear();
            foreach (string filename in m_ArrFiles)
            {
                FileStream fs = new FileStream(filename, FileMode.Open);
                StreamReader sr = new StreamReader(fs, Encoding.GetEncoding("utf-8"));
                while (sr.EndOfStream == false)
                {
                    string s = sr.ReadLine().Trim();
                    if (s != "")
                    {
                        string[] sArray = s.Split('=');
                        if (sArray[0].Split(' ')[0].Length <= 2)
                        {
                            Category cat = new Category();
                            cat.CatId = sArray[0].Split(' ')[0];
                            cat.CatName = sArray[0].Split(' ')[1];
                            cat.CatParentId = "NULL";
                            m_dicts.Add(cat.CatId + " " + cat.CatName + " " + cat.CatParentId);
                        }
                        else
                        {
                            Category cat = new Category();
                            cat.CatId = sArray[0].Split(' ')[0];
                            cat.CatName = sArray[0].Split(' ')[1];
                            cat.CatParentId = sArray[0].Split(' ')[0].Remove(sArray[0].Split(' ')[0].Length - 2);
                            m_dicts.Add(cat.CatId + " " + cat.CatName + " " + cat.CatParentId);
                        }
                    }
                }
                sr.Close();
                fs.Close();
            }
            /***对词典排序后导出到 Abbr_Category.dic***/
            progressBarX1.Value = 50;
            List<string> dictsList = m_dicts.OrderBy(x => x).ToList();
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "字典文件(*.dic)|*.dic|所有文件(*.*)|*.*";
            dlg.AddExtension = true;
            dlg.RestoreDirectory = true;
            dlg.FileName = m_strAbbrCategoryDic;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(dlg.FileName, FileMode.Create);
                StreamWriter sw = new StreamWriter(fs, Encoding.GetEncoding("utf-8"));
                foreach (string word in dictsList)
                {
                    sw.WriteLine(word);
                }
                sw.Close();
                fs.Close();
                progressBarX1.Value = 100;
                MessageBox.Show(m_strAbbrCategoryDic + "数据导出成功！");
            }
            else
            {
                progressBarX1.Value = 100;
            }

            /***对词典排序后导出到 Abbr_Wordlist.dic***/
            dlg.FileName = m_strAbbrWordlistDic;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(dlg.FileName, FileMode.Create);
                StreamWriter sw = new StreamWriter(fs, Encoding.GetEncoding("utf-8"));
                foreach (string word in dictsList)
                {
                    sw.WriteLine(word);
                }
                sw.Close();
                fs.Close();
                progressBarX1.Value = 100;
                MessageBox.Show(m_strAbbrWordlistDic + "数据导出成功！");
            }
            else
            {
                progressBarX1.Value = 100;
            }

        }

        /***生成停词词库***/
        private void buttonX_GenDisableDic_Click(object sender, EventArgs e)
        {
            processData(m_strDisableDic);
        }

        /***生成小商品词库***/
        private void buttonX_ProductDic_Click(object sender, EventArgs e)
        {
            processData(m_strProductDic);
        }

        /***生成品牌词库***/
        private void buttonX_BrandDic_Click(object sender, EventArgs e)
        {
            processData(m_strBrandDic);
        }

        /***生成地址词库***/
        private void buttonX_AddrDic_Click(object sender, EventArgs e)
        {
            processData(m_strAddressDic);
        }

        /***生成店铺词库***/
        private void buttonX_ShopDic_Click(object sender, EventArgs e)
        {
            processData(m_strShopDic);
        }

        private void buttonX_RemoveEqual_Click(object sender, EventArgs e)
        {
            this.processData2("Synonyms.dic");
        }

        private void buttonX_filter1_Click(object sender, EventArgs e)
        {
            this.processData3("Remain.dic");
        }
    }
}