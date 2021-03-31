using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IssueTracker.Models.Employees
{
    public class GetEmployeesResponse
    {
        public IList<GetEmployeeSummaryItem> Employees { get; set; }
        public int NumberOfFullTimeEmployees { get; set; }
    }

    public class GetEmployeeSummaryItem
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
    }
}
