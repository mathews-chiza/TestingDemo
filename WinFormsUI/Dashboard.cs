using DemoLibrary;
using DemoLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsUI
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            double sum = Calculator.Add(((double)firstNumber.Value), ((double)secondNumber.Value));
            result.Text = sum.ToString();
            this.ClearCalculatorInputs();
        }

        private void subtract_Click(object sender, EventArgs e)
        {
            double difference = Calculator.Subtract((double)firstNumber.Value, ((double)secondNumber.Value));
            result.Text = difference.ToString();
            this.ClearCalculatorInputs();
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            double product = Calculator.Multiply((double)firstNumber.Value, ((double)secondNumber.Value));
            result.Text = product.ToString();
            this.ClearCalculatorInputs();
        }

        private void divide_Click(object sender, EventArgs e)
        {
            double dividend = Calculator.Divide((double)firstNumber.Value, ((double)secondNumber.Value));
            result.Text = dividend.ToString();
            this.ClearCalculatorInputs();
        }

        private void ClearDataInputs()
        {
            firstName.Text = "";
            lastName.Text = "";
        }

        private void ClearCalculatorInputs()
        {
            firstNumber.Value = 0;
            secondNumber.Value = 0;
        }

        private void addPerson_Click(object sender, EventArgs e)
        {
            PersonModel person = new PersonModel
            {
                FirstName = firstName.Text,
                LastName = lastName.Text
            };
            this.ClearDataInputs();
            DataAccess.AddNewPerson(person);
            this.AddPeopleToComboBox();
        }

        private void AddPeopleToComboBox()
        {
            users.Items.Clear();
            List<PersonModel> people = DataAccess.GetAllPeople();
            foreach (PersonModel person in people)
            {
                users.Items.Add(person.FullName);
            }
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            this.AddPeopleToComboBox();
        }
    }
}
