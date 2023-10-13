using BerthanysPieShopHRM.App.Models;
using BethanysPieShopHRM.Shared.Domain;

namespace BerthanysPieShopHRM.App.Pages
{
    public partial class EmployeeOverview
    {
        public List<Employee>? Employees { get; set; } = default!;

        private Employee? _selectedEmployee;

        private string Title = "Employee Overview";

        protected override void OnInitialized()
        {
            Employees = MockDataService.Employees;
        }

        public void ShowQuickViewPopup(Employee selectedEmployee)
        {
            _selectedEmployee = selectedEmployee;
        }
    }
}
