using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;

namespace DraftBuddy.Presentation
{
    public class BaseBindingList<T> : BindingList<T>
    {
        private bool _IsSortedValue;
        private ListSortDirection _SortDirectionValue;
        private PropertyDescriptor _SortPropertyValue;

        /// <summary>
        /// By default this property is set to false
        /// Set this property to true to indicate searching is implemented on list.
        /// </summary>

        protected override bool SupportsSearchingCore
        {
            get { return true; }
        }

        protected override PropertyDescriptor SortPropertyCore
        {
            get { return _SortPropertyValue; }
        }

        protected override ListSortDirection SortDirectionCore
        {
            get { return _SortDirectionValue; }
        }

        protected override bool SupportsSortingCore
        {
            get { return true; }
        }

        protected override bool IsSortedCore
        {
            get { return _IsSortedValue; }
        }

        protected override void ApplySortCore(PropertyDescriptor prop, ListSortDirection direction)
        {
            
            // Get list to sort
            List<T> items = Items as List<T>;

            // Apply and set the sort
            if (items != null)
            {
                PropertyComparer<T> pc = new PropertyComparer<T>(prop, direction);
                items.Sort(pc);
                _IsSortedValue = true;

                _SortPropertyValue = prop;
                _SortDirectionValue = direction;

                // Let bound controls know they should refresh their views
                OnListChanged(new ListChangedEventArgs(ListChangedType.Reset, -1));
            }
            else
            {
                _IsSortedValue = false;
            }
        }

        public void ApplySort(string property, ListSortDirection direction)
        {
            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(T));
            PropertyDescriptor prop = properties.Find(property, true);
            if (prop != null)
            {
                ApplySortCore(prop, direction);
            }
            else
            {
                throw new NotSupportedException(string.Format("Cannot sort by {0}. This{1} does not exist.", prop.Name, prop.Name));
            }
        }
    }
}