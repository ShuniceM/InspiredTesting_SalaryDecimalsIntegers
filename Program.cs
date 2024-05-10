namespace SalaryDemoApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //daclare vaiable
            decimal hoursWorked;                            //input
            decimal rate;                                   //input
            decimal salary;                                 //input
            Console.WriteLine("Enter hours worked");                            //what message do you want the user to see(output)
            hoursWorked = Convert.ToDecimal(Console.ReadLine());            //this is the decimal input

            Console.WriteLine("Enter rate of pay");                            //what message do you want the user to see(output)
            hoursWorked = Convert.ToDecimal(Console.ReadLine());            //this is the decimal input


            if (hoursWorked > 0 && hoursWorked <= 40) //1-40
            {
               
                salary = hoursWorked * rate;
              

                Console.WriteLine("salary is \tr" + salary.ToString("F2"));
            }

            else if (hoursWorked > 40)
            {
                salary = (hoursWorked - 40) * rate * 1.5m + (40 * rate);        //1.5 is seen as a double and not a decimal to fix the line enter suffic m after
                Console.WriteLine("salary is \tr" + salary.ToString("F2"));
            }
            else
            {
                Console.WriteLine("Invalid entry");
            }
           
                
            

        }//end main
    }//end class
}//end namespace

