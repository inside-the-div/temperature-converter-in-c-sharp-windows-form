using Microsoft.Data;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace TemperatureConverter
{
    public partial class TempConverter : Form
    {
        SqlConnection DBconnection = new SqlConnection("Data Source=.; Initial Catalog=temperature_converter_db; TrustServerCertificate=True; Integrated Security=True ");
        public TempConverter()
        {
            InitializeComponent();
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyUp);

        }

        private void TempConverter_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 1;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == "" || textBox2.Text == "-" || textBox2.Text == "+" || textBox2.Text == ".")
            {
                textBox2.Text = string.Empty;
            }
            else
            {
                double Number = Convert.ToDouble(textBox2.Text);
                double Result = TempCconverter(Number, comboBox2.SelectedItem.ToString(), comboBox1.SelectedItem.ToString());
                textBox1.Text = Result.ToString();
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox1.Text == "-" || textBox1.Text == "+" || textBox1.Text == ".")
            {
                textBox2.Text = string.Empty;
            }
            else
            {
                double Number = Convert.ToDouble(textBox1.Text);
                double Result = TempCconverter(Number, comboBox1.SelectedItem.ToString(), comboBox2.SelectedItem.ToString());
                textBox2.Text = Result.ToString();
            }            
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (textBox1.Text == "" || textBox1.Text == "-" || textBox1.Text == "+" || textBox1.Text == ".")
            {
                textBox2.Text = string.Empty;
            }
            else
            {
                double Number = Convert.ToDouble(textBox1.Text);
                double Result = TempCconverter(Number, comboBox1.SelectedItem.ToString(), comboBox2.SelectedItem.ToString());
                textBox2.Text = Result.ToString();
                if (e.KeyCode == Keys.Enter)
                {
                    string time = DateTime.Now.ToString();
                    string HistorySaveQuery = " INSERT INTO temperature_convert_history " +
                        "(converted_from, converted_to, converted_number, result, converted_datetime) VALUES " +
                        "('"+ comboBox1.SelectedItem.ToString() + "', '"
                        + comboBox2.SelectedItem.ToString() + "', "
                        +Number+", '"+
                        Result.ToString()+"','"+
                        time+"')";
                    DBconnection.Open();
                    SqlCommand command = new SqlCommand(HistorySaveQuery,DBconnection);
                    command.ExecuteNonQuery();
                    DBconnection.Close();
                }
            }           
        }

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {
            if (textBox2.Text == "" || textBox2.Text == "-" || textBox2.Text == "+" || textBox2.Text == ".")
            {
                textBox2.Text = string.Empty;
            }
            else
            {
                double Number = Convert.ToDouble(textBox2.Text);
                double Result = TempCconverter(Number, comboBox2.SelectedItem.ToString(), comboBox1.SelectedItem.ToString());
                textBox1.Text = Result.ToString();
                if (e.KeyCode == Keys.Enter)
                {
                    string time = DateTime.Now.ToString();
                    string HistorySaveQuery = " INSERT INTO temperature_convert_history " +
                        "(converted_from, converted_to, converted_number, result, converted_datetime) VALUES " +
                        "('" + comboBox2.SelectedValue.ToString() + "', '"
                        + comboBox1.SelectedValue.ToString() + "', "
                        + Number + ", '" +
                        Result.ToString() + "','" +
                        time + "')";
                    DBconnection.Open();
                    SqlCommand command = new SqlCommand(HistorySaveQuery, DBconnection);
                    command.ExecuteNonQuery();
                    DBconnection.Close();

                }
            }
        }

        public double TempCconverter(double temp, string from_unit, string to_unit)
        {
            from_unit = from_unit.ToLower();
            to_unit = to_unit.ToLower();
            if (from_unit == "celsius")
            {
                if (to_unit == "kelvin")
                {
                    temp = temp + 273.15;
                    LabelFormula.Text = ("Formula:\nKelvin = Celcius + 273.15");
                }
                else if (to_unit == "fahrenheit")
                {
                    temp = temp * 9 / 5 + 32;
                    LabelFormula.Text = ("Formula:\nFahrenheit = Celcius * 9/5 + 32");
                }

                else if (to_unit == "rankine")
                {
                    temp = (temp * 9/5) + 491.67;
                    LabelFormula.Text = ("Formula:\n Rankine = (Celsius x 9/5) + 491.67");
                }
            }
            else if (from_unit == "kelvin")
            {
                if (to_unit == "celsius")
                {
                    temp = temp - 273.15;
                    LabelFormula.Text = ("Formula:\nCelcius = Kelvin + 273.15");
                }
                else if (to_unit == "fahrenheit")
                {
                    temp = (temp - 273.15) * 9/5 - 459.67;
                    LabelFormula.Text = ("Formula:\nFahrenheit = (Kelvin  - 273.15) * 9/5 - 459.67");
                }
                else if (to_unit == "rankine")
                {
                    temp = temp * 9/5 + 491.67;
                    LabelFormula.Text = ("Formula:\nRankine = (Kelvin  * 9/5) + 491.67");
                }
            }
            else if (from_unit == "fahrenheit")
            {
                if (to_unit == "celsius")
                {
                    temp = (temp - 32) * 5/9;
                    LabelFormula.Text = ("Formula:\nCelcius = (Fahrenheit - 32) * 5/9");
                }
                else if (to_unit == "kelvin")
                {
                    temp = (temp + 459.67) * 5/9;
                    LabelFormula.Text = ("Formula:\nKelvin = (Fahrenheit + 459.67) * 5/9");
                }
                else if (to_unit == "rankine")
                {
                    temp = temp + 459.67;
                    LabelFormula.Text = ("Formula:\nRankine = Fahrenheit + 459.67");
                }
            }
            else if (from_unit == "rankine")
            {
                if (to_unit == "celsius")
                {
                    temp = (temp - 491.67) * 5/9;
                    LabelFormula.Text = ("Formula:\nCelcius = (Rankine - 491.67) * 5/9");
                }
                else if (to_unit == "kelvin")
                {
                    temp = temp * 5/9;
                    LabelFormula.Text = ("Formula:\nKelvin = (Rankine * 5/9");
                }
                else if (to_unit == "fahrenheit")
                {
                    temp = temp - 459.67;
                    LabelFormula.Text = ("Formula:\nFahrenheit = (Rankine 491.67) * 9/5");
                }
            }
            else
            {
                return temp;
            }
            return temp;
        }

        private bool IsOKForDecimalTextBox(char theCharacter, TextBox theTextBox)
        {

            if (!char.IsControl(theCharacter)
                && !char.IsDigit(theCharacter)
                && (theCharacter != '.')
                && (theCharacter != '-')
                && (theCharacter != '+')
            )
            {
                // Then it is NOT a character we want allowed in the text box.
                return false;
            }

            // Only allow one decimal point.
            if (theCharacter == '.'
                && theTextBox.Text.IndexOf('.') > -1)
            {
                // Then there is already a decimal point in the text box.
                return false;
            }

            // Only allow one minus sign.
            if (theCharacter == '-'
                && theTextBox.Text.IndexOf('-') > -1)
            {
                // Then there is already a minus sign in the text box.
                return false;
            }

            // Only allow one plus sign.
            if (theCharacter == '+'
                && theTextBox.Text.IndexOf('+') > -1)
            {
                // Then there is already a plus sign in the text box.
                return false;
            }

            // Only allow one plus sign OR minus sign, but not both.
            if (
                (
                    (theCharacter == '-')
                    || (theCharacter == '+')
                )
                &&
                (
                    (theTextBox.Text.IndexOf('-') > -1)
                    ||
                    (theTextBox.Text.IndexOf('+') > -1)
                )
                )
            {
                // Then the user is trying to enter a plus or minus sign and
                // there is ALREADY a plus or minus sign in the text box.
                return false;
            }

            // Only allow a minus or plus sign at the first character position.
            if (
                (
                    (theCharacter == '-')
                    || (theCharacter == '+')
                )
                && theTextBox.SelectionStart != 0
                )
            {
                // Then the user is trying to enter a minus or plus sign at some position 
                // OTHER than the first character position in the text box.
                return false;
            }

            // Only allow digits and decimal point AFTER any existing plus or minus sign
            if (
                    (
                        // Is digit or decimal point
                        char.IsDigit(theCharacter)
                        ||
                        (theCharacter == '.')
                    )
                    &&
                    (
                        // A plus or minus sign EXISTS
                        (theTextBox.Text.IndexOf('-') > -1)
                        ||
                        (theTextBox.Text.IndexOf('+') > -1)
                    )
                    &&
                        // Attempting to put the character at the beginning of the field.
                        theTextBox.SelectionStart == 0
                )
            {
                // Then the user is trying to enter a digit or decimal point in front of a minus or plus sign.
                return false;
            }

            // Otherwise the character is perfectly fine for a decimal value and the character
            // may indeed be placed at the current insertion position.
            return true;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!IsOKForDecimalTextBox(e.KeyChar, textBox1))
            {
                e.Handled = true;
            }            
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!IsOKForDecimalTextBox(e.KeyChar, textBox2))
            {
                e.Handled = true;
            }
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            this.Hide();
            History history = new History();
            history.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}