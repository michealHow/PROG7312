using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace LibraryAppTask1_17597280
{
    /// <summary>
    /// Interaction logic for ReplaceBooks.xaml
    /// </summary>
    public partial class ReplaceBooks : Window
    {
        RandomCalNum rc = new RandomCalNum();
        string callnumber1, callnumber2, callnumber3, callnumber4, callnumber5, callnumber6, callnumber7, callnumber8, callnumber9, callnumber10;        
        string[] cn = new string[10];
        string[] cnOrdered = new string[10];
        string[] cnAnswers = new string[10];


        //for players score
        public static int XpNumCurrent , XpNumNew = 0;

        private void btnBack(object sender, RoutedEventArgs e)
        {

            
            //for replace books
            MainWindow mw = new MainWindow();            
            mw.Show();
            this.Close();
        }

        //for Levels
        int XpNumLvl01 = 100, XpNumLvl02 = 500, XpNumLvl03 = 1000, XpNumLvl04 = 1500, 
            XpNumLvl05 = 2000, XpNumLvl06 = 2500, XpNumLvl07 = 3000, 
            XpNumLvl08 = 3500, XpNumLvl09 = 4000, XpNumLvl10 = 4500;


       
        private void DoneSorting(object sender, RoutedEventArgs e)
        {
           GetSelectedvaluesfromCombobox(cb1, cb2, cb3, cb4, cb5, cb1_Copy, cb2_Copy, cb3_Copy, cb4_Copy, cb5_Copy);

            //for replace books
            ReplaceBooks rb1 = new ReplaceBooks();
            rb1.Show();
            this.Close();

        }

        int sleep = 20;
       

        public ReplaceBooks()
        {
            InitializeComponent();
        }
        

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            XpNumCurrent = MainWindow.CurrentScore;
            ReadScore();
            createList();
            AddItemsToCB();
            SetXpForPlayer(XpNumCurrent, XpNumNew);

        }
        private void SetXpForPlayer( int Score, int NewScore) {

            Score = Score + NewScore;//adding up score for user
           
            if (Score  > 0 && Score <= XpNumLvl01) {

                //Setting Player Score and  Max Value and Value of for Progress bar if case is met
                SetingProgressBarANdLabel(Score, 0, XpNumLvl01, 1);
            } 
            else if (Score > XpNumLvl01 && Score <= XpNumLvl02)
            {
                //Setting Player Score and  Max Value and Value of for Progress bar if case is met
                SetingProgressBarANdLabel(Score, XpNumLvl01, XpNumLvl02, 2);
            }
            else if (Score > XpNumLvl02 && Score <= XpNumLvl03)
            {
                //Setting Player Score and  Max Value and Value of for Progress bar if case is met
                SetingProgressBarANdLabel(Score, XpNumLvl02, XpNumLvl03, 3);
            }
            else if (Score > XpNumLvl03 && Score <= XpNumLvl04)
            {
                //Setting Player Score and  Max Value and Value of for Progress bar if case is met
                SetingProgressBarANdLabel(Score, XpNumLvl03, XpNumLvl04, 4);
            }
            else if (Score > XpNumLvl04 && Score <= XpNumLvl05)
            {
                //Setting Player Score and  Max Value and Value of for Progress bar if case is met
                SetingProgressBarANdLabel(Score, XpNumLvl04, XpNumLvl05, 5);
            }
            else if (Score > XpNumLvl05 && Score <= XpNumLvl06)
            {
                //Setting Player Score and  Max Value and Value of for Progress bar if case is met
                SetingProgressBarANdLabel(Score, XpNumLvl05, XpNumLvl06, 6);
            }
            else if (Score > XpNumLvl06 && Score <= XpNumLvl07)
            {
                //Setting Player Score and  Max Value and Value of for Progress bar if case is met
                SetingProgressBarANdLabel(Score, XpNumLvl06, XpNumLvl07, 7);
            }
            else if (Score > XpNumLvl07 && Score <= XpNumLvl08)
            {
                //Setting Player Score and  Max Value and Value of for Progress bar if case is met
                SetingProgressBarANdLabel(Score, XpNumLvl07, XpNumLvl08, 8);
            }
            else if (Score > XpNumLvl08 && Score <= XpNumLvl09)
            {
                //Setting Player Score and  Max Value and Value of for Progress bar if case is met
                SetingProgressBarANdLabel(Score, XpNumLvl08, XpNumLvl09, 9);
            }
            else if (Score > XpNumLvl09 && Score <= XpNumLvl10)
            {
                //Setting Player Score and  Max Value and Value of for Progress bar if case is met
                SetingProgressBarANdLabel(Score, XpNumLvl09, XpNumLvl10, 10);

            }



        }
        private void SetingProgressBarANdLabel(int Score, int Min ,int Max, int Level) {

            Xpnum.Content = "Points: " + Score.ToString() + " of " + Max + " Level: " + Level;//setting label
            progressbarforXp.Maximum = Max;//setting Bar max
            progressbarforXp.Minimum = Min;//setting Bar Min
            progressbarforXp.Value = Score;//setting Bar Value

        }
        private void createList()
        {
            int i = 0;
            while (i < 10)
            {
                switch (i)
                {
                    case 0:
                        RandomCalNum rc = new RandomCalNum();
                        callnumber1 = rc.GenerateNumbes();
                        cn[i] = callnumber1;
                        Thread.Sleep(sleep);
                        break;
                    case 1:
                        RandomCalNum rc1 = new RandomCalNum();
                        callnumber2 = rc1.GenerateNumbes();
                        cn[i] = callnumber2;
                        Thread.Sleep(sleep);
                        break;
                    case 2:
                        RandomCalNum rc2 = new RandomCalNum();
                        callnumber3 = rc2.GenerateNumbes();
                        cn[i] = callnumber3;
                        Thread.Sleep(sleep);
                        break;
                    case 3:
                        RandomCalNum rc3 = new RandomCalNum();
                        callnumber4 = rc3.GenerateNumbes();
                        cn[i] = callnumber4;
                        Thread.Sleep(sleep);
                        break;
                    case 4:
                        RandomCalNum rc5 = new RandomCalNum();
                        callnumber5 = rc5.GenerateNumbes();
                        cn[i] = callnumber5;
                        Thread.Sleep(sleep);
                        break;
                    case 5:
                        RandomCalNum rc6 = new RandomCalNum();
                        callnumber6 = rc6.GenerateNumbes();
                        cn[i] = callnumber6;
                        Thread.Sleep(sleep);
                        break;
                    case 6:
                        RandomCalNum rc7 = new RandomCalNum();
                        callnumber7 = rc7.GenerateNumbes();
                        cn[i] = callnumber7;
                        Thread.Sleep(sleep);
                        break;
                    case 7:
                        RandomCalNum rc8 = new RandomCalNum();
                        callnumber8 = rc8.GenerateNumbes();
                        cn[i] = callnumber8;
                        Thread.Sleep(sleep);
                        break;
                    case 8:
                        RandomCalNum rc9 = new RandomCalNum();
                        callnumber9 = rc9.GenerateNumbes();
                        cn[i] = callnumber9;
                        Thread.Sleep(sleep);
                        break;
                    case 9:
                        RandomCalNum rc10 = new RandomCalNum();
                        callnumber10 = rc10.GenerateNumbes();
                        cn[i] = callnumber10;
                        Thread.Sleep(sleep);
                        break;
                }
                i++;
            }
            CallNum1.Content = callnumber1;
            CallNum2.Content = callnumber2;
            CallNum3.Content = callnumber3;
            CallNum4.Content = callnumber4;
            CallNum5.Content = callnumber5;
            CallNum1_Copy.Content = callnumber6;
            CallNum2_Copy.Content = callnumber7;
            CallNum3_Copy.Content = callnumber8;
            CallNum4_Copy.Content = callnumber9;
            CallNum5_Copy.Content = callnumber10;
        }
        private void GetSelectedvaluesfromCombobox (ComboBox cb1, ComboBox cb2, ComboBox cb3, ComboBox cb4, ComboBox cb5, ComboBox cb6, ComboBox cb7, ComboBox cb8, ComboBox cb9, ComboBox cb10) {
            //check if muiltiple of the same has been selected
            cnAnswers = new string[10];
            //dont delete this _______
            for (int i = 0; i < 10; i++)
            {
                cnOrdered[i] = cn[i];
            }
            // cnOrdered= cn;

            Array.Sort(cnOrdered, new AlphanumComparatorFast());

            //foreach (string item in cnOrdered)
            //{
            //    MessageBox.Show(item);
            //}
            //dont delete this _______
            if (cb1 != null && cb2 != null
                && cb3 != null && cb4 != null
                && cb5 != null && cb6 != null
                && cb7 != null && cb8 != null
                && cb9 != null && cb10 != null)
            {
                // Fill the list
                List<int> selectedvalues = new List<int>(10);
                selectedvalues.Add(Convert.ToInt32(cb1.SelectedItem));
                selectedvalues.Add(Convert.ToInt32(cb2.SelectedItem));
                selectedvalues.Add(Convert.ToInt32(cb3.SelectedItem));
                selectedvalues.Add(Convert.ToInt32(cb4.SelectedItem));
                selectedvalues.Add(Convert.ToInt32(cb5.SelectedItem));
                selectedvalues.Add(Convert.ToInt32(cb6.SelectedItem));
                selectedvalues.Add(Convert.ToInt32(cb7.SelectedItem));
                selectedvalues.Add(Convert.ToInt32(cb8.SelectedItem));
                selectedvalues.Add(Convert.ToInt32(cb9.SelectedItem));
                selectedvalues.Add(Convert.ToInt32(cb10.SelectedItem));

                //string p = " ";
                //foreach (int s in selectedvalues) {
                //    p += p +" "+s+" "; 
                //}
                //MessageBox.Show(p);


                if (selectedvalues.Count != selectedvalues.Distinct().Count())
                {
                    // Duplicates exist
                    MessageBox.Show("Please Make Sure You dont Select Multiple Of the Same Values in the Order call Number Collom");
                }
                else
                {

                    for (int i = 0; i<10; i ++) {//swapping values 
                        int INdexvalueofAnswer = selectedvalues[i]-1;
                        cnAnswers[INdexvalueofAnswer] = cn[i];
                    }
                }

                MessageBox.Show("CN\t " + "no.\t" + "CNorder\t" + "Cn Answers\n"
                              + cn[0] + "\t" + " " + 1 + cnAnswers[0] + "\t" + cnOrdered[0] + "\t" + selectedvalues[0] + "\n"
                              + cn[1] + "\t" + " " + 2 + cnAnswers[1] + "\t" + cnOrdered[1] + "\t" + selectedvalues[1] + "\n"
                              + cn[2] + "\t" + " " + 3 + cnAnswers[2] + "\t" + cnOrdered[2] + "\t" + selectedvalues[2] + "\n"
                              + cn[3] + "\t" + " " + 4 + cnAnswers[3] + "\t" + cnOrdered[3] + "\t" + selectedvalues[3] + "\n"
                              + cn[4] + "\t" + " " + 5 + cnAnswers[4] + "\t" + cnOrdered[4] + "\t" + selectedvalues[4] + "\n"
                              + cn[5] + "\t" + " " + 6 + cnAnswers[5] + "\t" + cnOrdered[5] + "\t" + selectedvalues[5] + "\n"
                              + cn[6] + "\t" + " " + 7 + cnAnswers[6] + "\t" + cnOrdered[6] + "\t" + selectedvalues[6] + "\n"
                              + cn[7] + "\t" + " " + 8 + cnAnswers[7] + "\t" + cnOrdered[7] + "\t" + selectedvalues[7] + "\n"
                              + cn[8] + "\t" + " " + 9 + cnAnswers[8] + "\t" + cnOrdered[8] + "\t" + selectedvalues[8] + "\n"
                              + cn[9] + "\t" + " " + 10 + cnAnswers[9] + "\t" + cnOrdered[9] + "\t" + selectedvalues[9] + "\n"
                              );
                int result = 100;
                for (int q = 0; q<10;q++) {
                    if (cnAnswers[q] != cnOrdered[q]) {
                       result = result - 10;                    
                    }
                    

                }
                SetXpForPlayer(XpNumCurrent, result);
               

                
            }
            else
            {
                MessageBox.Show("Please Make Sure You dont Select an Answer for all");

            }

        
        }
        private void AddItemsToCB()
        {//adding items to combobox
            cb1.Items.Add(1);
            cb1.Items.Add(2);
            cb1.Items.Add(3);
            cb1.Items.Add(4);
            cb1.Items.Add(5);
            cb1.Items.Add(6);
            cb1.Items.Add(7);
            cb1.Items.Add(8);
            cb1.Items.Add(9);
            cb1.Items.Add(10);

            cb2.Items.Add(1);
            cb2.Items.Add(2);
            cb2.Items.Add(3);
            cb2.Items.Add(4);
            cb2.Items.Add(5);
            cb2.Items.Add(6);
            cb2.Items.Add(7);
            cb2.Items.Add(8);
            cb2.Items.Add(9);
            cb2.Items.Add(10);

            cb3.Items.Add(1);
            cb3.Items.Add(2);
            cb3.Items.Add(3);
            cb3.Items.Add(4);
            cb3.Items.Add(5);
            cb3.Items.Add(6);
            cb3.Items.Add(7);
            cb3.Items.Add(8);
            cb3.Items.Add(9);
            cb3.Items.Add(10);

            cb4.Items.Add(1);
            cb4.Items.Add(2);
            cb4.Items.Add(3);
            cb4.Items.Add(4);
            cb4.Items.Add(5);
            cb4.Items.Add(6);
            cb4.Items.Add(7);
            cb4.Items.Add(8);
            cb4.Items.Add(9);
            cb4.Items.Add(10);

            cb5.Items.Add(1);
            cb5.Items.Add(2);
            cb5.Items.Add(3);
            cb5.Items.Add(4);
            cb5.Items.Add(5);
            cb5.Items.Add(6);
            cb5.Items.Add(7);
            cb5.Items.Add(8);
            cb5.Items.Add(9);
            cb5.Items.Add(10);

            cb1_Copy.Items.Add(1);
            cb1_Copy.Items.Add(2);
            cb1_Copy.Items.Add(3);
            cb1_Copy.Items.Add(4);
            cb1_Copy.Items.Add(5);
            cb1_Copy.Items.Add(6);
            cb1_Copy.Items.Add(7);
            cb1_Copy.Items.Add(8);
            cb1_Copy.Items.Add(9);
            cb1_Copy.Items.Add(10);

            cb2_Copy.Items.Add(1);
            cb2_Copy.Items.Add(2);
            cb2_Copy.Items.Add(3);
            cb2_Copy.Items.Add(4);
            cb2_Copy.Items.Add(5);
            cb2_Copy.Items.Add(6);
            cb2_Copy.Items.Add(7);
            cb2_Copy.Items.Add(8);
            cb2_Copy.Items.Add(9);
            cb2_Copy.Items.Add(10);

            cb3_Copy.Items.Add(1);
            cb3_Copy.Items.Add(2);
            cb3_Copy.Items.Add(3);
            cb3_Copy.Items.Add(4);
            cb3_Copy.Items.Add(5);
            cb3_Copy.Items.Add(6);
            cb3_Copy.Items.Add(7);
            cb3_Copy.Items.Add(8);
            cb3_Copy.Items.Add(9);
            cb3_Copy.Items.Add(10);

            cb4_Copy.Items.Add(1);
            cb4_Copy.Items.Add(2);
            cb4_Copy.Items.Add(3);
            cb4_Copy.Items.Add(4);
            cb4_Copy.Items.Add(5);
            cb4_Copy.Items.Add(6);
            cb4_Copy.Items.Add(7);
            cb4_Copy.Items.Add(8);
            cb4_Copy.Items.Add(9);
            cb4_Copy.Items.Add(10);

            cb5_Copy.Items.Add(1);
            cb5_Copy.Items.Add(2);
            cb5_Copy.Items.Add(3);
            cb5_Copy.Items.Add(4);
            cb5_Copy.Items.Add(5);
            cb5_Copy.Items.Add(6);
            cb5_Copy.Items.Add(7);
            cb5_Copy.Items.Add(8);
            cb5_Copy.Items.Add(9);
            cb5_Copy.Items.Add(10);




        }

        private void ReadScore() {

            //string text = System.IO.File.ReadAllText("/TextFileScore/Score.txt");

           
           

            String line;
            try
            {
                //Pass the file path and file name to the StreamReader constructor
                StreamReader sr = new StreamReader(@"\LibraryAppTask1_17597280\LibraryAppTask1_17597280\TextFileScore\Score.txt");
                //Read the first line of text
                line = sr.ReadLine();
                //Continue to read until you reach end of file
                while (line != null)
                {
                    //write the lie to console window
                    MessageBox.Show(line);
                    //Read the next line
                    line = sr.ReadLine();
                }
                //close the file
                sr.Close();
                
            }
            catch (Exception e)
            {
                MessageBox.Show("Exception: " + e.Message);
            }
            finally
            {
                MessageBox.Show("Executing finally block.");
            }

            

           
        }
    }

}



//dont delete this _______
//for (int i = 0; i < 10; i++)
//{
//    cnOrdered[i] = cn[i];
//}
//// cnOrdered= cn;

//Array.Sort(cnOrdered, new AlphanumComparatorFast());

//foreach (string item in cnOrdered)
//{
//    MessageBox.Show(item);
//}
//dont delete this _______