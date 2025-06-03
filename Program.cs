// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
LinkedList<int> linkedList = new LinkedList<int>();
        
            linkedList.AddLast(1);

            Console.WriteLine("Linked List after adding 1:"+ linkedList.Count);
//PrintLinkedList(linkedList);
linkedList.AddFirst(0);
Console.WriteLine("Linked List after adding 0 at the beginning:" + linkedList.Count);
          //  Console.ReadLine();

          Console.WriteLine("First element in the linked list: " + linkedList.First.Value);
linkedList.AddLast(2);
Console.WriteLine("Linked List after adding 2 at the end:" + linkedList.Last.Value);

linkedList.AddLast(4);

linkedList.AddBefore(linkedList.Find(4), 3);

Console.WriteLine("Linked List after adding 3 before 4:" + linkedList.Count);
// console.write the last before element
Console.WriteLine("Last element before 4: " + linkedList.Find(4).Previous.Value);

Console.WriteLine("Linked list contains 3:" + linkedList.Contains(3));

// Remove an element

Console.WriteLine("Count before removing element: " + linkedList.Count);
linkedList.Remove(3);

Console.WriteLine("Count after removing element 3: " + linkedList.Count);

// Remove the first element

Console.WriteLine("Before Removing first element: " + linkedList.First.Value);
linkedList.RemoveFirst();
Console.WriteLine("After Removing first element: " + (linkedList.First != null ? linkedList.First.Value.ToString() : "null"));

// Remove the last element
Console.WriteLine("Before Removing last element: " + linkedList.Last.Value);
linkedList.RemoveLast();
Console.WriteLine("After Removing last element: " + (linkedList.Last != null ? linkedList.Last.Value.ToString() : "null"));