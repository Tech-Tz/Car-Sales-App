using CarSales.UI.Events;
using CarSales.UI.Views.Interfaces;

namespace CarSales.UI.Views
{
    public partial class LoginView : BaseView, ILoginView
    {
        public LoginView() => InitializeComponent();

        public Action<EmployeeCredentialInputEvent> OnLogin { get; set; }
        public Action<EmployeeRegisterEvent> OnRegister { get; set; }

        private void btnLogin_Click(object sender, EventArgs e) 
            => OnLogin?.Invoke(new EmployeeCredentialInputEvent(txtUsername.Text, txtPassword.Text));

        private void btnRegister_Click(object sender, EventArgs e)
            => OnRegister?.Invoke(new EmployeeRegisterEvent(txtUsername.Text, txtPassword.Text, txtName.Text));
    }
}