using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace HackatonProject.Models
{
    public class User
    {
        private int _id;
        private string _name;
        private string _phone;
        private string _email;
        private string _password;

        public event PropertyChangedEventHandler PropertyChanged;

        public User(int id, string name, string phone, string email, string password)
        {
            Id = id;
            Name = name;
            Phone = phone;
            Email = email;
            Password = password;
        }

        public User() { }

        public int Id
        {
            get => _id;
            set
            {
                _id = value;
                InvokePropertyChanged(nameof(Id));
            }
        }

        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                InvokePropertyChanged(nameof(Name));
            }
        }

        public string Phone
        {
            get => _phone;
            set
            {
                _phone = value;
                InvokePropertyChanged(nameof(Phone));
            }
        }

        public string Email
        {
            get => _email;
            set
            {
                _email = value;
                InvokePropertyChanged(nameof(Email));
            }
        }

        public string Password
        {
            get => _password;
            set
            {
                _password = value;
                InvokePropertyChanged(nameof(Password));
            }
        }

        public void SetValues(User user)
        {
            Id = user.Id;
            Name = user.Name;
            Phone = user.Phone;
            Email = user.Email;
            Password = user.Password;
        }

        private void InvokePropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(name, new PropertyChangedEventArgs(name));
        }
    }
}