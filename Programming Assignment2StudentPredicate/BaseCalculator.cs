using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Assignment2StudentPredicate
{
    /// <summary>
    /// 
    /// </summary>
    abstract class BaseCalculator
    {
        #region Fields

        #endregion

        #region
        /// <summary>
        /// Abstract method to calculate student predicate
        /// </summary>
        /// <param name="practicalTest"></param>
        /// <param name="termTest1"></param>
        /// <param name="termTest2"></param>
        /// <param name="additionalTest"></param>
        /// <param name="projectTest"></param>
        /// <returns></returns>
        public abstract float CalculatePredicate(int practicalTest, int termTest1, int termTest2, int additionalTest, int projectTest);
        /// <summary>
        /// Abstract method to calculate the needed 
        /// </summary>
        /// <param name="practicalTest"></param>
        /// <param name="termTest1"></param>
        /// <param name="termTest2"></param>
        /// <param name="additionalTest"></param>
        /// <param name="projectTest"></param>
        /// <returns></returns>
        public abstract float CalculatePredicateNeeded(int practicalTest, int termTest1, int termTest2, int additionalTest, int projectTest);
        
        #endregion
    }
}
