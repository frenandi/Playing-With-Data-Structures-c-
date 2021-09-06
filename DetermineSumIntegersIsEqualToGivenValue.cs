using System.Collections.Generic;

namespace DataStructures
{
    public class DetermineSumIntegersIsEqualToGivenValue
    {
        public bool IsTheSumEqual(int[] inputArray, int tarjetSum)
        {
            var hash = new HashSet<int>();
            var list = new List<int>();
            
            foreach(var i in inputArray)
            {
                if (list.Contains(tarjetSum - i)){
                    return true;
                }

                list.Add(i);
            }
            return false;
        }
    }
}
