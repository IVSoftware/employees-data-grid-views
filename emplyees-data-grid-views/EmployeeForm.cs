
using Newtonsoft.Json;
using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Text.Json.Serialization;

namespace KURSACH
{
    public partial class EmployeeForm : Form
    {
        string dataPath { get; } = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "users.json");
        public EmployeeForm()
        {
            InitializeComponent();
            var buttonLocation = new Point(dataGridView.Width - 64, dataGridView.Height - 64);
            Label buttonAdd = new Label
            {
                Size = new Size(60, 60),
                Text = "+",
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font(Font.FontFamily, 14),
                Anchor = AnchorStyles.Bottom | AnchorStyles.Right,
                Location = buttonLocation,
                ForeColor = Color.White,
                BackColor = Color.CornflowerBlue,
            };
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, buttonAdd.Width, buttonAdd.Height);
            buttonAdd.Region = new Region(path);
            dataGridView.Controls.Add(buttonAdd);
            buttonAdd.Click += AddUser;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Users = JsonConvert.DeserializeObject<BindingList<User>>(File.ReadAllText(dataPath));
            dataGridView.AllowUserToAddRows = false; // Another good way to add a User, though!
            dataGridView.RowHeadersVisible = false;
            dataGridView.DataSource = Users;
            foreach (DataGridViewColumn column in dataGridView.Columns) 
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView.Columns[nameof(User.Position)].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        BindingList<User> Users { get; set; }

        private void AddUser(object? sender, EventArgs e)
        {
            using (AddEmployeeForm form = new AddEmployeeForm())
            {
                if (DialogResult.OK == form.ShowDialog(this))
                {
                    User user = new User
                    {
                        ID = Users.Max(_ => _.ID) + 1,
                        Name = form.FirstName,
                        Surname = form.Surname,
                        Age = form.Age,
                        Position = form.Position,
                        Salary = form.Salary,
                    };
                    Users.Add(user);
                    // Save the file
                    // File.WriteAllText(dataPath, JsonConvert.SerializeObject(Users));
                }
            }
        }
    }
}

class User
{
    public int ID { get; set; }
    public string? Name { get; set; } = string.Empty;
    public string? Surname { get; set; } = string.Empty;
    public int Age { get; set; }
    public decimal Salary { get; set; }
    public string? Position { get; set; } = string.Empty;
}
