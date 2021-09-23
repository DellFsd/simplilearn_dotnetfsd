
namespace Phase1Section4._7c
{
    class DoubleLinkedList
    {
        public Node Root { get; private set; }
       
        public int Length { get; private set; }

        public Node Current { get; private set; }

        public Node Next
        { 
            get { return Current.Next; }
        }

        public Node Previous
        {
            get { return Current.Prev; }
        }

        public void Add(Node node)
        {
            if (Root == null)
            {
                Root = node;
                Length = 1;
                Current = node;
                Root.Prev = null;
            }
            else
            {
                Current.Next = node;
                node.Prev = Current;
                Current = node;
                Length++;
            }
        }

        public Node MoveRoot()
        {
            Node ret = Root;
            if (ret != null)
                Current = ret;
            return ret;
        }
        public Node MoveNext()
        {
            Node ret = Next;
            if (ret != null)
                Current = ret;
            return ret;
        }

        public Node MovePrevious()
        {
            Node ret = Previous;
            if (ret != null)
                Current = ret;
            return ret;
        }
    }
}
