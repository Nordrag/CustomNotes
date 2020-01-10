using MaterialDesignThemes.Wpf.Transitions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Input;

namespace CustomNotes
{
    public class RegisterViewModel
    {
        public UserModel User { get; set; } = new UserModel();
		private Services Services = new Services();

		private ICommand mRegisterCommand;

		public ICommand RegisterCommand
		{
			get
			{
				if (mRegisterCommand == null)
				{
					mRegisterCommand = new RelayCommand(r => RegUser());
				}
				return mRegisterCommand;
			}
			
		}		

		private void RegUser()
		{
			if (User.Password != User.RepeatPassword)
			{
				MessageBox.Show("nem egyezik meg a jelszó & az ismétlés");
			}
			else if (Services.AccountService.CheckIfExist(User.Username))
			{
				MessageBox.Show("Ezen a néven már regelt valaki");
			}
			else
			{
				Services.AccountService.RegUser(new Users 
				{
					Username = User.Username,
					Password = User.Password
				});

				ICommand backToLogin = Transitioner.MovePreviousCommand;
				backToLogin.Execute(Transitioner.MovePreviousCommand);
			}
		}
	}
}
