// Project Prolog
// Name: Adam Armstrong
// CS3260 Section 001
// Project: Lab_03
// Date: 09/03/2018 - 09/07/2018
// Purpose: A complex arithmetic calculator that will add and subtract complex numbers.
//
// I declare that the following code was written by me or provided
// by the instructor for this project. I understand that copying source
// code from any other source constitutes plagiarism, and that I will receive
// a zero on this project if I am found in violation of this policy.
// ---------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_03_AHA {
    // Form1:
    public partial class Form1 : Form {

        // Form1:
        public Form1() {
            InitializeComponent();
        }

        // Form1 Load:
        private void Form1_Load(object sender, EventArgs e) { }

        // -----------------------------------------------------------------------------

            // Rich TextBox 2 -- text changed:
            private void richTextBox2_TextChanged(object sender, EventArgs e) { }

            // Rich TextBox 5 -- text changed:
            private void richTextBox5_TextChanged(object sender, EventArgs e) { }

            // Rich TextBox 6 -- text changed:
            private void richTextBox6_TextChanged(object sender, EventArgs e) { }

            // Clicked on "Add" label:
            private void Lbl_Add_Click(object sender, EventArgs e) { }

            // Text Box 1 -- Text Changed:
            private void textBox1_TextChanged(object sender, EventArgs e) { }

            // Text Box 3 -- Text Changed:
            private void textBox3_TextChanged(object sender, EventArgs e) { }

        // -----------------------------------------------------------------------------

        // Clicked on "Calculate" button:
        private void Calculate_Click(object sender, EventArgs e) {
            
        }

        // Clicked on "Run Tests" button:
        private void Btn_RunTests_Click(object sender, EventArgs e) {

        }

        // Clicked on "Exit" button:
        private void Btn_Exit_Click(object sender, EventArgs e) {

        }
    } // END Form1


    // Design and program a ComplexArithmetic class,
    // which does calculations of addition, subtraction, multiplication and division
    // on objects of the ComplexData class.


    // Complex Data:
    public class ComplexData {
        //  Remember that a complex number consists of a signed real number and a signed imaginary number
        //  i.e. (+/-) real_number + (+/-)imaginary_number i where i = √-1.
        //  i.e. real + imagi.

        double real_number { get; set; }
        double imaginary_number { get; set; }

        // ComplexData Constructor:
        public ComplexData(double real, double imagi) {
            real_number = real;
            imaginary_number = imagi;
        } // END constructor

        // Operator "+" Overload for ComplexData:
        public static ComplexData operator +(ComplexData num1, ComplexData num2) {
            return new ComplexData(num1.real_number + num2.real_number, num2.imaginary_number + num2.imaginary_number);
        }

        // Operator "-" Overload for ComplexData:
        public static ComplexData operator -(ComplexData num1, ComplexData num2) {
            return new ComplexData(num1.real_number - num2.real_number, num2.imaginary_number - num2.imaginary_number);
        }

        // Operator "*" Overload for ComplexData:
        public static ComplexData operator *(ComplexData num1, ComplexData num2) {
            return new ComplexData(num1.real_number * num2.real_number, num2.imaginary_number * num2.imaginary_number);
        }

        // Operator "/" Overload for ComplexData:
        public static ComplexData operator /(ComplexData num1, ComplexData num2) {
            return new ComplexData(num1.real_number / num2.real_number, num2.imaginary_number / num2.imaginary_number);
        }
    } // END ComplexData


    // Complex Arithmetic:
    public class ComplexArithmetic {
        ComplexData data;

        // ComplexArithmetic Constructor:
        public ComplexArithmetic(ComplexData cd) {
            /data = cd;

            ComplexData.Set
                
                (Tb_Real1.Text, Tb_Imaginary1.Text);
        } // END constructor

        // addition:
        private void addition() {

        }

        // subtraction:
        private void subtraction() {

        }

        // multiplication:
        private void multiplication() {

        }

        // division:
        private void division() {

        }

    } // END ComplexArithmetic

} // END namespace Lab_03_AHA


/*  Write a GUI (Windows Form Application) based C# program, which is a complex arithmetic calculator that will add and subtract complex numbers.
    Design and program a ComplexArithmetic class, which does calculations of addition, subtraction, multiplication and division on objects of the ComplexData class.
    The ComplexData class holds a single complex number; however, DO NOT use the classes provided in C#, write your own classes. 

    Remember that a complex number consists of a signed real number and a signed imaginary number
        i.e. (+/-) real_number + (+/-)imaginary_number i where i = √-1.
        i.e. real + imag i.

    Your complex number calculator program will add, subtract, multiply and divide two complex numbers.
    Use properties (get/set) assessors/mutators for the real or imaginary value of the complex number object.
     
          operand1      - 2.0 + 3.0i   stored as     (- 2.0) +  (+3.0i)
          operand2      +5.0 – 5.0i    stored as     (+5.0) +  (- 5.0i)              
          result        +3.0 -  2.0i   stored as     (+3.0) +  (- 2.0i)

          REMEMBER: That i x i = i^2 = √-1^2 = -1


    Addition of two complex numbers:
        Operand1     2.2 + 3.2i
        Operator     + (plus)
        Operand2     3.2 + 2.3i
        Result       5.4 + 5.5i  (re1+re2) + (im1+im2) = sumre + sumim


    Subtraction of two complex numbers:
        Operand1       2.2 + 3.2i
        Operator       – (minus)
        Operand2       3.2 + 2.3i
        Result         -1.0 + 0.9i  (re1-re2) + (im1-im2) = difre + difim


    You can be as creative as you wish for the user-interface as long as it is a GUI.
    However, you MUST insure that the user cannot enter invalid data, i.e. 1a2.0 is not a valid double; however,<space>12.30<space> is a valid double!

    As part of this assignment you will need to include a UML class diagram.
*/