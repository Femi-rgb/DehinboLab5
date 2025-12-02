namespace Formula;
/* Add to program:
 * 1. Class-level constant for years (10)
 * 2. Form Load: 
 *      a) place class-level constant in years label on form
 *      b) hide picturebox
 *      c) blank out textboxes and interest rate
 *      d) put cursor on top textbox
 * 3. Reset Click: copy code from Form Load except for putting constant in label
 * 4. Create function: ResetForm, move code and call
 * 5. Calculate: 
 *      a) show the picturebox - after declarations
 *      b) add the formula (as seen in picturebox) below 
 *      c) format output as percent
 *      d) exception handling: add try catch block around all code in event
 * 6. Change backcolor of groupbox, add Form Properties: Cancel and Accept buttons 
 * 7. Add check that present value is less than future value. (within try block)
 *   Explained--> After reading in data and placing in variables:
 *   Add if that tests the present value is less than future value
 *   If it is, show the picture box, calculate answer and display. Need braces.
 *   If it isn't, display an error message: (No condition here, just else)
 *      Present value must be less than future value, your name as title
 *          then call the ResetForm function
 *   */
public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    const double YEARS = 10;


    private void btnCalculate_Click(object sender, EventArgs e)
    {
        try
        {
            //get the data from textboxes
            double futureValue = Convert.ToDouble(txtFutureValue.Text);
            double presentValue = Convert.ToDouble(txtPresentValue.Text);
            double interestRate = 0.0;

            if (presentValue < futureValue)
            {
                //show the picturebox
                picFormula.Show();

                //create formula - using class-level const for Years
                interestRate = Math.Pow(futureValue / presentValue, 1.0 / YEARS) - 1;

                //display the answer and picturebox
                lblInterestRate.Text = interestRate.ToString("p");
            }
            else if (presentValue == futureValue)
            {
                MessageBox.Show("The conditions for this to happen have not been met, therefore, this is invalid");
                ResetForm();
            }
            else
            {
                //Show the error in the message box
                MessageBox.Show("The present value must be less than the future value");
                ResetForm();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Please put in the right value: " + ex.Message);
        }
    }



    /* Name: ResetForm
     * Sent: nothing
     * Return: nothing
     * This function blanks and resets */
    private void ResetForm()
    {
        picFormula.Hide();
        txtFutureValue.Clear();
        txtPresentValue.Clear();
        lblInterestRate.ResetText();
        txtFutureValue.Focus();
    }

    private void Form1_Load_1(object sender, EventArgs e)
    {
        lblYears.Text = Convert.ToString(YEARS);
        ResetForm();
    }

    private void btnReset_Click(object sender, EventArgs e)
    {
        ResetForm();
    }

    private void picFormula_Click(object sender, EventArgs e)
    {

    }
}


