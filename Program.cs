using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace Day24
{
    class Program
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter your First Name : ");
            string Firstname = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Enter your Last Name : ");
            string Lastname = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Enter your Email ID: ");
            string Email = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Enter your Mobile Number: ");
            string Mobileno = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Enter your Password: ");
            string Password = Console.ReadLine();
            Console.WriteLine();
        }
    }

    public class demo
    {
        public static string Reg_pattern1 = "^[A-Z]{1}[A-Za-z]{2,}$";
        public static string Reg_pattern2 = "^[A-Z]{1}[A-Za-z]{2,}$";
        public static string Reg_pattern3 = "^[A-Za-z0-9]+([.+-][A-Za-z0-9]+)*@[A-Za-z0-9]+[.][a-z]{2,}([.][a-z]{2,})?$";
        public static string Reg_pattern4 = "^[0-9]{2}\\s[0-9]{10}$";

        public static string Reg_pattern5 = "^.*(?=.{8,})(?=.*[A-Z])(?=.*[0-9])(?=.*[@#$%^&+=]).*$";
        public static string Reg_pattern5_1 = "^[a-zA-Z]{8,}([0-9]+)?$";
        public static string Reg_pattern5_2 = "^[A-Z]{1,}[a-zA-Z]{7,}([0-9]+)?$";
        public static string Reg_pattern5_3 = "^(?=.*[A-Z])(?=.*[0-9])[A-Za-z0-9]{8,}([0-9]+)?$";
        public bool validFirstname(string FirstName)
        {
            bool val1 = Regex.IsMatch(FirstName, Reg_pattern1);
            if (val1)
            {
                Console.WriteLine("Pattern is correct for given First name: {0}", FirstName);
                return true;
            }

            else
            {
                Console.WriteLine("pattern First name is wrong");
                return false;
            }
        }


        public bool validLastname(string Lastname)
        {
            bool val2 = Regex.IsMatch(Lastname, Reg_pattern2);
            if (val2)
            {
                Console.WriteLine("Pattern is correct for given Last name: {0}", Lastname);
                return true;
            }
            else
            {
                Console.WriteLine("pattern Last name is wrong");
                return false;
            }

        }


        public bool valiEdmail(string Email)
        {
            bool val3 = Regex.IsMatch(Email, Reg_pattern3);
            if (val3)
            {
                Console.WriteLine("Pattern is correct for given mail ID : {0}", Email);
                return true;
            }
            else
            {
                Console.WriteLine("pattern mail ID  is wrong");
                return false;
            }
        }

        public bool validmobileno(string Mobileno)
        {
            bool val4 = Regex.IsMatch(Mobileno, Reg_pattern4);
            if (val4)
            {
                Console.WriteLine("Pattern is correct for given mobile number : {0}", Mobileno);
                return true;
            }
            else
            {
                Console.WriteLine("pattern mobile number  is wrong");
                return false;
            }

        }
        public bool validPassword1(string Password)
        {
            bool val5 = Regex.IsMatch(Password, Reg_pattern5_1);
            if (val5)
            {
                Console.WriteLine("Pattern is correct for given password : {0}", Password);
                return true;
            }
            else
            {
                Console.WriteLine("pattern password  is wrong");
                return false;
            }
        }
        public bool validPassword2(string Password)
        {
            bool val5 = Regex.IsMatch(Password, Reg_pattern5_2);
            if (val5)
            {
                Console.WriteLine("Pattern is correct for given password : {0}", Password);
                return true;
            }
            else
            {
                Console.WriteLine("pattern password  is wrong");
                return false;
            }
        }
        public bool validPassword3(string Password)
        {
            bool val5 = Regex.IsMatch(Password, Reg_pattern5_3);
            if (val5)
            {
                Console.WriteLine("Pattern is correct for given password : {0}", Password);
                return true;
            }
            else
            {
                Console.WriteLine("pattern password  is wrong");
                return false;
            }
        }
        public bool validPassword4(string Password)
        {
            bool val5 = Regex.IsMatch(Password, Reg_pattern5);
            if (val5)
            {
                Console.WriteLine("Pattern is correct for given password : {0}", Password);
                return true;
            }
            else
            {
                Console.WriteLine("pattern password  is wrong");
                return false;
            }
        }
    }
}


    
