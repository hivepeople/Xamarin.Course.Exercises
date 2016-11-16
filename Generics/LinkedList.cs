using System.Text;

namespace Generics
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
            var result = new StringBuilder();
            result.Append("[");

            var node = head;
            while (node != null)
            {
                result.Append(node.Item.ToString());
                result.Append(", ");

                node = node.Next;
            }

            result.Append("]");
            return result.ToString();
        }
    }
}
