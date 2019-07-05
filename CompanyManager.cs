using StockManagementSystem.Gateway;
using StockManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.Manager
{
    class CompanyManager
    {
        CompanyGateway companyGateway = new CompanyGateway();
        public string SaveCompany(Company company)
        {
            int row = companyGateway.SaveCompany(company);
            if (row > 0)
            {
                return "Company Saved Successful.";
            }
            return "Save Failed!";
        }
        public List<Company> GetCompaies()
        {
            return companyGateway.GetCompanies();
        }
        public string UpdateCompany(Company company)
        {
            int row = companyGateway.UpdateCompany(company);
            if (row > 0)
            {
                return "Company Update Successful.";
            }
            return "Update Failed!";
        }
        public bool IsExistCompany(Company company)
        {
            if (companyGateway.IsExistCompany(company))
            {
                return true;
            }
            return false;
        }
    }
}
