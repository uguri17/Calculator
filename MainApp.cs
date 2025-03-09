using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class MainApp : Form
                // MainApp 클래스가 Form으로 부터 상속받음
    {
        enum Operators
        {
            None, // 미지정 상태
            Add,
            Subtract,
            Multiply,
            Divide,
            Result
        } 
        Operators currentOperator = Operators.None; // 초기값 = 미지정 상태
        Boolean operatorChangeFlag = false; // 연산자가 변경 되었느냐 안되었느냐(true/false)
        double firstOperand = 0; // 피연산자(필드)
        double secondOperand = 0; // 피연산자(필드)        

        public MainApp() // 생성자 ...
        {
            // UI 컴포넌트 초기화
            InitializeComponent();
        }
        
        //  메서드 ...
        //  부가기능
        //            
        private void display_Click(object sender, EventArgs e)
        {
            // 계산기 프로그램 화면
        }

        private void ButtonAllClear_Click(object sender, EventArgs e)
        {
            firstOperand = 0;
            secondOperand = 0;
            currentOperator = Operators.None;
            display.Text = "0";
        }

        private void ButtonPoint_Click(object sender, EventArgs e)
        {
            if (!display.Text.Contains("."))
            {
                display.Text += ".";
            }            
        }       
        
        //
        //  연산자 +, -, x, /, =
        //
        private void ButtonAdd_Click(object sender, EventArgs e)
        {            
            firstOperand = double.Parse(display.Text);
            currentOperator = Operators.Add;
            operatorChangeFlag = true;            
        }

        private void ButtonSubtract_Click(object sender, EventArgs e)
        {                   // minus
            firstOperand = double.Parse(display.Text);
            currentOperator = Operators.Subtract;
            operatorChangeFlag = true;
        }

        private void ButtonMultiply_Click(object sender, EventArgs e)
        {
            firstOperand = double.Parse(display.Text);
            currentOperator = Operators.Multiply;
            operatorChangeFlag = true;
        }

        private void ButtonDivide_Click(object sender, EventArgs e)
        {
            firstOperand = double.Parse(display.Text);
            currentOperator = Operators.Divide;
            operatorChangeFlag = true;
        }
        private void ButtonResult_Click(object sender, EventArgs e)
        {
            secondOperand = double.Parse(display.Text);

            if (currentOperator == Operators.Add)  // +
            {
                double result = firstOperand + secondOperand;
                display.Text = result.ToString();
            }

            if (currentOperator == Operators.Subtract)  // -
            {
                double result = firstOperand - secondOperand;
                display.Text = result.ToString();
            }

            if (currentOperator == Operators.Multiply)  // x
            {
                double result = firstOperand * secondOperand;
                display.Text = result.ToString();
            }

            if (currentOperator == Operators.Divide)  // ÷
            {
                double result = firstOperand / secondOperand;
                display.Text = result.ToString();
            }
        }

        //
        //  숫자 0~9
        //
        private void ButtonZero_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true || display.Text == "0")
            {
                display.Text = "";
                operatorChangeFlag = false;
            }

            display.Text += "0"; // str이라서 0과 붙는 모습

            double number;
            if (double.TryParse(display.Text, out number))
            {
                display.Text = number.ToString();
            }
        }

        private void ButtonOne_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true || display.Text == "0")
            {
                display.Text = "";
                operatorChangeFlag = false;
            }
            
            display.Text += "1"; // str

            double number;
            if (double.TryParse(display.Text, out number))
            {
                display.Text= number.ToString();
            }
            /*if (operatorChangeFlag == true) // 연산자가 입력되었을때
            {
                display.Text = ""; // 기존에 표시된 숫자 제거
                operatorChangeFlag = false; // 새로운 입력
            }
            
            string strNumber = display.Text += 1;
            int intNumber = Int32.Parse(strNumber);
            display.Text = intNumber.ToString();*/
        }

        private void ButtonTwo_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true || display.Text == "0") 
            {
                display.Text = "";
                operatorChangeFlag = false;
            }
 
            display.Text += "2";
            
            double number; 
            if(double.TryParse(display.Text, out number))             
            {
                // display.Text를 number로 저장하는데
                // 데이터 타입은 double
                display.Text = number.ToString();
            }
        }

        private void ButtonThree_Click(object sender, EventArgs e)
        {
            if(operatorChangeFlag == true || display.Text == "0")
            {
                display.Text = "";
                operatorChangeFlag = false;
            }

            display.Text += "3";

            double number;
            if(double.TryParse(display.Text, out number))
            {
                display.Text = number.ToString();
            }
        }

        private void ButtonFour_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true || display.Text == "0")
            {
                display.Text = "";
                operatorChangeFlag = false;
            }
            
            display.Text += "4"; 
            
            double number;
            if(double.TryParse(display.Text, out number))
            {
                display.Text = number.ToString();
            }
        }

        private void ButtonFive_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true || display.Text == "0")
            {
                display.Text = "";
                operatorChangeFlag = false;
            }

            display.Text += "5"; 

            double number;
            if (double.TryParse(display.Text, out number))
            {
                display.Text = number.ToString();
            }
        }

        private void ButtonSix_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true || display.Text == "0")
            {
                display.Text = "";
                operatorChangeFlag = false;
            }

            display.Text += "6"; 

            double number;
            if (double.TryParse(display.Text, out number))
            {
                display.Text = number.ToString();
            }
        }

        private void ButtonSeven_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true || display.Text == "0")
            {
                display.Text = "";
                operatorChangeFlag = false;
            }

            display.Text += "7"; 

            double number;
            if (double.TryParse(display.Text, out number))
            {
                display.Text = number.ToString();
            }
        }

        private void ButtonEight_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true || display.Text == "0")
            {
                display.Text = "";
                operatorChangeFlag = false;
            }

            display.Text += "8"; 

            double number;
            if (double.TryParse(display.Text, out number))
            {
                display.Text = number.ToString();
            }
        }

        private void ButtonNine_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true || display.Text == "0")
            {
                display.Text = "";
                operatorChangeFlag = false;
            }

            display.Text += "9"; 

            double number;
            if (double.TryParse(display.Text, out number))
            {
                display.Text = number.ToString();
            }
        }
    }
}