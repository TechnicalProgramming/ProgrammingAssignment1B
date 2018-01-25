using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Assignment2StudentPredicate
{

    public class PredicateCalculator : BaseCalculator
    {
        /// <summary>
        /// 
        /// </summary>
        public PredicateCalculator() { }
        public override float CalculatePredicate(int practicalTest, int termTest1, int termTest2, int additionalTest, int projectTest)
        {
            return  (practicalTest * TestWeights.Practical) +
                (termTest1 * TestWeights.Term1) +
                (termTest2 * TestWeights.Term2) +
                (additionalTest * TestWeights.Additional) +
                (projectTest * TestWeights.Project);
            // return predicateResult;
        }

        public override float CalculatePredicateNeeded(float predicate)
        {
            return 100f - predicate;
        }
    }
}
