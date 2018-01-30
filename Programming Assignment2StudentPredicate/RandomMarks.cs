using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Assignment2StudentPredicate
{
    public sealed class RandomMarks : BaseStudentTests
    {
        #region Fields
        // Singleton variables
        private static volatile RandomMarks instance ;
        private static object syncRoot = new object();
        private List<int> goodMarksList = new List<int>();
        private List<int> badMarksList = new List<int>();
        #endregion

        #region Constructor
        /// <summary>
        /// Private constructor
        /// </summary>
        private RandomMarks() { }
        #endregion

        #region Properties
        public static RandomMarks Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                        {
                            instance = new RandomMarks();
                        }
                    }
                }
                return instance;
            }
        }

        #endregion

        #region Methods
        /// <summary>
        /// Generates random good marks
        /// </summary>
        /// <returns></returns>
        public bool GenerateGoodMarks()
        {
            try
            {
                Random goodMarksRondomiser = new Random();
                goodMarksList.Clear();

                for (int i = 0; i < 5; ++i)
                {
                    int goodMark = goodMarksRondomiser.Next(50, 101);
                    goodMarksList.Add(goodMark);
                }
                AddMarks(goodMarksList);
                return true;
            }catch(Exception ex)
            {
                return false;
            }
        }
        /// <summary>
        /// Generates random bad marks
        /// </summary>
        /// <returns></returns>
        public bool GenerateBadMarks()
        {
            try
            {
                Random badMarksRandomiser = new Random();
                badMarksList.Clear();

                for (int i = 0; i < 5; ++i)
                {
                    int badMarks = badMarksRandomiser.Next(0, 50);
                    badMarksList.Add(badMarks);
                }
                AddMarks(badMarksList);
                return true;
            }catch(Exception ex)
            {
                return false;
            }
        }

        public bool AddMarks(List<int> studentMarksList)
        {
            try
            {
                practicalTest = studentMarksList[0];
                termTest1 = studentMarksList[1];
                termTest2 = studentMarksList[2];
                additionalTest = studentMarksList[3];
                projectTest = studentMarksList[4];
                return true;
            }catch(Exception ex)
            {
                return false;
            }
        }
        #endregion
    }
}
