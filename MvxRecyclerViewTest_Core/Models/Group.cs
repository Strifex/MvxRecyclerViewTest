using MvvmCross.Core.ViewModels;
using System.Collections.ObjectModel;

namespace MvxRecyclerViewTest_Core.Models
{
    public class Group : MvxNotifyPropertyChanged
    {
        public string Name { get; set; }

        private ObservableCollection<User> users;
        public ObservableCollection<User> Users
        {
            get
            {
                return users;
            }
            set
            {
                users = value;
                RaisePropertyChanged(nameof(Users));
            }
        }

        public MvxCommand AddUserCommand
        {
            get
            {
                return new MvxCommand(AddUser);
            }
        }

        public MvxCommand<User> RemoveUserCommand
        {
            get
            {
                return new MvxCommand<User>(RemoveUser);
            }
        }

        public Group()
        {
            Users = new ObservableCollection<User>();
        }

        public void AddUser()
        {
            User user = new User();
            user.Id = Users.Count;
            user.Name = "Random" + user.Id;
            Users.Add(user);
        }

        public void RemoveUser(User user)
        {
            Users.Remove(user);
        }
    }
}
