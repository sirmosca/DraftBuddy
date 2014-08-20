using System;
using System.Collections;
using System.Reflection;

namespace DraftBuddy.Presentation
{
    /// <summary>
    /// This class is used to compare any 
    /// type(property) of a class.
    /// This class automatically fetches the 
    /// type of the property and compares.
    /// </summary>
    /// Borrowed from: http://www.codeproject.com/KB/recipes/sortablecustomclass.aspx
    public sealed class GenericComparer : IComparer
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GenericComparer"/> class.
        /// </summary>
        /// <param name="objectType">Type of the object.</param>
        /// <param name="sortcolumn">The _Sortcolumn.</param>
        public GenericComparer(Type objectType, string sortcolumn)
        {
            SortingOrder = 0;
            ObjectType = objectType;
            SortColumn = sortcolumn;
        }

        /// <summary>
        /// Type of the object to be compared.
        /// </summary>
        private Type ObjectType { get; set; }

        /// <summary>
        /// Column(public property of the class) to be sorted.
        /// </summary>
        private string SortColumn { get; set; }

        /// <summary>
        /// Sorting order.
        /// </summary>
        public SortDirection SortingOrder { private get; set; }

        /// <summary>
        /// Compare interface implementation
        /// </summary>
        /// <param name="x">Object 1</param>
        /// <param name="y">Object 2</param>
        /// <returns>Result of comparison</returns>
        public int Compare(object x, object y)
        {
            //Dynamically get the protery info 
            //based on the protery name
            PropertyInfo propertyInfo = ObjectType.GetProperty(SortColumn);

            //Get the value of the instance
            IComparable obj1 = (IComparable) propertyInfo.GetValue(x, null);
            IComparable obj2 = (IComparable) propertyInfo.GetValue(y, null);

            //Compare based on the sorting order.
            if (SortingOrder == SortDirection.Ascending)
            {
                return (obj1.CompareTo(obj2));
            }

            return (obj2.CompareTo(obj1));
        }
    }
}