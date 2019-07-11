using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MortageDataSwitch.StaticModels
{
    /// <summary>
    /// Bank schema model
    /// </summary>
    public class BankSchema
    {
        public string SchemaName { get; set; }
        public int ApplicationType { get; set; }
        public string Bank { get; set; }
        public string LoanType { get; set; }
        public string CustomerType { get; set; }
        public int VersionNumber { get; set; }
    }

    /// <summary>
    /// Manager to manage multiple schemas
    /// </summary>
    public static class SchemaManager
    {
        /// <summary>
        /// List of bank schemas to be return via API
        /// </summary>
        /// <returns></returns>
        public static List<BankSchema> GetBankSchemas()
        {
            var bankSchemas = new List<BankSchema>();

            bankSchemas.Add(new BankSchema() { SchemaName = "ABSA Bank Building Loan Single Applicant", ApplicationType = 2, Bank = "ABSA", LoanType = "Building Loan", CustomerType = "Single", VersionNumber = 30 });
            bankSchemas.Add(new BankSchema() { SchemaName = "ABSA Bank Ordinary Loan Single Applicant", ApplicationType = 3, Bank = "ABSA", LoanType = "Ordinary Loan", CustomerType = "Single", VersionNumber = 30 });
            bankSchemas.Add(new BankSchema() { SchemaName = "ABSA Bank Building Loan Joint Bond", ApplicationType = 26, Bank = "ABSA", LoanType = "Building Loan", CustomerType = "Joint", VersionNumber = 30 });
            bankSchemas.Add(new BankSchema() { SchemaName = "ABSA Bank Ordinary Loan Joint Bond", ApplicationType = 27, Bank = "ABSA", LoanType = "Ordinary Loan", CustomerType = "Joint", VersionNumber = 30 });
            bankSchemas.Add(new BankSchema() { SchemaName = "ABSA Bank Building Loan Multiple Applicants", ApplicationType = 50, Bank = "ABSA", LoanType = "Building Loan", CustomerType = "Multiple", VersionNumber = 30 });
            bankSchemas.Add(new BankSchema() { SchemaName = "ABSA Bank Ordinary Loan Multiple Applicants", ApplicationType = 51, Bank = "ABSA", LoanType = "Ordinary Loan", CustomerType = "Multiple", VersionNumber = 30 });
            bankSchemas.Add(new BankSchema() { SchemaName = "ABSA Bank Building Loan Close Corporation", ApplicationType = 74, Bank = "ABSA", LoanType = "Building Loan", CustomerType = "Closed Corporation", VersionNumber = 30 });
            bankSchemas.Add(new BankSchema() { SchemaName = "ABSA Bank Ordinary Loan Close Corporation", ApplicationType = 75, Bank = "ABSA", LoanType = "Ordinary Loan", CustomerType = "Closed Corporation", VersionNumber = 30 });
            bankSchemas.Add(new BankSchema() { SchemaName = "ABSA Bank Building Loan Trust", ApplicationType = 98, Bank = "ABSA", LoanType = "Building Loan", CustomerType = "Trust", VersionNumber = 30 });
            bankSchemas.Add(new BankSchema() { SchemaName = "ABSA Bank Ordinary Loan Trust", ApplicationType = 99, Bank = "ABSA", LoanType = "Ordinary Loan", CustomerType = "Trust", VersionNumber = 30 });
            bankSchemas.Add(new BankSchema() { SchemaName = "ABSA Bank Building Loan Private Company", ApplicationType = 122, Bank = "ABSA", LoanType = "Building Loan", CustomerType = "Company", VersionNumber = 30 });
            bankSchemas.Add(new BankSchema() { SchemaName = "ABSA Bank Ordinary Loan Private Company", ApplicationType = 123, Bank = "ABSA", LoanType = "Ordinary Loan", CustomerType = "Company", VersionNumber = 30 });
            bankSchemas.Add(new BankSchema() { SchemaName = "FNB Bank Building Loan Private Company", ApplicationType = 126, Bank = "FNB", LoanType = "Building Loan", CustomerType = "Company", VersionNumber = 30 });
            bankSchemas.Add(new BankSchema() { SchemaName = "FNB Bank Ordinary Loan Private Company", ApplicationType = 127, Bank = "FNB", LoanType = "Ordinary Loan", CustomerType = "Company", VersionNumber = 30 });
            bankSchemas.Add(new BankSchema() { SchemaName = "FNB Bank Building Loan Trust", ApplicationType = 102, Bank = "FNB", LoanType = "Building Loan", CustomerType = "Trust", VersionNumber = 30 });
            bankSchemas.Add(new BankSchema() { SchemaName = "FNB Bank Ordinary Loan Trust", ApplicationType = 103, Bank = "FNB", LoanType = "Ordinary Loan", CustomerType = "Trust", VersionNumber = 30 });
            bankSchemas.Add(new BankSchema() { SchemaName = "FNB Bank Building Loan Close Corporation", ApplicationType = 78, Bank = "FNB", LoanType = "Building Loan", CustomerType = "Closed Corporation", VersionNumber = 30 });
            bankSchemas.Add(new BankSchema() { SchemaName = "FNB Bank Ordinary Loan Close Corporation", ApplicationType = 79, Bank = "FNB", LoanType = "Ordinary Loan", CustomerType = "Closed Corporation", VersionNumber = 30 });
            bankSchemas.Add(new BankSchema() { SchemaName = "FNB Bank Building Loan Multiple Applicants", ApplicationType = 54, Bank = "FNB", LoanType = "Building Loan", CustomerType = "Multiple", VersionNumber = 30 });
            bankSchemas.Add(new BankSchema() { SchemaName = "FNB Bank Ordinary Loan Multiple Applicants", ApplicationType = 55, Bank = "FNB", LoanType = "Ordinary Loan", CustomerType = "Multiple", VersionNumber = 30 });
            bankSchemas.Add(new BankSchema() { SchemaName = "FNB Bank Building Loan Joint Bond", ApplicationType = 30, Bank = "FNB", LoanType = "Building Loan", CustomerType = "Joint", VersionNumber = 30 });
            bankSchemas.Add(new BankSchema() { SchemaName = "FNB Bank Ordinary Loan Joint Bond", ApplicationType = 31, Bank = "FNB", LoanType = "Ordinary Loan", CustomerType = "Joint", VersionNumber = 30 });
            bankSchemas.Add(new BankSchema() { SchemaName = "FNB Bank Building Loan Single Applicant", ApplicationType = 6, Bank = "FNB", LoanType = "Building Loan", CustomerType = "Single", VersionNumber = 30 });
            bankSchemas.Add(new BankSchema() { SchemaName = "FNB Bank Ordinary Loan Single Applicant", ApplicationType = 7, Bank = "FNB", LoanType = "Ordinary Loan", CustomerType = "Single", VersionNumber = 30 });
            bankSchemas.Add(new BankSchema() { SchemaName = "Nedbank Building Loan Single Applicant", ApplicationType = 10, Bank = "NED", LoanType = "Building Loan", CustomerType = "Single", VersionNumber = 27 });
            bankSchemas.Add(new BankSchema() { SchemaName = "Nedbank Ordinary Loan Single Applicant", ApplicationType = 11, Bank = "NED", LoanType = "Ordinary Loan", CustomerType = "Single", VersionNumber = 27 });
            bankSchemas.Add(new BankSchema() { SchemaName = "Nedbank Building Loan Joint Bond", ApplicationType = 34, Bank = "NED", LoanType = "Building Loan", CustomerType = "Joint", VersionNumber = 27 });
            bankSchemas.Add(new BankSchema() { SchemaName = "Nedbank Ordinary Loan Joint Bond", ApplicationType = 35, Bank = "NED", LoanType = "Ordinary Loan", CustomerType = "Joint", VersionNumber = 27 });
            bankSchemas.Add(new BankSchema() { SchemaName = "Nedbank Building Loan Multiple Applicants", ApplicationType = 58, Bank = "NED", LoanType = "Building Loan", CustomerType = "Multiple", VersionNumber = 27 });
            bankSchemas.Add(new BankSchema() { SchemaName = "Nedbank Ordinary Loan Multiple Applicants", ApplicationType = 59, Bank = "NED", LoanType = "Ordinary Loan", CustomerType = "Multiple", VersionNumber = 27 });
            bankSchemas.Add(new BankSchema() { SchemaName = "Nedbank Building Loan Close Corporation", ApplicationType = 82, Bank = "NED", LoanType = "Building Loan", CustomerType = "Closed Corporation", VersionNumber = 27 });
            bankSchemas.Add(new BankSchema() { SchemaName = "Nedbank Ordinary Loan Close Corporation", ApplicationType = 83, Bank = "NED", LoanType = "Ordinary Loan", CustomerType = "Closed Corporation", VersionNumber = 27 });
            bankSchemas.Add(new BankSchema() { SchemaName = "Nedbank Building Loan Trust", ApplicationType = 106, Bank = "NED", LoanType = "Building Loan", CustomerType = "Trust", VersionNumber = 27 });
            bankSchemas.Add(new BankSchema() { SchemaName = "Nedbank Ordinary Loan Trust", ApplicationType = 107, Bank = "NED", LoanType = "Ordinary Loan", CustomerType = "Trust", VersionNumber = 27 });
            bankSchemas.Add(new BankSchema() { SchemaName = "Nedbank Building Loan Private Company", ApplicationType = 130, Bank = "NED", LoanType = "Building Loan", CustomerType = "Company", VersionNumber = 27 });
            bankSchemas.Add(new BankSchema() { SchemaName = "Nedbank Ordinary Loan Private Company", ApplicationType = 131, Bank = "NED", LoanType = "Ordinary Loan", CustomerType = "Company", VersionNumber = 27 });
            bankSchemas.Add(new BankSchema() { SchemaName = "Standard Bank Building Loan Private Company", ApplicationType = 142, Bank = "STD", LoanType = "Building Loan", CustomerType = "Company", VersionNumber = 29 });
            bankSchemas.Add(new BankSchema() { SchemaName = "Standard Bank Ordinary Loan Private Company", ApplicationType = 143, Bank = "STD", LoanType = "Ordinary Loan", CustomerType = "Company", VersionNumber = 29 });
            bankSchemas.Add(new BankSchema() { SchemaName = "Standard Bank Building Loan Trust", ApplicationType = 118, Bank = "STD", LoanType = "Building Loan", CustomerType = "Trust", VersionNumber = 29 });
            bankSchemas.Add(new BankSchema() { SchemaName = "Standard Bank Ordinary Loan Trust", ApplicationType = 119, Bank = "STD", LoanType = "Ordinary Loan", CustomerType = "Trust", VersionNumber = 29 });
            bankSchemas.Add(new BankSchema() { SchemaName = "Standard Bank Building Loan Close Corporation", ApplicationType = 94, Bank = "STD", LoanType = "Building Loan", CustomerType = "Closed Corporation", VersionNumber = 29 });
            bankSchemas.Add(new BankSchema() { SchemaName = "Standard Bank Ordinary Loan Close Corporation", ApplicationType = 95, Bank = "STD", LoanType = "Ordinary Loan", CustomerType = "Closed Corporation", VersionNumber = 29 });
            bankSchemas.Add(new BankSchema() { SchemaName = "Standard Bank Building Loan Multiple Applicants", ApplicationType = 70, Bank = "STD", LoanType = "Building Loan", CustomerType = "Multiple", VersionNumber = 29 });
            bankSchemas.Add(new BankSchema() { SchemaName = "Standard Bank Ordinary Loan Multiple Applicants", ApplicationType = 71, Bank = "STD", LoanType = "Ordinary Loan", CustomerType = "Multiple", VersionNumber = 29 });
            bankSchemas.Add(new BankSchema() { SchemaName = "Standard Bank Building Loan Joint Bond", ApplicationType = 46, Bank = "STD", LoanType = "Building Loan", CustomerType = "Joint", VersionNumber = 29 });
            bankSchemas.Add(new BankSchema() { SchemaName = "Standard Bank Ordinary Loan Joint Bond", ApplicationType = 47, Bank = "STD", LoanType = "Ordinary Loan", CustomerType = "Joint", VersionNumber = 29 });
            bankSchemas.Add(new BankSchema() { SchemaName = "Standard Bank Building Loan Single Applicant", ApplicationType = 22, Bank = "STD", LoanType = "Building Loan", CustomerType = "Single", VersionNumber = 29 });
            bankSchemas.Add(new BankSchema() { SchemaName = "Standard Bank Ordinary Loan Single Applicant", ApplicationType = 23, Bank = "STD", LoanType = "Ordinary Loan", CustomerType = "Single", VersionNumber = 29 });
            bankSchemas.Add(new BankSchema() { SchemaName = "ITHALA Bank Ordinary Loan Single Applicant", ApplicationType = 164, Bank = "ITHALA", LoanType = "Ordinary Loan", CustomerType = "Single", VersionNumber = 27 });
            bankSchemas.Add(new BankSchema() { SchemaName = "HIP Bank Ordinary Loan Single Applicant", ApplicationType = 162, Bank = "HIP", LoanType = "Ordinary Loan", CustomerType = "Multiple", VersionNumber = 23 });
            bankSchemas.Add(new BankSchema() { SchemaName = "HIP Bank Ordinary Loan Single Applicant", ApplicationType = 162, Bank = "HIP", LoanType = "Ordinary Loan", CustomerType = "Single", VersionNumber = 23 });
            bankSchemas.Add(new BankSchema() { SchemaName = "HIP Bank Ordinary Loan Single Applicant", ApplicationType = 162, Bank = "HIP", LoanType = "Ordinary Loan", CustomerType = "Joint", VersionNumber = 23 });

            return bankSchemas;
        }
    }
}