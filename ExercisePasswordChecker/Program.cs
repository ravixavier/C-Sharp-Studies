using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisePasswordChecker
{
    internal class Program
    {
        /*
         * Ask user to enter password, and store
         * Ask user to enter password again, and store
         * Check if they are both contain something
             * If so, check if they are the same
                 * If they are, print "Passwords match."
                 * If they are not, print "Passwords do not match."
             * If they are empty, print "Please enter a password."
         */

        static void Main(string[] args)
        {
            bool pwdCheck;
            bool pwdConfirmCheck;
            bool equalsCheck;
            bool lengthCheck;


            do
            {
                Console.Write("Choose a password: ");
                string pwd = Console.ReadLine();
                Console.WriteLine();
                Console.Write("Confirm your password: ");
                string pwdConfirm = Console.ReadLine();

                pwdCheck = (!string.IsNullOrEmpty(pwd));
                pwdConfirmCheck = (!string.IsNullOrEmpty(pwdConfirm));
                equalsCheck = (string.Equals(pwd, pwdConfirm));
                lengthCheck = (pwd.Length >= 6 && pwdConfirm.Length >= 6);

                if (pwdCheck)
                {
                    if (pwdConfirmCheck)
                    {
                        if (lengthCheck)
                        {
                            if (equalsCheck)
                            {
                                Console.WriteLine("Passwords match");
                            }
                            else
                            {
                                Console.WriteLine("Passwords do not match");
                                Console.WriteLine();
                            }
                        }
                        else
                        {
                            Console.WriteLine("Please entre 6 or more characters!");
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please confirm your password");
                        Console.WriteLine();
                    }

                }
                else
                {
                    Console.WriteLine("You must create a password");
                    Console.WriteLine();
                }

            } while (!pwdCheck || !equalsCheck || !lengthCheck);



            Console.ReadLine();
        }
    }
}
