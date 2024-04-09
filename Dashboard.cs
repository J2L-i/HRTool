using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using HRTool.Models;
using HRTool.Service;

namespace HRTool
{
    public partial class Dashboard : Form
    {
        private List<IEmployee> employees;
        private List<TimeOffRequest> requests;
        private EmployeeFactory factory;
        public Dashboard()
        {
            InitializeComponent();

            InitRoles();
            InitOffTypeComboBox();

            EmpNameTextBox.ReadOnly = false;
            // create columns and add them to the list
            // Define columns for the ListView
            // Set the view mode of the ListView to Details
            EmployeesListView.View = View.Details;

            // Add columns to the ListView
            EmployeesListView.Columns.Add("ID", 100, HorizontalAlignment.Left);
            EmployeesListView.Columns.Add("Name", 300, HorizontalAlignment.Left);
            EmployeesListView.Columns.Add("Role", 200, HorizontalAlignment.Left);

            OffRequestsListView.View = View.Details;

            // Add columns to the ListView
            OffRequestsListView.Columns.Add("Employee", 180, HorizontalAlignment.Left);
            OffRequestsListView.Columns.Add("Start Date", 120, HorizontalAlignment.Left);
            OffRequestsListView.Columns.Add("End Date", 120, HorizontalAlignment.Left);
            OffRequestsListView.Columns.Add("Off Type", 140, HorizontalAlignment.Left);
            OffRequestsListView.Columns.Add("Status", 100, HorizontalAlignment.Left);

            factory = new EmployeeFactory();
            employees = new List<IEmployee>();
            requests = new List<TimeOffRequest>();
        }

        private void InitRoles()
        {
            // add items to combo box
            RolesComboBox.Items.Add("Worker");
            RolesComboBox.Items.Add("Manager");
            RolesComboBox.Items.Add("Director");
            RolesComboBox.Items.Add("Executive");

            RolesComboBox.SelectedIndex = 0;
        }

        private void InitOffTypeComboBox()
        {
            // add items to combo box
            OffTypeComboBox.Items.Add("Covid");
            OffTypeComboBox.Items.Add("Sickness");
            OffTypeComboBox.Items.Add("Vaccation");
            OffTypeComboBox.Items.Add("Mental Health");

            OffTypeComboBox.SelectedIndex = 0;
        }

        private TimeOffType GetOffType(string type)
        {
            switch (type)
            {
                case "Covid":
                    return TimeOffType.Covid;
                case "Mental Health":
                    return TimeOffType.MentalHealth;
                case "Sickness":
                    return TimeOffType.Sick;
                case "Vaccation":
                    return TimeOffType.Vaccation;
                default:
                    return TimeOffType.Vaccation;
            }
        }


        private void AddEmployeeButton_Click(object sender, EventArgs e)
        {
            string role = RolesComboBox.SelectedItem.ToString();
            IEmployee employee = null;
            int id = employees.Count + 1;

            switch (role)
            {
                case "Worker":
                    employee = factory.CreateEmployee(id, NameTextBox.Text, 3);
                    break;
                case "Manager":
                    employee = factory.CreateEmployee(id, NameTextBox.Text, 2);
                    break;
                case "Director":
                    employee = factory.CreateEmployee(id, NameTextBox.Text, 1);
                    break;
                case "Executive":
                    employee = factory.CreateEmployee(id, NameTextBox.Text, 0);
                    break;
                default:
                    break;
            }
            if (employee != null)
            {
                employees.Add(employee);
                NameTextBox.Text = "";
            }

            UpdateEmployeeTable();
        }

        private void UpdateEmployeeTable()
        {
            EmployeesListView.Items.Clear();
            foreach (IEmployee employee in employees)
            {
                ListViewItem item = new ListViewItem(employee.Id.ToString());
                item.SubItems.Add(employee.Name);

                switch (employee.Level)
                {
                    case 0:
                        item.SubItems.Add("Executive");
                        break;
                    case 1:
                        item.SubItems.Add("Director");
                        break;
                    case 2:
                        item.SubItems.Add("Manager");
                        break;
                    case 3:
                        item.SubItems.Add("Worker");
                        break;
                    default:
                        break;
                }
                EmployeesListView.Items.Add(item);
            }
        }

        private void EmployeeIdTextBox_TextChanged(object sender, EventArgs e)
        {
            var employ = employees.Find(emp => emp.Id == int.Parse(EmployeeIdTextBox.Text));
            if (employ != null)
            {
                EmpNameTextBox.Text = employ.Name;
            }
        }
        private void SetHierarchy()
        {
            for (int i = 0; i < employees.Count; i++)
            {
                for (int j = 0; j < employees.Count; j++)
                {
                    switch (employees[i].Level)
                    {
                        case 0:
                            if (employees[j].Level == 1)
                            {
                                employees[i].Subordinates.Add(employees[j].Subordinates);
                            }
                            break;
                        case 1:
                            if (employees[j].Level == 2)
                            {
                                employees[i].Subordinates.Add(employees[j].Subordinates);
                            }
                            break;
                        case 2:
                            if (employees[j].Level == 3)
                            {
                                employees[i].Subordinates.Add(employees[j].Subordinates);
                            }
                            break;
                        default:
                            break;
                    }
                }
            }


        }

        private void RequestButton_Click(object sender, EventArgs e)
        {
            var employee = employees.Find(emp => emp.Id == int.Parse(EmployeeIdTextBox.Text));
            if (employee != null)
            {
                var type = GetOffType(OffTypeComboBox.SelectedItem.ToString());
                var request = new TimeOffRequest(employee, StartDateTimePicker.Value, EndDateTimePicker.Value, type);
                IEmployee aprv = null;
                switch (employee.Level)
                {
                    case 0:
                        // EXECUTIVES can approve off themselves
                        aprv = employees.Find(emp => emp.Level == 0);
                        if (aprv != null)
                        {
                            request.AddApprover((Executive)aprv);
                        }
                        break;
                    case 1:
                        aprv = employees.Find(emp => emp.Level == 0);
                        if (aprv != null)
                        {
                            request.AddApprover((Executive)aprv);
                        }
                        break;
                    case 2:
                        aprv = employees.Find(emp => emp.Level == 1);
                        if (aprv != null)
                        {
                            request.AddApprover((Director)aprv);
                        }
                        break;
                    case 3:
                        aprv = employees.Find(emp => emp.Level == 2);
                        if (aprv != null)
                        {
                            request.AddApprover((Manager)aprv);
                        }
                        break;
                    default:
                        break;
                }
                requests.Add(request);
                UpdateRequestsTable();

                MessageBox.Show("Time-Off Request for [" + employee.Name + "] is submitted", "Information",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void ScheduleRequests()
        {
            // Create a scheduler and schedule the requests
            var scheduler = new TimeOffRequestScheduler();
            for (int i = 0; i < requests.Count; i++)
            {
                if (requests[i].Employee.Available)
                {
                    scheduler.ScheduleRequest(requests[i]);
                }
            }

            // Wait for all requests to be processed

            while (scheduler.HasNextRequest())
            {

                var result = scheduler.ProcessNextRequest();

                if (result != null)
                {
                    var req = requests.Find(r => r.Employee.Id == result.Employee.Id);
                    if (req != null)
                    {
                        Console.WriteLine(result.Employee.Name + "->" + result.Employee.Available);
                        int index = requests.IndexOf(req);
                        requests[index] = result;
                        MessageBox.Show("Time-Off Request for [" + result.Employee.Name + "] is processed", "Information",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }

            }
            UpdateRequestsTable();
        }

        private void UpdateRequestsTable()
        {
            OffRequestsListView.Items.Clear();
            foreach (var request in requests)
            {
                ListViewItem item = new ListViewItem(request.Employee.Name);
                item.SubItems.Add(request.StartDate.ToString());
                item.SubItems.Add(request.EndDate.ToString());
                item.SubItems.Add(request.Type.ToString());

                switch (request.Employee.Available)
                {
                    case true:
                        item.SubItems.Add("Pending");
                        break;
                    case false:
                        item.SubItems.Add("Approved");
                        break;
                    default:
                        break;
                }
                OffRequestsListView.Items.Add(item);
            }
        }

        private void ViewHierarchyButton_Click(object sender, EventArgs e)
        {
            SetHierarchy();

            HierarchyTextBox.Clear();
            HierarchyTextBox.ReadOnly = true;
            // sort the employees by level
            var sortedEmployees = employees.OrderBy(emp => emp.Level).ToList();
            if (sortedEmployees.Count > 0)
            {
                HierarchyTextBox.Text = sortedEmployees[0].Subordinates.Display(0);
            }

        }

        private void ProcessRequestsButton_Click(object sender, EventArgs e)
        {
            // Assuming `this` refers to the parent window
            if (requests.Count > 0)
            {
                MessageBox.Show(null, "Each request status will change after being approved\nIf not approved, the status wont change!", "Information",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

                ScheduleRequests();

            }
        }
    }
}
