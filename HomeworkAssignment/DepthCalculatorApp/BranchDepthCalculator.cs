using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkAssignment.DepthCalculatorApp
{
    public class BranchDepthCalculator
    {
        public static int CalculateDepth(Branch b)
        {
            // base case: if the branch has no branches, its depth is 1
            if (b.branches.Count == 0)
            {
                return 1;
            }

            // recursive case: the depth of the branch is the maximum depth of its sub-branches plus 1
            int maxDepth = 0;

            // loop through each sub-branch and calculate its depth
            foreach (Branch subBranch in b.branches)
            {
                // calculate the depth of the sub-branch
                int depth = CalculateDepth(subBranch);

                // if the depth of the sub-branch is greater than the current max depth, update the max depth
                if (depth > maxDepth)
                {
                    maxDepth = depth;
                }
            }
            // return the max depth of the sub-branches plus 1
            return maxDepth + 1;
        }
    }
}
