using System.Text;

namespace DelegatesAndLambdas
{
    public class LinkedList<TItem>
    {
        private class Node
        {
            private TItem item;
            private Node next;

            public Node(TItem item, Node next)
            {
                this.item = item;
                this.next = next;
            }

            public TItem Item { get { return item; } }
            public Node Next { get { return next; } }
        }

        private Node head;

        public void AddToFront(TItem item)
        {
            var newHead = new Node(item, head);
            this.head = newHead;
        }

        public override string ToString()
        {
            // We can reimplement the old ToString to use
            // our new fancy delegate-based ToString
            return ToString(item => item.ToString());
        }

        public string ToString(Format<TItem> formatter)
        {
            var result = new StringBuilder();
            result.Append("[");

            var node = head;
            while (node != null)
            {
                // Here is where the magic happens: call the
                // formatter we received as input in order
                // to convert each item to a string
                string itemAsString = formatter(node.Item);

                result.Append(itemAsString);
                result.Append(", ");

                node = node.Next;
            }

            result.Append("]");
            return result.ToString();
        }
    }

    // Note that we use generics here
    public delegate string Format<T>(T item);
}
