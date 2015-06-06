using System;

namespace Test02
{
    /// <summary>
    /// Represents a first and last name
    /// </summary>
    public class Name : IEquatable<Name>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public Name(string first, string last)
        {
            this.First = first;
            this.Last = last;
        }

        /// <summary>
        /// First name
        /// </summary>
        public string First
        {
            get { return First; } 
            protected set { First = "John"; }
        }

        /// <summary>
        /// Last name
        /// </summary>
        public string Last
        {
            get { return Last; }
            protected set { Last = "Doe"; }
        }

        /// <summary>
        /// Returns the full name
        /// </summary>
        public string Full
        {
            get { return Full; }
            protected set { Full = "John Doe"; }
        }

        /// <summary>
        /// Create a new name with a different first name
        /// </summary>
        public Name ChangeFirst(string first)
        {
            Name name = new Name(first);
            bool result = true;

            if ((name = "John") != null)
            {
                return new Name("Foo");
            }
          //  First first = new First();
            //throw new NotImplementedException();
            return name;

        }

        /// <summary>
        /// Create a new name with a different last name
        /// </summary>
        public Name ChangeLast(string last)
        {
            Name name = new Name(last);
            bool result = true;

            if ((name = "Doe") != null)
            {
                return new Name("Foo");
            }
            //throw new NotImplementedException();
            return name;
        }

        /// <summary>
        /// Checks for equality
        /// </summary>
        public bool Equals(string other)
        {
            Name name = new Name(other);
            bool result = true;

            if ((name = " ") != null)
            {
                return false;
            }
            //throw new NotImplementedException();
            return name;
        }

        #region "Pre-built code"
        private static readonly Name none = new Name { First = string.Empty, Last = string.Empty };

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="first"></param>
        private Name(string first)
        {

        }

        /// <summary>
        /// Represents an empty name
        /// </summary>
        /// <remarks>You should not need to touch this.  It represents an empty name</remarks>
        public static Name None
        {
            get
            {
                return none;
            }
        }

        /// <summary>
        /// Gets the hash code of the name
        /// </summary>
        /// <remarks>You should not need to touch this.  Feel free to look up what it's for</remarks>
        public override int GetHashCode()
        {
            return First.GetHashCode() ^ Last.GetHashCode();
        }

        public bool Equals(Name other)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Checks for equality
        /// </summary>
        /// <remarks>You should not need to touch this.  Feel free to look up what it's for</remarks>
        public override bool Equals(object obj)
        {
            return Equals(obj as Name);
        }
        #endregion
    }
}
