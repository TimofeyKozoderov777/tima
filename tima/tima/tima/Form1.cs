namespace tima
{
    public partial class Form1 : Form
    {

        private decimal? _userId = null;

        private string _roleName = "No authorized";

        public Form1()
        {
            InitializeComponent();
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            string login = login_textBox.Text;

            string password = password_textBox.Text;


            try

            {

                using (var dbContext = new TimaContext())

                {

                    var userData = dbContext.Users

                    .FirstOrDefault(user => user.Password == password && user.Login == login);

                    if (userData != null)

                    _userId = userData.Id;


                    var roleId = dbContext.Users

                    .First(user => user.Id == _userId).IdRole;



                    _roleName = dbContext.Roles

                    .First(role => role.Id == roleId).RoleName;


                }
                MessageBox.Show("B� ����� ��� " + _roleName);
            }

            catch (Exception)

            {

                MessageBox.Show("�������� ����� ��� ������");
            }
        }
    }
}