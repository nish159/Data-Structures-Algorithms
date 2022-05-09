using LinkedListNamespace;
using System.Diagnostics.Tracing;

LinkedList list = new LinkedList();

// Print the list when it is empty
Console.WriteLine(list.ToString());

// Add a value to end of the list
list.AddLast(3);
Console.WriteLine(list.ToStringFirst());

// Add another value to the end of the list
list.AddFist(2);
Console.WriteLine(list.ToStringFirst());

list.AddFist(1);
Console.WriteLine(list.ToStringFirst());


namespace LinkedListNamespace
{
    public class Node
    {
        public int value { get; set; }

        public Node? next { get; set; }

        public Node? previous { get; set; }
    }

    public class LinkedList
    {
        /// <summary>
        /// The first node in the list
        /// </summary>
        private Node? _head;

        /// <summary>
        /// The last node in the list
        /// </summary>
        private Node? _tail;

        /// <summary>
        /// Constructs an empty list
        /// </summary>
        public LinkedList()
        {
            _head = null;
            _tail = null;
        }

        /// <summary>
        /// Adds a node containing the specified value at the start of the list
        /// </summary>
        /// <param name="value">The value to add to the start of the liist</param>
        /// <returns>The new <see cref="Node"/> containing the value</returns>
        public Node? AddFist(int value)
        {
            // Create the new node we want to add to the list
            Node? newNode = new Node();
            newNode.value = value;  // assign the value to the new node
            newNode.previous = _head; // The new node is going to the beginning of the list. The last node should always point to null.

            // We need to think aobut 3 scenarios
            // 1. When the list is empty
            //      -> _tail = null and _head = null
            // 2. When there is one node in the list
            //      -> there is only one node in the list so _tail and _head are the same
            // 3. When there is more than one node in the list
            //      -> _head is at the beginning of the list and _tail is at the end of the list. _head != _tail

            if (_tail == null /* 1. The list is empty*/)
            {
                _tail = newNode;
                _head = newNode;
            }
            else if (_tail == _head /* 2. There is one node in the list*/ )
            {
                _head.previous = newNode; // Linking the new node to the list.
                _head = newNode; // The head is always supposed to be at the beginning    of the list.
            }
            else /* 3. The list contains more than one node -> tail != head*/
            {
                _head.next = newNode; // Linking the new node to the list
                _head = newNode; // The head is always supposed to be at the beginning of the list.
            }

            return newNode;

        }

        /// <summary>
        /// Adds a node containing the specified value at the end of the list
        /// </summary>
        /// <param name="value">The value to add at the end of the list</param>
        /// <returns>The new <see cref="Node"/> containing the value</returns>
        public Node? AddLast(int value)
        {
            // Create the new node we want to add to the list
            Node? newNode = new Node();
            newNode.value = value;  // assign the value to the new node
            newNode.next = null; // The new node is going to the end of the list. The last node should always point to null.

            // We need to think aobut 3 scenarios
            // 1. When the list is empty
            //      -> _head = null and _tail = null
            // 2. When there is one node in the list
            //      -> there is only one node in the list so _head and _tail are the same
            // 3. When there is more than one node in the list
            //      -> _head is at the beginning of the list and _tail is at the end of the list. _head != _tail

            if (_head == null /* 1. The list is empty*/)
            {
                _head = newNode;
                _tail = newNode;
            }
            else if (_head == _tail /* 2. There is one node in the list*/ )
            {
                _tail.next = newNode; // Linking the new node to the list.
                _tail = newNode; // The tail is always supposed to be at the end of the list.
            }
            else /* 3. The list contains more than one node -> head != tail*/
            {
                _tail.next = newNode; // Linking the new node to the list
                _tail = newNode; // The tail is always supposed to be at the end of the list.
            }

            return newNode;
        }

        /// <summary>
        /// Returns a string that contains all the values in the list, seperated by a comma
        /// </summary>
        /// <returns>A string containing all the values in the list</returns>
        public string ToStringLast()
        {
            // We need to think aobut 3 scenarios
            // 1. When the list is empty
            //      -> _head = null and _tail = null
            // 2. When there is one node in the list
            //      -> there is only one node in the list so _head and _tail are the same
            // 3. When there is more than one node in the list
            //      -> _head is at the beginning of the list and _tail is at the end of the list. _head != _tail

            if (_head == null /* 1. The list is empty*/ )
            {
                // Return an empty string
                return "";
            }
            if (_head == _tail /* 2. The list contains one node */)
            {
                // Return the value in that node as a string
                return _head.value.ToString();
            }

            /* 3. There are more than one node in the list */
            string str = "";
            // We will use currentNode to itereate through the list.
            // currentNode will be the node that should be "printed" at each time.
            Node? currentNode = _head; // currentNode starts at the head since the head contains the first element to be "printed"
            while (currentNode != _tail)
            {
                // Append the value in the current node to the string
                str = str + currentNode.value.ToString() + ", ";

                // Move the current node to the next node
                currentNode = currentNode.next;
            }

            // Append the value in the tail to the end.
            // We don't add a comma after the value in the tail because we don't want a "trailing comma" at the end.
            str = str + _tail.value.ToString();

            return str;
        }

        public string ToStringFirst()
        {
            // We need to think aobut 3 scenarios
            // 1. When the list is empty
            //      -> _head = null and _tail = null
            // 2. When there is one node in the list
            //      -> there is only one node in the list so _head and _tail are the same
            // 3. When there is more than one node in the list
            //      -> _head is at the beginning of the list and _tail is at the end of the list. _head != _tail

            if (_tail == null /* 1. The list is empty*/ )
            {
                // Return an empty string
                return "";
            }
            if (_tail == _head /* 2. The list contains one node */)
            {
                // Return the value in that node as a string
                return _tail.value.ToString();
            }

            /* 3. There are more than one node in the list */
            string str = "";
            // We will use currentNode to itereate through the list.
            // currentNode will be the node that should be "printed" at each time.
            Node? currentNode = _head; // currentNode starts at the head since the head contains the first element to be "printed"
            while (currentNode != _tail)
            {
                // Append the value in the current node to the string
                str = str + currentNode.value.ToString() + ", ";

                // Move the current node to the next node
                currentNode = currentNode.previous;
            }

            // Append the value in the head to the beginning.
            // We don't add a comma before the value in the head because we don't want a "trailing comma" at the beginning.
            str = str + _tail.value.ToString();

            return str;
        }
    }

}
