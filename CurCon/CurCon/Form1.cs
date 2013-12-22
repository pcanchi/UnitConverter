using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CurCon
{
    public partial class Form1 : Form
    {
        string[] dist_args;
        string[] speed_args;
        string[] time_args;
        enum choice {None, Distance, Speed, Time};
        choice typeChoice;
        double amount;
        Form2 form2 = new Form2();
        

        public Form1()
        {
            InitializeComponent();
            dist_args = new string[5] { "Feet", "Miles", "Kilometers", "Meters", "Yards" };
            speed_args = new string[2] { "Miles/Hr", "Km/Hr" };
            time_args = new string[4] { "Minutes", "Seconds", "Hours", "Days" };
            typeChoice = choice.None;
            amount = 0;
        }

        public double calc_Speed(double value, string source_unit)
        {
            if (source_unit == "Miles/Hr")
                return Math.Round((value * 1.61), 3);
            else
                return Math.Round((value / 1.61), 3);

        }

        public double feetKm(double value, string source_unit)
        {
            if (source_unit == "Feet")
                return Math.Round((value * 0.0003048), 3);
            else
                return Math.Round((value / 0.0003048), 3);
        }

        public double feetMeters(double value, string source_unit)
        {
            if (source_unit == "Feet")
                return Math.Round((value * 0.3048), 3);
            else
                return Math.Round((value / 0.3048), 3);
        }

        public double feetMiles(double value, string source_unit)
        {
            if (source_unit == "Feet")
                return Math.Round((value / 5280.0), 3);
            else
                return Math.Round((value * 5280.0), 3);
        }

        public double feetYards(double value, string source_unit)
        {
            if (source_unit == "Feet")
                return Math.Round((value / 12.0), 3);
            else
                return Math.Round((value * 12.0), 3);
        }

        public double KmMeters(double value, string source_unit)
        {
            if (source_unit == "Kilometers")
                return Math.Round((value * 1000.0), 3);
            else
                return Math.Round((value / 1000.0), 3);
        }

        public double KmMiles(double value, string source_unit)
        {
            if (source_unit == "Kilometers")
                return Math.Round((value / 1.61), 3);
            else
                return Math.Round((value * 1.61), 3);
        }

        public double KmYards(double value, string source_unit)
        {
            if (source_unit == "Kilometers")
                return Math.Round((value * 1093.61), 3);
            else
                return Math.Round((value / 1093.61), 3);
        }

        public double MetersMiles(double value, string source_unit)
        {
            if (source_unit == "Meters")
                return Math.Round((value * 0.000621371), 3);
            else
                return Math.Round((value / 0.000621371), 3);
        }

        public double MetersYards(double value, string source_unit)
        {
            if (source_unit == "Meters")
                return Math.Round((value * 1.09361), 3);
            else
                return Math.Round((value / 1.09361), 3);
        }

        public double MilesYards(double value, string source_unit)
        {
            if(source_unit == "Miles")
                return Math.Round((value * 1760.0), 3);
            else
                return Math.Round((value / 1760.0), 3);
        }

        public double dist_Controller(double value, string source_unit, string dest_unit)
        {
            if ((source_unit == "Feet" && dest_unit == "Kilometers") || (source_unit == "Kilometers" && dest_unit == "Feet"))
                return feetKm(value, source_unit);

            else if ((source_unit == "Feet" && dest_unit == "Meters") || (source_unit == "Meters" && dest_unit == "Feet"))
                return feetMeters(value, source_unit);

            else if ((source_unit == "Feet" && dest_unit == "Miles") || (source_unit == "Miles" && dest_unit == "Feet"))
                return feetMiles(value, source_unit);

            else if ((source_unit == "Feet" && dest_unit == "Yards") || (source_unit == "Yards" && dest_unit == "Feet"))
                return feetYards(value, source_unit);
//from here
            else if ((source_unit == "Kilometers" && dest_unit == "Meters") || (source_unit == "Meters" && dest_unit == "Kilometers"))
                return KmMeters(value, source_unit);

            else if ((source_unit == "Kilometers" && dest_unit == "Miles") || (source_unit == "Miles" && dest_unit == "Kilometers"))
                return KmMiles(value, source_unit);

            else if ((source_unit == "Kilometers" && dest_unit == "Yards") || (source_unit == "Yards" && dest_unit == "Kilometers"))
                return KmYards(value, source_unit);

            else if ((source_unit == "Meters" && dest_unit == "Miles") || (source_unit == "Miles" && dest_unit == "Meters"))
                return MetersMiles(value, source_unit);

            else if ((source_unit == "Meters" && dest_unit == "Yards") || (source_unit == "Yards" && dest_unit == "Meters"))
                return MetersYards(value, source_unit);

            else if ((source_unit == "Miles" && dest_unit == "Yards") || (source_unit == "Yards" && dest_unit == "Miles"))
                return MilesYards(value, source_unit);

            else
                return 0.0;
                

        }

        public double DaysHours(double value, string source_unit)
        {
            if (source_unit == "Days")
                return Math.Round((value * 24.0), 3);
            else
                return Math.Round((value / 24.0), 3);
        }

        public double DaysMinutes(double value, string source_unit)
        {
            if (source_unit == "Days")
                return Math.Round((value * 1440.0), 3);
            else
                return Math.Round((value / 1440.0), 3);
        }

        public double DaysSeconds(double value, string source_unit)
        {
            if (source_unit == "Days")
                return Math.Round((value * 86400.0), 3);
            else
                return Math.Round((value / 86400.0), 3);
        }

        public double HoursMinutes(double value, string source_unit)
        {
            if(source_unit == "Hours")
                return Math.Round((value * 60.0), 3);
            else
                return Math.Round((value / 60.0), 3);
        }

        public double HoursSeconds(double value, string source_unit)
        {
            if (source_unit == "Hours")
                return Math.Round((value * 3600.0), 3);
            else
                return Math.Round((value / 3600.0), 3);
        }

        public double MinutesSeconds(double value, string source_unit)
        {
            if (source_unit == "Minutes")
                return Math.Round((value * 60.0), 3);
            else
                return Math.Round((value / 60.0), 3);
        }
        
        public double time_Controller(double value, string source_unit, string dest_unit)
        {
            if ((source_unit == "Days" && dest_unit == "Hours") || (source_unit == "Hours" && dest_unit == "Days"))
                return DaysHours(value, source_unit);

            else if ((source_unit == "Days" && dest_unit == "Minutes") || (source_unit == "Minutes" && dest_unit == "Days"))
                return DaysMinutes(value, source_unit);

            else if ((source_unit == "Days" && dest_unit == "Seconds") || (source_unit == "Seconds" && dest_unit == "Days"))
                return DaysSeconds(value, source_unit);

            else if ((source_unit == "Hours" && dest_unit == "Minutes") || (source_unit == "Minutes" && dest_unit == "Hours"))
                return HoursMinutes(value, source_unit);

            else if ((source_unit == "Hours" && dest_unit == "Seconds") || (source_unit == "Seconds" && dest_unit == "Hours"))
                return HoursSeconds(value, source_unit);

            else if ((source_unit == "Minutes" && dest_unit == "Seconds") || (source_unit == "Seconds" && dest_unit == "Minutes"))
                return MinutesSeconds(value, source_unit);

            else
                return 0.0;
        }

        private void dataSelection_SelectedValueChanged(object sender, EventArgs e)
        {
            from.Items.Clear();
            from.Text = "";
            to.Items.Clear();
            to.Text = "";
            Amt.Enabled = false;
            if (dataSelection.Text == "Distance")
            {
                foreach (string str in dist_args)
                {
                    from.Items.Add(str);
                    to.Items.Add(str);
                }
                typeChoice = choice.Distance;

            }
            else if (dataSelection.Text == "Speed")
            {
                foreach (string str in speed_args)
                {
                    from.Items.Add(str);
                    to.Items.Add(str);
                }
                typeChoice = choice.Speed;
            }

            else if (dataSelection.Text == "Time")
            {
                foreach (string str in time_args)
                {
                    from.Items.Add(str);
                    to.Items.Add(str);
                }
                typeChoice = choice.Time;
            }
            from.Enabled = true;
            to.Enabled = true;
        }

        private void calc_Click(object sender, EventArgs e)
        {
            if (dataSelection.Text.Length == 0)
                converted.Text = "Null";
            else
            {
                try
                {
                    amount = Convert.ToDouble(Amt.Text);
                }

                catch (FormatException f)
                {

                    form2.Controls[0].Text = f.Message;
                    form2.Show();
                }

                finally
                {
                    if (dataSelection.Text == "Distance")
                    {
                        converted.Text = dist_Controller(amount, from.Text, to.Text).ToString();
                    }

                    else if (dataSelection.Text == "Speed")
                    {
                        converted.Text = calc_Speed(amount, from.Text).ToString();
                    }

                    else if (dataSelection.Text == "Time")
                    {
                        converted.Text = time_Controller(amount, from.Text, to.Text).ToString();
                    }
                }

            }
        }

        private void from_SelectedValueChanged(object sender, EventArgs e)
        {
            if (from.Text.Length > 0 && to.Text.Length > 0)
                Amt.Enabled = true;

            if (from.Text == to.Text)
            {
                if (to.SelectedIndex < (to.Items.Count - 1))
                    to.Text = to.Items[to.SelectedIndex + 1].ToString();
                else
                    to.Text = to.Items[0].ToString();
            }
        }

        private void to_SelectedValueChanged(object sender, EventArgs e)
        {
          if (from.Text.Length > 0 && to.Text.Length > 0)
                Amt.Enabled = true;

          if (from.Text == to.Text)
          {
              if (from.SelectedIndex < (from.Items.Count - 1))
                  from.Text = from.Items[from.SelectedIndex + 1].ToString();
              else
                  from.Text = from.Items[0].ToString();
          }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void swap_Click(object sender, EventArgs e)
        {
            if (to.Text.Length == 0 || from.Text.Length == 0)
                return;
            else
            {
                string temp = to.Text;
                to.Text = from.Text;
                from.Text = temp;
            }
        }
    }
}
