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


namespace uuuu
{
    public partial class 隨機菜單產生器 : Form
    {
        public 隨機菜單產生器()
        {
            InitializeComponent();
        }

        

        

        private void button4_Click(object sender, EventArgs e)
        {
            //住宿區按鈕，按下去後打開住宿區UI，同時關閉其他區域UI
            residence.Enabled = false;
            school.Enabled = true;
            fareat.Enabled = true;
            residencelabel.Visible = true;
            //
            residenceread.Visible = true;
            residencewrite.Visible = true;
            eatresidence.Visible = true;
            residencetextbox1.Visible = true;
            residencetextbox2.Visible = true;
            groupBox1.Visible = true;
            //
            schoolreader.Visible = false;
            schoolwriter.Visible = false;
            eatschool.Visible = false;
            schooltextbox1.Visible = false;
            schooltextbox2.Visible = false;
            schoollabel.Visible = false;
            //
            fareatread.Visible = false;
            fareatwrite.Visible = false;
            eatfareat.Visible = false;
            fareattextbox1.Visible = false;
            fareattextbox2.Visible = false;
            fareatlabel.Visible = false;
            //
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            //住宿區讀取
            
            if (breakfastradio.Checked == true)//早餐
            {
                MessageBox.Show("若經過編輯，記得點選「儲存菜單」");
                StreamReader str01 = new StreamReader(@"住宿區早餐.txt");//txt檔案的路徑與exe同資料夾


                residencetextbox1.Text = "";

                string str1a;

                string[] residencearray = new string[100];
                int i = 0;

                for (i = 0; i < 100; i++)
                {
                    str1a = str01.ReadLine();
                    residencearray[i] = str1a;

                    residencetextbox1.Text = residencetextbox1.Text + residencearray[i] + Environment.NewLine;
                }

                str01.Close();
            }
            else if (LDradio.Checked == true)//早午晚

            {
                MessageBox.Show("若經過編輯，記得點選「儲存菜單」");
                StreamReader str01 = new StreamReader(@"住宿區.txt");//txt檔案的路徑與exe同資料夾


                residencetextbox1.Text = "";

                string str1a;

                string[] residencearray = new string[100];
                int i = 0;

                for (i = 0; i < 100; i++)//讀取資料進陣列
                {
                    str1a = str01.ReadLine();
                    residencearray[i] = str1a;

                    residencetextbox1.Text = residencetextbox1.Text + residencearray[i] + Environment.NewLine;
                }

                str01.Close();
            }
            else
            {
                MessageBox.Show("請先點選「早餐」或是「早午晚」後再按「讀取菜單」");
            }

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //住宿區儲存
            if (residence.Text != "" && residencetextbox1.Text != "請點選「讀取菜單」")//判斷不為空值後再寫入
            {
                if (breakfastradio.Checked == true)//寫入住宿區早餐.txt
                {
                    StreamWriter str02 = new StreamWriter(@"住宿區早餐.txt");
                    string str1b = residencetextbox1.Text;

                    str02.WriteLine(str1b);



                    str02.Close();
                }

                if (LDradio.Checked == true)//寫入住宿區.txt
                {
                    StreamWriter str02 = new StreamWriter(@"住宿區.txt");
                    string str1b = residencetextbox1.Text;

                    str02.WriteLine(str1b);



                    str02.Close();
                }
            }
            else
            {
                MessageBox.Show("請正確填寫後再按「寫入菜單」，不然原先的菜單都會消失哦。");
            }
        }

        private void eatresidence_Click(object sender, EventArgs e)
        {
            //住宿區決定

            do
            {


                if (breakfastradio.Checked == true)//早餐
                {
                    StreamReader str01 = new StreamReader(@"住宿區早餐.txt");

                    string str1a;

                    string[] residencearray = new string[100];//總數
                    int i = 0, b = 1;

                    for (i = 0; i < 100; i++)//總數
                    {
                        str1a = str01.ReadLine();
                        residencearray[i] = str1a;

                    }

                    Random ran01 = new Random();
                    b = ran01.Next(0, 100);//總數
                    residencetextbox2.Text = residencearray[b];

                    str01.Close();


                }

                else if (LDradio.Checked == true)//午晚
                {
                    StreamReader str01 = new StreamReader(@"住宿區.txt");

                    string str1a;

                    string[] residencearray = new string[100];//總數
                    int i = 0, b = 1;

                    for (i = 0; i < 100; i++)//總數
                    {
                        str1a = str01.ReadLine();
                        residencearray[i] = str1a;

                    }

                    Random ran = new Random();
                    b = ran.Next(1, 100);//總數
                    residencetextbox2.Text = residencearray[b];

                    str01.Close();
                }
                else
                {
                    MessageBox.Show("請先點選「早餐」或是「早午晚」後再按「讀取菜單」");
                }


            } while (residencetextbox2.Text == "");//若答案為空白則重新讀取



        }

        private void button5_Click(object sender, EventArgs e)
        {
            //學校區按鈕，按下去後打開學校區UI，同時關閉其他區域UI
            residence.Enabled = true;
            school.Enabled = false;
            fareat.Enabled = true;
            
            //
            residenceread.Visible = false;
            residencewrite.Visible = false;
            eatresidence.Visible = false;
            residencetextbox1.Visible = false;
            residencetextbox2.Visible = false;
            residencelabel.Visible = false;
            groupBox1.Visible = false;
            //
            schoolreader.Visible = true;
            schoolwriter.Visible = true;
            eatschool.Visible = true;
            schooltextbox1.Visible = true;
            schooltextbox2.Visible = true;
            schoollabel.Visible = true;
            //
            fareatread.Visible = false;
            fareatwrite.Visible = false;
            eatfareat.Visible = false;
            fareattextbox1.Visible = false;
            fareattextbox2.Visible = false;
            fareatlabel.Visible = false;
            //
            //利用位移維持UI整潔
            schoolreader.Location = new Point(350, 49);
            schoolwriter.Location = new Point(432,49);
            eatschool.Location = new Point(551,49);
            schooltextbox1.Location = new Point(350,93);
            schooltextbox2.Location = new Point(551,93);
            schoollabel.Location = new Point(435, 18);

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            //學校區讀取
            MessageBox.Show("若經過編輯，記得點選「儲存菜單」");

            StreamReader str01 = new StreamReader(@"學校區.txt");//txt檔案的路徑與exe同資料夾


            schooltextbox1.Text = "";

            string str1a;

            string[] schoolarray = new string[100];//總數
            int i = 0;

            for (i = 0; i < 100; i++)//總數
            {
                str1a = str01.ReadLine();
                schoolarray[i] = str1a;

                schooltextbox1.Text = schooltextbox1.Text + schoolarray[i] + Environment.NewLine;


            }




            str01.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //學校區儲存
            if (schooltextbox1.Text != "" && schooltextbox1.Text != "請點選「讀取菜單」")
            {

                StreamWriter str02 = new StreamWriter(@"學校區.txt");
                string str1b = schooltextbox1.Text;

                str02.WriteLine(str1b);

                str02.Close();
            }

            else
            {
                MessageBox.Show("請正確填寫後再按「寫入菜單」，不然原先的菜單都會消失哦。");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //學校區決定
            StreamReader str01 = new StreamReader(@"學校區.txt");

            string str1a;

            string[] schoolarray = new string[100];//總數
            int i = 0, b = 1;

            for (i = 0; i < 100; i++)//總數存進陣列裡面
            {
                str1a = str01.ReadLine();
                schoolarray[i] = str1a;

            }
            do
            {
                Random ran = new Random();
                b = ran.Next(0, 100);//總數把數字帶入陣列來讀取
                schooltextbox2.Text = schoolarray[b];

                str01.Close();
            } while (schooltextbox2.Text == "");//若答案為空白則重新讀取

        }


        private void fareat_Click(object sender, EventArgs e)
        {
            //遠區按鈕，按下去後打開遠區UI，同時關閉其他區域UI
            residence.Enabled = true;
            school.Enabled = true;
            fareat.Enabled = false;

            //
            residenceread.Visible = false;
            residencewrite.Visible = false;
            eatresidence.Visible = false;
            residencetextbox1.Visible = false;
            residencetextbox2.Visible = false;
            residencelabel.Visible = false;
            groupBox1.Visible = false;
            //
            schoolreader.Visible = false;
            schoolwriter.Visible = false;
            eatschool.Visible = false;
            schooltextbox1.Visible = false;
            schooltextbox2.Visible = false;
            schoollabel.Visible = false;
            //
            fareatread.Visible = true;
            fareatwrite.Visible = true;
            eatfareat.Visible = true;
            fareattextbox1.Visible = true;
            fareattextbox2.Visible = true;
            fareatlabel.Visible = true;
            //
            fareatread.Location = new Point(350, 49);
            fareatwrite.Location = new Point(432, 49);
            eatfareat.Location = new Point(551, 49);
            fareattextbox1.Location = new Point(350, 93);
            fareattextbox2.Location = new Point(551, 93);
            fareatlabel.Location = new Point(435, 18);
        }


        private void fareatread_Click(object sender, EventArgs e)
        {
            //遠區讀取
            MessageBox.Show("若經過編輯，記得點選「儲存菜單」");

            StreamReader str01 = new StreamReader(@"遠區.txt");//txt檔案的路徑與exe同資料夾


            fareattextbox1.Text = "";

            string str1a;

            string[] fareatarray = new string[100];//總數
            int i = 0;

            for (i = 0; i < 100; i++)//總數
            {
                str1a = str01.ReadLine();
                fareatarray[i] = str1a;

                fareattextbox1.Text = fareattextbox1.Text + fareatarray[i] + Environment.NewLine;
            }

            str01.Close();
        }

        private void fareatwrite_Click(object sender, EventArgs e)
        {
            //遠區儲存
            if( fareattextbox1.Text != "" && fareattextbox1.Text != "請點選「讀取菜單」")
            {
                
                    StreamWriter str02 = new StreamWriter(@"遠區.txt");
                    string str1b = fareattextbox1.Text;

                    str02.WriteLine(str1b);

                    str02.Close();
 
            }
            else
            {
                MessageBox.Show("請正確填寫後再按「寫入菜單」，不然原先的菜單都會消失哦。");
            }
        }

        private void eatfareat_Click(object sender, EventArgs e)
        {
            //遠區決定
            
                StreamReader str01 = new StreamReader(@"遠區.txt");

                string str1a;

                string[] fareatarray = new string[100];//總數
                int i = 0, b = 1;

                for (i = 0; i < 100; i++)//總數
                {
                    str1a = str01.ReadLine();
                fareatarray[i] = str1a;

                }
            do
            {
                Random ran = new Random();
                b = ran.Next(0, 100);//總數
                fareattextbox2.Text = fareatarray[b];

                str01.Close();
            } while (fareattextbox2.Text == "");//若答案為空白則重新讀取
        }

        

        

        private void 隨機菜單產生器_Load(object sender, EventArgs e)
        {

        }

        private void breakfastradio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void LDradio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void residencetextbox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void residencetextbox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void schooltextbox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
