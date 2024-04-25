using System; // This namespace gains access to generic collection types.

namespace Komodo_DevTeam
{
    public class DevTeam
    {
        // Properties
        public string? TeamName { get; set; }
        public int TeamId { get; set; }
        public List<int> TeamMembers { get; set; } = new List<int>();

        // Constructor with 2 args
        public DevTeam(int teamId, string teamName)
        {
            TeamId = teamId;
            TeamName = teamName;
        }
    }
};
//Add constructor with 2 args