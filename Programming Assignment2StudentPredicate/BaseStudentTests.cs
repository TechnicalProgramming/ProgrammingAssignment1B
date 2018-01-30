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
    public abstract class BaseStudentTests
    {
        #region Enum
        #endregion

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
        public virtual int PracticalTest { get {return practicalTest; } set { practicalTest = value; } }
        /// <summary>
        /// Term test 1 marks
        /// </summary>
        public virtual int TermTest1 { get {return termTest1; } set { termTest1 = value; } }
        /// <summary>
        /// Term test 2 marks
        /// </summary>
        public virtual int TermTest2 { get {return termTest2; } set { termTest2 = value; } }
        /// <summary>
        /// Additional test marks
        /// </summary>
        public virtual int AdditionalTest { get {return additionalTest; } set { additionalTest = value; } }
        /// <summary>
        /// Project test marks
        /// </summary>
        public virtual int ProjectTest { get {return projectTest; } set { projectTest = value; } }
        /// <summary>
        /// Predicate marks
        /// </summary>
        public virtual float PredicateResults { get {return predicateResult; } set { predicateResult = value; } }
        /// <summary>
        /// Predicate needed 
        /// </summary>
        public virtual float PredicateNeeded { get {return predicateNeeded; } set { predicateNeeded = value; } }

        #endregion
    }
}
