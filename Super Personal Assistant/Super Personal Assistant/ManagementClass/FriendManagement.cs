using Super_Personal_Assistant.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Super_Personal_Assistant.ManagementClass
{
    public class FriendManagement
    {
        private List<Friend> _friend = new List<Friend>();

        public FriendManagement()
        {
            _friend.Clear();
        }

        public void addFriend(Friend friend)
        {
            _friend.Add(friend);
        }

        public void deleteFriend() {

        }

    }
}
