namespace Lab5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /* Name: Dehinbo Abdulwahab
         * Date: November 2025
         * This program rolls one dice or calculates mark stats.
         * Link to your repo in GitHub: 
         * */

        //class-level random object
        Random rand = new Random();

        private void Form1_Load(object sender, EventArgs e)
        {
            //select one roll radiobutton
            radOneRoll.Checked = true;
            //add your name to end of form title
            this.Text += " - Dehinbo Abdulwahab";
        } // end form load

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearOneRoll();

            //call the function
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearStats();
            //call the function

        }

        private void btnRollDice_Click(object sender, EventArgs e)
        {
            int dice1, dice2;
            //call ftn RollDice, placing returned number into integers
            dice1 = RollDice();
            dice2 = RollDice();

            //place integers into labels
            lblDice1.Text = dice1.ToString();
            lblDice2.Text = dice2.ToString();

            // call ftn GetName sending total and returning name
            string rollName = GetName(dice1 + dice2);

            //display name in label
            lblRollName.Text = rollName;

        }


        /* Name: ClearOneRoll
        *  Sent: nothing
        *  Return: nothing
        *  Clear the labels */
        private void ClearOneRoll()
        {
            lblDice1.Text = "";
            lblDice2.Text = "";
            lblRollName.Text = "";
        }


        /* Name: ClearStats
        *  Sent: nothing
        *  Return: nothing
        *  Reset nud to minimum value, chkbox unselected, 
        *  clear labels and listbox */

        private void ClearStats()
        {
            nudNumber.Value = nudNumber.Minimum;
            chkSeed.Checked = false;

            lblAverage.Text = "";
            lblPass.Text = "";
            lblFail.Text = "";

            lstMarks.Items.Clear();
        }



        /* Name: RollDice
        * Sent: nothing
        * Return: integer (1-6)
        * Simulates rolling one dice */

        private int RollDice()
        {
            return rand.Next(1, 7);
        }


        /* Name: GetName
        * Sent: 1 integer (total of dice1 and dice2) 
        * Return: string (name associated with total) 
        * Finds the name of dice roll based on total.
        * Use a switch statement with one return only
        * Names: 2 = Snake Eyes
        *        3 = Litle Joe
        *        5 = Fever
        *        7 = Most Common
        *        9 = Center Field
        *        11 = Yo-leven
        *        12 = Boxcars
        * Anything else = No special name*/

        private string GetName(int total)
        {
            string name = "";

            switch (total)
            {
                case 2: name = "Snake Eyes"; break;
                case 3: name = "Little Joe"; break;
                case 5: name = "Fever"; break;
                case 7: name = "Most Common"; break;
                case 9: name = "Center Field"; break;
                case 11: name = "Yo-leven"; break;
                case 12: name = "Boxcars"; break;
                default: name = "No special name"; break;
            }

            return name;
        }
        ///

        private void btnSwapNumbers_Click(object sender, EventArgs e)
        {
            //call ftn DataPresent twice sending string returning boolean

            bool isFirstPresent = DataPresent(lblDice1.Text);
            bool isSecondPresent = DataPresent(lblDice2.Text);

            //if data present in both labels, call SwapData sending both strings

            if (isFirstPresent && isSecondPresent)
            {
                string s1 = lblDice1.Text;
                string s2 = lblDice2.Text;

                // Swap the values
                SwapData(ref s1, ref s2);

                //put data back into labels
                lblDice1.Text = s1;
                lblDice2.Text = s2;
            }
            else
            {
                //if data not present in either label display error msg
                MessageBox.Show("Error: One or both labels are empty.");
            }

        }

        /* Name: DataPresent
        * Sent: string
        * Return: bool (true if data, false if not) 
        * See if string is empty or not*/
        private bool DataPresent(string s)
        {
            return !string.IsNullOrWhiteSpace(s);
        }


        /* Name: SwapData
        * Sent: 2 strings
        * Return: none 
        * Swaps the memory locations of two strings*/

        private void SwapData(ref string s1, ref string s2)
        {
            string temp = s1;
            s1 = s2;
            s2 = temp;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            //declare variables and array
            int[] marks = new int[10];   // Example: array of 10 marks
            double average;
            int passCount = 0, failCount = 0;
            Random rand;


            //check if seed value
            if (chkSeed.Checked)
            {
                rand = new Random(1000); // fixed seed
            }
            else
            {
                rand = new Random();    // random seed
            }

            //clear listbox first
            lstMarks.Items.Clear();

            //fill array using random number

            for (int i = 0; i < marks.Length; i++)
            {
                marks[i] = rand.Next(40, 101); // 40 to 100 inclusive
                lstMarks.Items.Add(marks[i]); // add number to listbox
            }


            //call CalcStats sending and returning data
            average = CalcStats(marks, ref passCount, ref failCount);

            //display data sent back in labels - average, pass and fail
            // Format average always showing 2 decimal places 
            lblAverage.Text = average.ToString("F2");
            lblPass.Text = passCount.ToString();
            lblFail.Text = failCount.ToString();
        }
        // end Generate click

        private void radOneRoll_CheckedChanged_1(object sender, EventArgs e)
        {
            switch (radOneRoll.Checked)
            {
                case true:
                    grpOneRoll.Show();
                    grpMarkStats.Hide();
                    ClearOneRoll();
                    break;

                case false:
                    grpOneRoll.Hide();
                    grpMarkStats.Show();
                    ClearStats();
                    break;
            }

        }
        private double CalcStats(int[] marks, ref int passCount, ref int failCount)
        {
            double total = 0;

            foreach (int m in marks)
            {
                total += m;

                if (m >= 60)X
                    passCount++;
                else
                    failCount++;
            }

            return total / marks.Length; // return average
        }
        /* Name: CalcStats
       * Sent: array and 2 integers
       * Return: average (double) 
       * Run a foreach loop through the array.
       * Passmark is 60%
       * Calculate average and count how many marks pass and fail
       * The pass and fail values must also get returned for display*/
        private void chkSeed_CheckedChanged(object sender, EventArgs e)
        {
            switch (chkSeed.Checked)
            {
                case true:
                    DialogResult result = MessageBox.Show(
                        "Are you sure you want to set a seed value?",
                        "Confirm seed value",
                        MessageBoxButtons.YesNo
                    );
 
                    switch (result)
                    {
                        case DialogResult.Yes:
                            // Set random with fixed seed
                            rand = new Random(100);
                            break;
                        case DialogResult.No:
                            chkSeed.Checked = false;
                            break;
                    }
                    break;
 
                case false:
                    // Optional: Do something if unchecked
                    break;
            }
        }


       
    }
}

