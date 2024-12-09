using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DASA_FinalProject_01.Utils;

namespace DASA_FinalProject_01
{
    public class Node
    {
        public Employee Data;
        public Node pNext;

        public Node(Employee data)
        {
            Data = data;
            pNext = null;
        }
        
    }

    public class CircularLinkedList
    {
        public Node pHead;

        public CircularLinkedList()
        {
            pHead = null;
        }
        private Node CreateNode(Employee employee)
        {
            return new Node(employee);
        }
        private bool IsDuplicateID(int id) // Function to check if Employees' ID are duplicated or not
        {
            if (IsEmpty()) return false;

            Node current = pHead;
            do
            {
                if (current.Data.ID == id)
                    return true;
                current = current.pNext;
            } while (current != pHead);

            return false;
        }
        public bool IsEmpty()
        {
            return pHead == null;
        }
        public void InsertAtBeginning(Employee employee)
        {
            if (IsDuplicateID(employee.ID))
            {
                OurMessageBox.Show($"An employee with ID {employee.ID} already exists");
                return;
            }

            Node newNode = CreateNode(employee);

            if (IsEmpty())
            {
                pHead = newNode;
                newNode.pNext = pHead;
            }
            else
            {
                Node temp = pHead;
                while (temp.pNext != pHead)
                {
                    temp = temp.pNext;
                }
                temp.pNext = newNode;
                newNode.pNext = pHead;
                pHead = newNode;
            }
        }

        public void InsertAtEnd(Employee employee)
        {
            if (IsDuplicateID(employee.ID))
            {
                OurMessageBox.Show($"An employee with ID {employee.ID} already exists");
                return;
            }

            Node newNode = new Node(employee);
            if (IsEmpty())
            {
                pHead = newNode;
                newNode.pNext = pHead;
            }
            else
            {
                Node temp = pHead;
                while (temp.pNext != pHead)
                {
                    temp = temp.pNext;
                }
                temp.pNext = newNode;
                newNode.pNext = pHead;
            }
        }

        public void InsertAfter(Node prevNode, Employee employee)
        {
            if (prevNode == null)
            {
                OurMessageBox.Show("The given previous node cannot be null");
                return;
            }

            Node newNode = new Node(employee);
            newNode.pNext = prevNode.pNext;
            prevNode.pNext = newNode;
        }

        public void RemoveAfter(Node prevNode)
        {
            if (prevNode == null || prevNode.pNext == null)
            {
                OurMessageBox.Show("The given previous node is not valid or has no next node");
                return;
            }

            Node nodeToRemove = prevNode.pNext;
            prevNode.pNext = nodeToRemove.pNext;

            if (nodeToRemove == pHead) 
            {
                pHead = prevNode.pNext;
            }
        }

        public void SelectionSort01() // This is Ascending Order
        {
            if (IsEmpty() || pHead.pNext == pHead) return;

            CircularLinkedList sortedList = new CircularLinkedList();
            Node current = pHead;

            do
            {
                Node minNode = current;
                Node nextNode = current.pNext;

                do
                {
                    if (nextNode.Data.ID < minNode.Data.ID)
                    {
                        minNode = nextNode;
                    }
                    nextNode = nextNode.pNext;
                } while (nextNode != pHead);

                sortedList.InsertAtEnd(minNode.Data);

                
                Remove(minNode.Data.ID); 

                current = pHead;
            } while (!IsEmpty());

            pHead = sortedList.pHead;
        }

        public void SelectionSort02() // This is Descending Order
        {
            if (IsEmpty() || pHead.pNext == pHead) return;

            CircularLinkedList sortedList = new CircularLinkedList();
            Node current = pHead;

            do
            {
                Node maxNode = current;
                Node nextNode = current.pNext;

                do
                {
                    if (nextNode.Data.ID > maxNode.Data.ID)
                    {
                        maxNode = nextNode;
                    }
                    nextNode = nextNode.pNext;
                } while (nextNode != pHead);

                sortedList.InsertAtEnd(maxNode.Data);

                Remove(maxNode.Data.ID);

                current = pHead;
            } while (!IsEmpty());

            pHead = sortedList.pHead;
        }

        private void Remove(int id) // Method to remove a node by data
        {
            if (IsEmpty()) return;

            Node current = pHead;
            Node previous = null;

            do
            {
                if (current.Data.ID == id)
                {
                    if (previous == null)
                    {
                        if (current.pNext == pHead)
                        {
                            pHead = null;
                        }
                        else
                        {
                            Node lastNode = pHead;
                            while (lastNode.pNext != pHead)
                            {
                                lastNode = lastNode.pNext;
                            }
                            pHead = current.pNext;
                            lastNode.pNext = pHead;
                        }
                    }
                    else
                    {
                        previous.pNext = current.pNext;
                    }
                    return; 
                }
                previous = current;
                current = current.pNext;
            } while (current != pHead);
        }



        public void QuickSort()
        {
            if (IsEmpty() || pHead.pNext == pHead) return;
            pHead = QuickSort(pHead);
        }

        private Node QuickSort(Node head)
        {
            if (head == null || head.pNext == head) return head;

            Node pivot = head;
            Node lessHead = null, lessTail = null;
            Node greaterHead = null, greaterTail = null;

            Node current = head.pNext;
            do
            {
                if (current.Data.ID < pivot.Data.ID)
                {
                    if (lessHead == null)
                    {
                        lessHead = current;
                        lessTail = lessHead;
                    }
                    else
                    {
                        lessTail.pNext = current;
                        lessTail = lessTail.pNext;
                    }
                }
                else
                {
                    if (greaterHead == null)
                    {
                        greaterHead = current;
                        greaterTail = greaterHead;
                    }
                    else
                    {
                        greaterTail.pNext = current;
                        greaterTail = greaterTail.pNext;
                    }
                }
                current = current.pNext;
            } while (current != head);

            if (lessTail != null) lessTail.pNext = pivot;
            else lessHead = pivot;

            pivot.pNext = QuickSort(greaterHead);

            if (lessTail != null) lessTail.pNext = lessHead;
            else head = lessHead;

            return head;
        }


        public void Merge(CircularLinkedList otherList)
        {
            if (otherList.IsEmpty()) return;

            if (IsEmpty())
            {
                pHead = otherList.pHead;
                return;
            }

            Node temp = pHead;
            while (temp.pNext != pHead)
            {
                temp = temp.pNext;
            }
            temp.pNext = otherList.pHead;


            Node otherTemp = otherList.pHead;
            while (otherTemp.pNext != otherList.pHead)
            {
                otherTemp = otherTemp.pNext;
            }
            otherTemp.pNext = pHead;
            pHead = otherList.pHead; 
        }

        public void RemoveAllByPosition(string position)
        {
            if (IsEmpty()) return;

            Node current = pHead;
            Node prev = null;

            do
            {
                if (current.Data.Position == position)
                {
                    if (prev == null) 
                    {
                        Node temp = pHead;
                        while (temp.pNext != pHead)
                        {
                            temp = temp.pNext;
                        }
                        if (pHead.pNext == pHead) 
                        {
                            pHead = null;
                        }
                        else
                        {
                            pHead = pHead.pNext;
                            temp.pNext = pHead;
                        }
                    }
                    else
                    {
                        prev.pNext = current.pNext;
                    }
                    current = (prev == null) ? pHead : prev.pNext; 
                }
                else
                {
                    prev = current;
                    current = current.pNext;
                }
            } while (current != pHead);
        }
        public void RemoveAllByID(int id)
        {
            if (IsEmpty()) return;

            Node current = pHead;
            Node previous = null;
            bool found = false;

            do
            {
                if (current.Data.ID == id) 
                {
                    found = true; 

                    if (previous == null) 
                    {

                        if (current.pNext == pHead)
                        {
                            pHead = null; 
                        }
                        else
                        {
                            
                            Node lastNode = pHead;
                            while (lastNode.pNext != pHead)
                            {
                                lastNode = lastNode.pNext;
                            }
                            pHead = current.pNext; 
                            lastNode.pNext = pHead;
                        }
                    }
                    else
                    {
                        previous.pNext = current.pNext;
                    }

                    current = previous != null ? previous.pNext : pHead; 
                }
                else
                {
                    previous = current; 
                    current = current.pNext; 
                }
            } while (current != pHead);

            if (found)
            {
                OurMessageBox.Show($"All nodes with ID {id} have been removed");
            }
            else
            {
                OurMessageBox.Show($"No nodes with ID {id} found");
            }
        }
        public void PrintList(ListBox listBox)
        {
            listBox.Items.Clear();
            if (IsEmpty())
            {
                listBox.Items.Add("List is empty");
                return;
            }

            Node current = pHead;
            do
            {
                listBox.Items.Add(current.Data);
                current = current.pNext;
            } while (current != pHead);
        }
        public void RemoveFirst()
        {
            if (IsEmpty())
            {
                OurMessageBox.Show("List is empty");
                return;
            }

            if (pHead.pNext == pHead)
            {
                pHead = null;
            }
            else
            {
                Node temp = pHead;
                while (temp.pNext != pHead)
                {
                    temp = temp.pNext;
                }
                temp.pNext = pHead.pNext;
                pHead = pHead.pNext;
            }
        }

        public void RemoveLast()
        {
            if (IsEmpty())
            {
                OurMessageBox.Show("List is empty");
                return;
            }

            if (pHead.pNext == pHead) 
            {
                pHead = null;
            }
            else
            {
                Node temp = pHead;
                while (temp.pNext.pNext != pHead)
                {
                    temp = temp.pNext;
                }
                temp.pNext = pHead;
            }
        }
        public Node Search(int id)
        {
            if (IsEmpty())
                return null;

            Node current = pHead;
            do
            {
                if (current.Data.ID == id)
                    return current;
                current = current.pNext;
            } while (current != pHead);

            return null;
        }
    }
}
