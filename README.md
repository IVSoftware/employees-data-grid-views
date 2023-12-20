## Employees Data Grid View

The `DataTable` adds an unnecessary layer of complexity. Just use a `BindingList<User>` instead. 

**Employee Form**

Override the `Load` event to set the binding list and format the `DataGridView`.

###### Load the json file

```csharp
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
```

After loading, it looks like this:

[Placeholder]

___

**Add Employee Entry Form***

The `AddEmployeeForm` class doesn't need to know anything about the `User` class. It simply contains entry textboxes that are mapped to public property getters.

```
public partial class AddEmployeeForm : Form
{
    public AddEmployeeForm()
    {
        InitializeComponent();
        StartPosition = FormStartPosition.CenterParent;
        buttonCancel.Click += (sender, e) => DialogResult = DialogResult.Cancel;
        buttonOK.Click += (sender, e) => DialogResult = DialogResult.OK;
        maskedTextBoxAge.Mask = "00";
        maskedTextBoxSalary.Mask = "000,000";
    }
    public string FirstName => textBoxName.Text;
    public string Surname => textBoxSurname.Text;
    public int Age => int.TryParse(maskedTextBoxAge.Text, out var id) ? id : -1;
    public decimal Salary =>  
        decimal
        .TryParse(maskedTextBoxSalary.Text.Replace(",", string.Empty), out var id) ? id : -1;
    public string? Position => textBoxPosition.Text;
}
```

___

**Add Employee**

When the Add button is clicked in the `Employee` form, show the dialog and if the operation has not been canceled then go ahead and make a user and add it to the data source.

```csharp
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
```

___

**EmployeeForm Constructor


```csharp
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
    .
    .
    .
}
```