using System.Data;

namespace AdoNetDataSetWithoutBDApp
{
    public partial class Form1 : Form
    {
        List<Employee> employees;
        DataSet dataEmployees = new();


        public Form1()
        {
            InitializeComponent();

            employees = new List<Employee>()
            {
                new Employee() { Name = "Bobby", Age = 29, Salary = 89000f },
                new Employee() { Name = "Tommy", Age = 34, Salary = 103000f },
                new Employee() { Name = "Leopold", Age = 41, Salary = 135000f }
            };

            DataTable tableEmplyees = new DataTable("Employees");
            dataEmployees.Tables.Add(tableEmplyees);

            DataColumn columnId= new DataColumn("Id", Type.GetType("System.Int32"));
            columnId.Unique = true;
            columnId.AllowDBNull = false;
            columnId.AutoIncrement = true;
            columnId.AutoIncrementSeed = 1;
            columnId.AutoIncrementStep = 1;

            DataColumn columnName = new DataColumn("Name", Type.GetType("System.String"));
            DataColumn columnAge = new DataColumn("Age", Type.GetType("System.Int32"));
            DataColumn columnSalary = new DataColumn("Salary", Type.GetType("System.Single"));


            tableEmplyees.Columns.AddRange([columnId, columnName, columnAge, columnSalary]);
            tableEmplyees.PrimaryKey = [ columnId ];

            //DataRow row = tableEmplyees.NewRow();

            foreach(var e in employees)
            {
                //var rowEmployee = new object[] { null, e.Name, e.Age, e.Salary };
                //row.ItemArray = rowEmployee;
                tableEmplyees.Rows.Add([null, e.Name, e.Age, e.Salary ]);
            }

            dataGridEmployees.DataSource = tableEmplyees;
        }
    }
}
