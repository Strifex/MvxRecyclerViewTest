﻿using MvvmCross.Core.ViewModels;
using MvxRecyclerViewTest_Core.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace MvxRecyclerViewTest_Core.ViewModels
{
    public class FirstViewModel : MvxViewModel
    {
        public ObservableCollection<Group> Groups { get; set; }

        public MvxCommand RefreshGroupsCommand
        {
            get
            {
                return new MvxCommand(RefreshGroups);
            }
        }

        public FirstViewModel()
        {
            Groups = new ObservableCollection<Group>();

            List<Group> newGroups = CreateMockData();
            foreach (Group group in newGroups)
            {
                Groups.Add(group);
            }
        }

        private List<Group> CreateMockData()
        {
            List<Group> groups = new List<Group>();

            Group group1 = new Group();
            group1.Name = "Group 1";
            groups.Add(group1);

            User user1 = new User();
            user1.Id = 1;
            user1.Name = "Rob";
            group1.Users.Add(user1);

            User user2 = new User();
            user2.Id = 2;
            user2.Name = "Tim";
            group1.Users.Add(user2);

            Group group2 = new Group();
            group2.Name = "Group 2";
            groups.Add(group2);

            User user3 = new User();
            user3.Id = 3;
            user3.Name = "John";
            group2.Users.Add(user3);

            User user4 = new User();
            user4.Id = 4;
            user4.Name = "Eric";
            group2.Users.Add(user4);

            User user5 = new User();
            user5.Id = 5;
            user5.Name = "Sam";
            group2.Users.Add(user5);

            return groups;
        }

        public void RefreshGroups()
        {
            //Doesn't Work
            /*Groups.Clear();

            List<Group> newGroups = CreateMockData();
            foreach (Group newGroup in newGroups)
            {
                Groups.Add(newGroup);
            }*/

            //Works
            List<Group> newGroups = CreateMockData();
            foreach (Group newGroup in newGroups)
            {
                bool groupExists = false;

                foreach (Group group in Groups)
                {
                    //Check if group exists in newGroups list
                    if (group.Name == newGroup.Name)
                    {
                        groupExists = true;

                        //Set Group properties
                        group.Users.Clear();
                        group.Users = newGroup.Users;

                        break;
                    }
                }

                if (!groupExists)
                {
                    Groups.Add(newGroup);
                }
            }
        }
    }
}
