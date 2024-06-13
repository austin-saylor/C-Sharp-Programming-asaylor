using System;
using System.IO;

namespace CustomerMgmt
{
    public class Customer
    {
        // Private variables (fields)
        private string lastName;
        private string firstName;
        private int customerID;
        private string businessName;
        private string phoneNumber;

        // Constructor
        public City(string lastName, string firstName, int customerID, string businessName, string phoneNumber)
        {
            this.lastName = lastName;
            this.firstName = firstName;
            this.customerID = customerID;
            this.businessName = businessName;
            this.phoneNumber = phoneNumber;
        }

        // Automatic getter/setter property for 'lastName'
        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }

        // Automatic getter/setter property for 'firstName'
        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }

        // Automatic getter/setter property for 'customerID'
        public int CustomerID
        {
            get { return this.customerID; }
            set { this.customerID = value; }
        }

        // Automatic getter/setter property for 'businessName'
        public string BusinessName
        {
            get { return this.businessName; }
            set { this.businessName = value; }
        }

        // Automatic getter/setter property for 'phoneNumber'
        public string PhoneNumber
        {
            get { return this.phoneNumber; }
            set { this.phoneNumber = value; }
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            // Path to the entry file
            string filePath = "entries.txt";

            // A list to separate different customer data components
            List<List<string>> customerData = new List<List<string>>();

            // Ensure the file exists
            if (!File.Exists(filePath))
            {
                Console.WriteLine($"File {filePath} does not exist.");
                return;
            }

            // Read from the entry file, adding each line into a list of lists, representing data for each customer
            using (StreamReader sr = new StreamReader(filePath))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    // Parse the line (customer info) into a list, using ", " as the delimiter
                    List<string> customerInfo = new List<string>(line.Split(new string[] { ", " }, StringSplitOptions.None));
                    customerData.Add(customerInfo);
                }
            }
        }
    }
}
