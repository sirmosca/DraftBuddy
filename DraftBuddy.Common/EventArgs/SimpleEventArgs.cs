namespace DraftBuddy.Common.EventArgs
{
    public class SimpleEventArgs<T> : System.EventArgs
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SimpleEventArgs&lt;T&gt;"/> class.
        /// </summary>
        /// <param name="value">The value.</param>
        public SimpleEventArgs(T value)
        {
            Value = value;
        }

        /// <summary>
        /// Gets the value.
        /// </summary>
        /// <value>The value.</value>
        public T Value { get; private set; }
    }
}