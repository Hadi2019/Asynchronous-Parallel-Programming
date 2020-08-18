using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hadi_Alkhashman_Sec004_Ex01
{
    // creating Enum as we need this when we search for a certain item
    public enum PreviousType { Integer, Double, Char }
    public partial class Form1 : Form
    {
        //
        private readonly static int arrayLength = 10;
        private readonly static int[] intArray = new int[arrayLength];
        private readonly static double[] doubleArray = new double[arrayLength];
        private readonly static char[] charArray = new char[arrayLength];

        private PreviousType Previous;
        Random random = new Random();
        public Form1()
        {
            InitializeComponent();
            radioButtonInteger.Checked = true;
            Previous = PreviousType.Integer;
        }

        #region ===============================< Exit Button >=============================
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion

        #region ===============================< Factorial GroupBox >=============================
        // method to calculate Factorial
        private long calculateFactorial(long i)
        {
            // to let the user see "Calculating...Please wait" as it is very short time to display the result
            Thread.Sleep(200);
            if (i == 0)
            {
                return 0;
            }
            else if (i == 1)
            {
                return 1;
            }
            else
            {
                return i * calculateFactorial(i - 1);
            }
        }
        // event handler for Calculate factorial
        private async void buttonCalculateFactorial_Click(object sender, EventArgs e)
        {
            try
            {
                // specifying Red for error message color
                labelFactorialMessage.ForeColor = Color.Red;

                //getting the number entered by the user
                long number = long.Parse(textBoxFactorialInput.Text);
                if (number < 0)
                {
                    textBoxFactorialResult.Text = null;
                    labelFactorialMessage.Text = "Error: Only positive input accepted!";
                }
                else
                {
                    Task<long> task = Task.Run(() => calculateFactorial(number));
                    labelFactorialMessage.ForeColor = Color.Black;
                    labelFactorialMessage.Text = "Calculating...Please wait";
                    await task;
                    labelFactorialMessage.Text = null;
                    textBoxFactorialResult.Text = task.Result.ToString();
                }
            }
            catch (FormatException fe)
            {
                textBoxFactorialResult.Text = null;
                labelFactorialMessage.Text = "Error: No input!";
            }
        }
        #endregion

        #region ===============================< Odd/Even >================================
        private void buttonOddEven_Clicked(object sender, EventArgs e)
        {
            // built-in delegates with lambda to check if it is odd/even
            Func<int, bool> isOdd = (int x) => { return (x % 2) != 0; };
            Func<int, bool> isEven = (int x) => { return (x % 2) == 0; };
            try
            {
                var number = int.Parse(textBoxOddEvenInput.Text);
                if (isOdd.Invoke(number) == true)
                {
                    labelOddEvenError.Text = null;
                    textBoxOddEvenResult.Text = "Odd";
                }
                if (isEven.Invoke(number) == true)
                {
                    labelOddEvenError.Text = null;
                    textBoxOddEvenResult.Text = "Even";
                }
            }
            catch (FormatException)
            {
                textBoxOddEvenResult.Text = null;
                labelOddEvenError.ForeColor = Color.Red;
                labelOddEvenError.Text = "Empry and/or Invalid Type";
            }
        }

        #endregion

        #region ===============================< Generate&Display Arrays >=============================
        private void buttonGenerateValues_Click(object sender, EventArgs e)
        {
            try
            {
                // if radioButtonInteger is checked
                if (radioButtonInteger.Checked)
                {
                    for (int i = 0; i < intArray.Length; i++)
                    {
                        intArray[i] = random.Next(10, 100);
                    }
                    listBox1.DataSource = intArray;
                    Previous = PreviousType.Integer;// we need this when we search for a certain integer
                }
                // if radioButtonDouble is checked
                else if (radioButtonDouble.Checked)
                {
                    for (int i = 0; i < doubleArray.Length; i++)
                    {
                        // generating double values and rounding them to two decimal places
                        doubleArray[i] = Math.Round(random.NextDouble(10.0, 100.0), 2);
                    }
                    listBox1.DataSource = doubleArray;
                    Previous = PreviousType.Double;// we need this when we search for a certain double
                }
                // if radioButtonChar is checked
                else if (radioButtonChar.Checked)
                {
                    for (int i = 0; i < intArray.Length; i++)
                    {
                        int num = random.Next(65, 122);
                        charArray[i] = (char)(num);
                    }
                    listBox1.DataSource = charArray;
                    Previous = PreviousType.Char;// we need this when we search for a certain char
                }
            }
            catch (ArgumentNullException ee)
            {
                Console.WriteLine(ee.ToString());
            }
        }
        #endregion

        #region ===============================< Search for Item >=============================
        //event handler for search button
        private void buttonSearch_Clicked(object sender, EventArgs e)
        {
            try
            {
                labelSearchError.Text = null;
                switch (Previous)
                {
                    case PreviousType.Integer:
                        {
                            int searchItem = Convert.ToInt32(textBoxSearchInput.Text);
                            var result = SearchData(intArray, searchItem);
                            displaySearchResult(result);
                            break;
                        }
                    case PreviousType.Char:
                        {
                            char searchItem = Convert.ToChar(textBoxSearchInput.Text);
                            var result = SearchData(charArray, searchItem);
                            displaySearchResult(result);
                            break;
                        }
                    
                    case PreviousType.Double:
                        {
                            double searchItem = Convert.ToDouble(textBoxSearchInput.Text);
                            var result = SearchData(doubleArray, searchItem);
                            displaySearchResult(result);
                            break;
                        }
                }
            }
            catch (FormatException)
            {
                labelSearchError.ForeColor = Color.Red;
                labelSearchError.Text = "Invalid search input!";
            }
        }
        private bool SearchData<T>(T[] array, T item) where T : IComparable
        {
            bool isFound = false;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].CompareTo(item) == 0)
                {
                    isFound = true;
                }
            }
            return isFound;
        }
        private void displaySearchResult(bool result)
        {
            if (result == true)
            {
                MessageBox.Show("The item is found");
            }
            else
            {
                MessageBox.Show("The item is not found");
            }
        }
        #endregion

        #region ===============================< Display Low/High Sub-Group >=============================
        // generic method for printing array between low and high index
        private void PrintData<T>(T[] generatedArray, int lowIndex, int highIndex)
        {
            try
            {
                labelDisplayError.ForeColor = Color.Red;
                labelDisplayError.Text = null;
                textBoxLowHighResult.Text = null;
                if (lowIndex < 0 || highIndex < 0)
                {
                    labelDisplayError.Text = "Both indices can't be less than zero!";
                }
                else if (lowIndex >= highIndex)
                {
                    labelDisplayError.Text = "\"Low Index\" cannot be greater than or equal to \"High Index\"";
                }
                else if (lowIndex >= generatedArray.Length-1)
                {
                    labelDisplayError.Text = $"\"Low Index\"  is {generatedArray.Length-2} at maximum!";
                }
                else if (highIndex >= generatedArray.Length)
                {
                    labelDisplayError.Text = $"\"High Index\" is {generatedArray.Length-1} at maximum!";
                }
                else
                {
                    for (int i = lowIndex; i <= highIndex; i++)
                    {
                        textBoxLowHighResult.Text += generatedArray[i].ToString() + "  ";
                    }
                }
            }
            catch (ArgumentException e)
            {
                labelDisplayError.Text = null;

                labelDisplayError.Text = e.Message;
            }
        }
        // event handler for low and high index display button
        private void ButtonLowHighDisplay(object sender, EventArgs e)
        {
            try
            {
                if (textBoxLowIndexInput.Text == "" || textBoxHighIndexInput.Text == "")
                {
                    labelDisplayError.ForeColor = Color.Red;
                    labelDisplayError.Text = "Indices can't be empty!";
                    textBoxLowHighResult.Text = null;
                }
                else
                {
                    int lowInt = int.Parse(textBoxLowIndexInput.Text);
                    int highInt = int.Parse(textBoxHighIndexInput.Text);
                    if (radioButtonChar.Checked)
                    {
                        PrintData(charArray, lowInt, highInt);
                    }
                    if (radioButtonInteger.Checked)
                    {
                        PrintData(intArray, lowInt, highInt);
                    }
                    if (radioButtonDouble.Checked)
                    {
                        PrintData(doubleArray, lowInt, highInt);
                    }
                }
            }
            catch (FormatException)
            {
                textBoxLowHighResult.Text = null;
                labelDisplayError.ForeColor = Color.Red;
                labelDisplayError.Text = "Invalid value type for indices!";
            }
        }
        // method to print search result
        #endregion
    } // end Form1.cs


    #region Random Class - Extension method
    public static class RandomGenerator
    {
        public static double NextDouble(this Random random, double minValue, double maxValue)
        {
            return random.NextDouble() * (maxValue - minValue) + minValue / 2;
        }
    }
    #endregion
}
