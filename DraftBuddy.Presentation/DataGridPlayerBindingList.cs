using System.Collections.Generic;
using DraftBuddy.Common.Interfaces;

namespace DraftBuddy.Presentation
{
    public class DataGridPlayerBindingList : BaseBindingList<IPlayer>
    {
        public DataGridPlayerBindingList(IEnumerable<IPlayer> players)
        {
            foreach (IPlayer player in players)
            {
                Add(player);
            }
        }
    }
}