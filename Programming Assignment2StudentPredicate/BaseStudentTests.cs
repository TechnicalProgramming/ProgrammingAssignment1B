using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Assignment2StudentPredicate
{
    /// <summary>
    /// Base class for all student tests
    /// </summary>
    abstract class BaseStudentTests
    {
        #region Fields

        protected int practicalTest = 0;
        protected int termTest1 = 0;
        protected int termTest2 = 0;
        protected int additionalTest = 0;
        protected int projectTest = 0;
        protected float predicateResult = 0f;
        protected float predicateNeeded = 0f;

        #endregion

        #region Properties
        /// <summary>
        /// Practical test marks
        /// </summary>
        public abstract int PracticalTest { get; }
        /// <summary>
        /// Term test 1 marks
        /// </summary>
        public abstract int TermTest1 { get; }
        /// <summary>
        /// Term test 2 marks
        /// </summary>
        public abstract int TermTest2 { get; }
        /// <summary>
        /// Additional test marks
        /// </summary>
        public abstract int AdditionalTest { get; }
        /// <summary>
        /// Project test marks
        /// </summary>
        public abstract int ProjectTest { get; }
        /// <summary>
        /// Predicate marks
        /// </summary>
        public abstract float PredicateResults { get; }
        /// <summary>
        /// Predicate needed 
        /// </summary>
        public abstract float PredicateNeeded { get; }

        #endregion
    }
}
