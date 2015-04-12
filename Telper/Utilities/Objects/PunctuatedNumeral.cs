using System;
using System.Collections.Generic;

namespace Telper.Utilities.Objects
{
    public class PunctuatedNumeral
    {
        #region Private Members

        private char separator;
        private int[] subdividions;
        private string latestIt;
        private bool needsUp;

        #endregion

        #region Public Members

        public int CarryOverThreshhold;

        #endregion

        /// <summary>
        /// Creates a blank PunctuatedNumeral object
        /// </summary>
        public PunctuatedNumeral()
        {
            needsUp = true;
        }
        /// <summary>
        /// Creates a PunctuatedNumeral object with specified parameters
        /// </summary>
        /// <param name="separator">Sets the character used to separate subdividions of the numeral</param>
        /// <param name="subs">Array of integers that respectivly set the subviviosins of each numeral</param>
        public PunctuatedNumeral(char separator, int[] subs)
        {
            this.separator = separator;
            this.subdividions = subs;

            needsUp = true;
        }

        /// <summary>
        /// Formats and returns this PunctuatedNumeral
        /// </summary>
        /// <returns>Returns a properly formated PunctuatedNumeral</returns>
        public override string ToString()
        {
            if (needsUp)
            {
                string value = "";
                for (int i = 0; i < subdividions.Length; i++)
                {
                    value += new Func<char, string>(str => (subdividions[i] + "" + str))(separator);
                }
                value = value.Remove(value.Length - 1, 1);
                latestIt = value;
                needsUp = false;

                return value;
            }
            return latestIt;
        }
    }
}
