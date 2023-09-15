namespace Section8
{
    class Debugging {
        public List<string> GetPartyFriends(List<string> list, int count) {
            var partyFriends = new List<string>();

            while(partyFriends.Count < count) {
                var currentFriend = GetPartyFriend(list);
                partyFriends.Add(currentFriend);
                list.Remove(currentFriend);
            }

            return partyFriends;
        }

        private string GetPartyFriend(List<string> list) {
            string shortestName = list[0];
            for(int i = 0; i < list.Count; i++) {
                if(list[i].Length < shortestName.Length) {
                    shortestName = list[i];
                }
            }

            return shortestName;
        }
    }
}