using System.Collections.Generic;

namespace Battlefield.Data
{
    public class BattlefieldGameplayStartData
    {
        public List<TowerId> AvailableTowers;

        public BattlefieldGameplayStartData(List<TowerId> availableTowers)
        {
            AvailableTowers = availableTowers;
        }
    }
}
