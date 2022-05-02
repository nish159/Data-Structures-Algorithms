using LinkedList;

Node firstNode = new Node();
firstNode.value = 1;

Node secondNode = new Node();
secondNode.value = 2;

Node thirdNode = new Node();
thirdNode.value = 3;

firstNode.next = secondNode;
secondNode.next = thirdNode;
thirdNode.next = null;

PrintList(firstNode);

void PrintList(Node head)
{
    Node? currentNode = head;
    while(currentNode != null)
    {
        Console.WriteLine(currentNode.value);
        currentNode = currentNode.next;
    }
}

namespace LinkedList
{
    public class Node
    {
        public int value { get; set; }

        public Node? next { get; set; }
    }
}
