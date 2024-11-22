using System;
using System.Collections.Generic;

namespace CoinRepresentation
{
    /// <summary>
    ///This class determines how many unique methods there are to use coins to represent a particular total.
    /// For effective computing, it makes use of recursion along with memoization.
    /// </summary>
    public class CoinRepresentation
    {
        // A cache to hold previously calculated outcomes for subproblems
        private static Dictionary<long, long> _cache = new Dictionary<long, long>();

        /// <summary>
        /// Determines how many ways there are to depict a given total.
        /// </summary>
        /// <param name="sum">The target sum to represent.</param>
        /// <returns>how many different methods there are to express the amount.</returns>
        public static long Solve(long sum)
        {
            // Base cases:
            if (sum < 0) return 0; 
            if (sum == 0) return 1;

            // Verify if the outcome has previously been cached.
            if (!_cache.ContainsKey(sum))
            {
                if (sum % 2 == 0)
                {
                    
                    _cache.Add(sum, Solve(sum / 2) + Solve(sum / 2 - 1));
                }
                else
                {
                    // If sum is odd, reduce it and solve for (sum - 1) / 2
                    _cache.Add(sum, Solve((sum - 1) / 2));
                }
            }

            // Provide the result that was cached.
            return _cache[sum];
        }
    }
}

