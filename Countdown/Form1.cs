using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Countdown
{
    public partial class Form1 : Form
    {
        //letters
        string[] VowelList;
        string[] ConstanantList;
        int VowelIndex;
        int ConstanantIndex;

        //numbers
        int[] largeNumsList;
        int[] smallNumsList;
        int numDisplayIndex;

        public Form1()
        {
            VowelList = new string[] {"A", "A", "A", "A", "A", "A", "A", "A", "A", "A", "A", "A", "A", "A", "A", 
                                            "E", "E", "E", "E", "E", "E", "E", "E", "E", "E", "E", "E", "E", "E", "E", "E", "E", "E", "E", "E", "E", 
                                            "I", "I", "I", "I", "I", "I", "I", "I", "I", "I", "I", "I", "I", 
                                            "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", 
                                            "U", "U", "U", "U", "U"};
            ConstanantList = new string[] {"B", "B",
                                                 "C", "C", "C",
                                                 "D", "D", "D", "D", "D", "D", 
                                                 "F", "F",
                                                 "G", "G", "G",
                                                 "H", "H", 
                                                 "J", 
                                                 "K",
                                                 "L", "L", "L", "L", "L", 
                                                 "M", "M", "M", "M", 
                                                 "N", "N", "N", "N", "N", "N", "N", "N", 
                                                 "P", "P", "P", "P", 
                                                 "Q", 
                                                 "R", "R", "R", "R", "R", "R", "R", "R", "R", 
                                                 "S", "S", "S", "S", "S", "S", "S", "S", "S", 
                                                 "T", "T", "T", "T", "T", "T", "T", "T", "T", 
                                                 "V",
                                                 "W",
                                                 "X",
                                                 "Y",
                                                 "Z"};


            VowelIndex = 0;
            ConstanantIndex = 0;

            ShuffleLists();

            largeNumsList = new int[] { 25, 50, 75, 100 };
            smallNumsList = new int[] { 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6, 7, 7, 8, 8, 9, 9, 10, 10 };

            ShuffleNumbers();
            numDisplayIndex = 0;

            InitializeComponent();
        }

        private void vowelBut_Click(object sender, EventArgs e)
        {
            if (letterDisplay.Text.Length<9)
            {
                letterDisplay.Text += VowelList[VowelIndex++];
            }
        }

        private void constanantBut_Click(object sender, EventArgs e)
        {
            if (letterDisplay.Text.Length < 9)
            {
                letterDisplay.Text += ConstanantList[ConstanantIndex++];
            }
        }

        private void letresetBut_Click(object sender, EventArgs e)
        {
            letterDisplay.Clear();
            VowelIndex = 0;
            ConstanantIndex = 0;
            ShuffleLists();
        }

        private void ShuffleLists()
        {
            string[] tempVowel = new string[VowelList.Length];
            string[] tempConstant = new string[ConstanantList.Length];
            for (int idx=0; idx<VowelList.Length; idx++)
            {
                tempVowel[idx] = VowelList[idx];
            }
            for (int idx=0; idx<ConstanantList.Length; idx++)
            {
                tempConstant[idx] = ConstanantList[idx];
            }

            Random rnd = new Random();
            VowelList = tempVowel.OrderBy(x => rnd.Next()).ToArray();
            ConstanantList = tempConstant.OrderBy(x => rnd.Next()).ToArray();
        }

        private void ShuffleNumbers()
        {
            int[] tempBig = new int[largeNumsList.Length];
            int[] tempSmall = new int[smallNumsList.Length];
            for (int idx=0; idx<largeNumsList.Length; idx++)
            {
                tempBig[idx] = largeNumsList[idx];
            }
            for (int idx=0; idx<smallNumsList.Length; idx++)
            {
                tempSmall[idx] = smallNumsList[idx];
            }

            Random rnd = new Random();
            largeNumsList = tempBig.OrderBy(x => rnd.Next()).ToArray();
            smallNumsList = tempSmall.OrderBy(x => rnd.Next()).ToArray();
        }



        private void bigbut1_Click(object sender, EventArgs e)
        {
            bigbut1.Visible = false;
            AddNumber(largeNumsList[0]);
        }

        private void bigbut2_Click(object sender, EventArgs e)
        {
            bigbut2.Visible = false;
            AddNumber(largeNumsList[1]);
        }

        private void bigbut3_Click(object sender, EventArgs e)
        {
            bigbut3.Visible = false;
            AddNumber(largeNumsList[2]);
        }

        private void bigbut4_Click(object sender, EventArgs e)
        {
            bigbut4.Visible = false;
            AddNumber(largeNumsList[3]);
        }

        private void AddNumber(int num)
        {
            switch(numDisplayIndex)
            {
                case 0:
                    num1.Text = num.ToString();
                    numDisplayIndex++;
                    break;
                case 1:
                    num2.Text = num.ToString();
                    numDisplayIndex++;
                    break;
                case 2:
                    num3.Text = num.ToString();
                    numDisplayIndex++;
                    break;
                case 3:
                    num4.Text = num.ToString();
                    numDisplayIndex++;
                    break;
                case 4:
                    num5.Text = num.ToString();
                    numDisplayIndex++;
                    break;
                case 5:
                    num6.Text = num.ToString();
                    numDisplayIndex++;
                    break;
            }
        }

        private void smallbut1_Click(object sender, EventArgs e)
        {
            smallbut1.Visible = false;
            AddNumber(smallNumsList[0]);
        }

        private void smallbut2_Click(object sender, EventArgs e)
        {
            smallbut2.Visible = false;
            AddNumber(smallNumsList[1]);
        }

        private void smallbut3_Click(object sender, EventArgs e)
        {
            smallbut3.Visible = false;
            AddNumber(smallNumsList[2]);
        }

        private void smallbut4_Click(object sender, EventArgs e)
        {
            smallbut4.Visible = false;
            AddNumber(smallNumsList[3]);
        }

        private void smallbut5_Click(object sender, EventArgs e)
        {
            smallbut5.Visible = false;
            AddNumber(smallNumsList[4]);
        }

        private void smallbut6_Click(object sender, EventArgs e)
        {
            smallbut6.Visible = false;
            AddNumber(smallNumsList[5]);
        }

        private void smallbut7_Click(object sender, EventArgs e)
        {
            smallbut7.Visible = false;
            AddNumber(smallNumsList[6]);
        }

        private void smallbut8_Click(object sender, EventArgs e)
        {
            smallbut8.Visible = false;
            AddNumber(smallNumsList[7]);
        }

        private void smallbut9_Click(object sender, EventArgs e)
        {
            smallbut9.Visible = false;
            AddNumber(smallNumsList[8]);
        }

        private void smallbut10_Click(object sender, EventArgs e)
        {
            smallbut10.Visible = false;
            AddNumber(smallNumsList[9]);
        }

        private void smallbut11_Click(object sender, EventArgs e)
        {
            smallbut11.Visible = false;
            AddNumber(smallNumsList[10]);
        }

        private void smallbut12_Click(object sender, EventArgs e)
        {
            smallbut12.Visible = false;
            AddNumber(smallNumsList[11]);
        }

        private void resetNums_Click_1(object sender, EventArgs e)
        {
            numDisplayIndex = 0;
            ShuffleNumbers();
            num2.Clear();
            num1.Clear();
            num5.Clear();
            num3.Clear();
            num4.Clear();
            num6.Clear();
            targetNum.Clear();
            //reset buttons
            bigbut1.Visible = true;
            bigbut2.Visible = true;
            bigbut3.Visible = true;
            bigbut4.Visible = true;
            smallbut1.Visible = true;
            smallbut2.Visible = true;
            smallbut3.Visible = true;
            smallbut4.Visible = true;
            smallbut5.Visible = true;
            smallbut6.Visible = true;
            smallbut7.Visible = true;
            smallbut8.Visible = true;
            smallbut9.Visible = true;
            smallbut10.Visible = true;
            smallbut11.Visible = true;
            smallbut12.Visible = true;
        }

        private void genRand_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            for (int suspenseIndex = 0 ; suspenseIndex<10; suspenseIndex++)
            {
                int randNum = rnd.Next(100, 999);
                targetNum.Text = randNum.ToString();
                targetNum.Refresh();
                System.Threading.Thread.Sleep(50);
            }
            
        }
        
    }
}
