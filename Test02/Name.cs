using System;
using Xunit.Sdk;

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
            if (string.IsNullOrEmpty(first))
            {
                throw new ArgumentException(); //throw stop sexecution so 'else' is not necessary
            }

            this.First = first; //this. reduces ambiguity
            this.Last = last; //C# looks for closest scope to method argument

        }

        /// <summary>
        /// First name
        /// </summary>
        public string First {get; protected set; }
        //{
        //    get { return First; }
        //    protected set { First = "John"; }
        //}

        /// <summary>
        /// Last name
        /// </summary>
        public string Last { get; protected set; }
        

            
            //get { return Last; }
            //protected set { Last = "Doe"; }
        

        /// <summary>
        /// Returns the full name
        /// </summary>
        public string Full
        {

            get
            {
                if (!string.IsNullOrEmpty(First) && 
                    !string.IsNullOrEmpty(Last))
                {
                    return First + " " + Last;
                }

                if ( string.IsNullOrEmpty(First))
                {
                    return Last; //if this is successful.. don't need the else below
                }
                else if (string.IsNullOrEmpty(Last))
                {
                    return First;
                }
                return string.Empty;
            }
            //get { return Full; }
            //protected set { Full = "John Doe"; }
        }

        /// <summary>
        /// Create a new name with a different first name
        /// </summary>
        public Name ChangeFirst(string first)
        {
            if (string.IsNullOrEmpty(first))
            {
                throw new ArgumentException();
            }
            return new Name { First = first, Last = Last }; //andrews revisions

            //Name name = new Name(first); //my version
            //bool result = true;

            //if ((name = "John") != null)
            //{
            //    return new Name("Foo");
            //}
            ////  First first = new First();
            ////throw new NotImplementedException();
            //return name;

        }

        /// <summary>
        /// Create a new name with a different last name
        /// </summary>
        public Name ChangeLast(string last)
        {
            if (string.IsNullOrEmpty(last))
            {
                throw new ArgumentException();
            }
            return new Name { First = First, Last = last }; //andrews revisions

            //Name temp = new Name(); //inclass suggestion first
            //temp.First = First;
            //temp.Last = last;
            //return temp;

            //Name name = new Name(last); //my version
            //bool result = true;

            //if ((name = "Doe") != null)
            //{
            //    return new Name("Foo");
            //}
            ////throw new NotImplementedException();
            //return name;
        }

        /// <summary>
        /// Checks for equality
        /// </summary>
        public bool Equals(Name other)
        {

            //Name name = new Name(other);
            //bool result = true;

            if (First == other.First && Last == other.Last) //in class solution
            {
                return true;
            }

            return false;

            //return First == other.First && Last == other.Last;  //Andrews version
            //throw new NotImplementedException();
            //return name;
        }

        #region "Pre-built code"
        private static readonly Name none = new Name { First = string.Empty, Last = string.Empty };

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="first"></param>
        private Name()
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
