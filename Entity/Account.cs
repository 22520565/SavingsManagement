using System;
using System.Collections;
using System.Runtime.Serialization;

namespace Entity
{
    public class Account
    {
        private int acId;
        private string acUsername;
        private string acPassword;
        private string acEmail;
        private bool acActive = true;
        private int apId;
        private string name;
        private bool isMale;
        private string cicNumber;
        private DateOnly birthDate;
        private string phoneNumber;
        private string address;
        private decimal balance;

        public Account()
        {
        }

        public Account(int acId, string acUsername, string acPassword, string acEmail, bool acActive, int apId, string name, bool isMale, string cicNumber, DateTime birthDate, string phoneNumber, string address, decimal balance)
        {
            this.acId = acId;
            this.acUsername = acUsername;
            this.acPassword = acPassword;
            this.acEmail = acEmail;
            this.acActive = acActive;
            this.apId = apId;
            this.name = name;
            this.isMale = isMale;
            this.cicNumber = cicNumber;
            this.birthDate = DateOnly.FromDateTime(birthDate);
            this.phoneNumber = phoneNumber;
            this.address = address;
            this.balance = balance;
        }

        public int AcId { get => acId; set => acId = value; }
        public string AcUsername { get => acUsername; set => acUsername = value; }
        public string AcPassword { get => acPassword; set => acPassword = value; }
        public string AcEmail { get => acEmail; set => acEmail = value; }
        public bool AcActive { get => acActive; set => acActive = value; }
        public int ApId { get => apId; set => apId = value; }
        public string Name { get => name; set => name = value; }
        public bool IsMale { get => isMale; set => isMale = value; }
        public string CicNumber { get => cicNumber; set => cicNumber = value; }
        public DateOnly BirthDate { get => birthDate; set => birthDate = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Address { get => address; set => address = value; }
        public decimal Balance { get => balance; set => balance = value; }
    }
}
