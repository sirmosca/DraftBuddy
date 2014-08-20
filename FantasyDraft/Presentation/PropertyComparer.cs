using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;

namespace DraftBuddy.Presentation
{
    public class PropertyComparer<T> : IComparer<T>
    {
        // The following code contains code implemented by Rockford Lhotka:
        // http://msdn.microsoft.com/library/default.asp?url=/library/en-us/dnadvnet/html/vbnet01272004.asp

        private readonly ListSortDirection _Direction;
        private readonly PropertyDescriptor _Property;

        /// <summary>
        /// Initializes a new instance of the <see cref="PropertyComparer&lt;T&gt;"/> class.
        /// </summary>
        /// <param name="property">The property.</param>
        /// <param name="direction">The direction.</param>
        public PropertyComparer(PropertyDescriptor property, ListSortDirection direction)
        {
            _Property = property;
            _Direction = direction;
        }

        public int Compare(T xWord, T yWord)
        {
            // Get property values
            object xValue = GetPropertyValue(xWord, _Property.Name);
            object yValue = GetPropertyValue(yWord, _Property.Name);

            // Determine sort order
            return _Direction == ListSortDirection.Ascending ? CompareAscending(xValue, yValue) : CompareDescending(xValue, yValue);
        }

        /// <summary>
        /// Equalses the specified x word.
        /// </summary>
        /// <param name="xWord">The x word.</param>
        /// <param name="yWord">The y word.</param>
        /// <returns></returns>
        public bool Equals(T xWord, T yWord)
        {
            return xWord.Equals(yWord);
        }

        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        /// <param name="obj">The obj.</param>
        /// <returns>
        /// A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. 
        /// </returns>
        public int GetHashCode(T obj)
        {
            return obj.GetHashCode();
        }

        // Compare two property values of any type
        /// <summary>
        /// Compares the ascending.
        /// </summary>
        /// <param name="xValue">The x value.</param>
        /// <param name="yValue">The y value.</param>
        /// <returns></returns>
        private static int CompareAscending(object xValue, object yValue)
        {
            int result;

            // If values implement IComparer
            if (xValue is IComparable)
            {
                result = ((IComparable) xValue).CompareTo(yValue);
            }
                // If values don't implement IComparer but are equivalent
            else if (xValue.Equals(yValue))
            {
                result = 0;
            }
                // Values don't implement IComparer and are not equivalent, so compare as string values
            else
            {
                result = xValue.ToString().CompareTo(yValue.ToString());
            }

            // Return result
            return result;
        }

        /// <summary>
        /// Compares the descending.
        /// </summary>
        /// <param name="xValue">The x value.</param>
        /// <param name="yValue">The y value.</param>
        /// <returns></returns>
        private static int CompareDescending(object xValue, object yValue)
        {
            // Return result adjusted for ascending or descending sort order ie
            // multiplied by 1 for ascending or -1 for descending
            return CompareAscending(xValue, yValue) * -1;
        }

        /// <summary>
        /// Gets the property value.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="property">The property.</param>
        /// <returns></returns>
        private static object GetPropertyValue(T value, string property)
        {
            // Get property
            PropertyInfo propertyInfo = value.GetType().GetProperty(property);

            // Return value
            return propertyInfo.GetValue(value, null);
        }
    }
}