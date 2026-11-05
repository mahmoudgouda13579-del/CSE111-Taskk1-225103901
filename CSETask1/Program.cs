// Name: mahmoud mohamed elhassanein gouda
// Student ID: 225103901

using System;

namespace Cse111Task1
{
    
    public class StudentList
    {
        public Student? First { get; set; }
        public Student? Last { get; set; }
        public int Count { get; set; }

        public StudentList()
        {
            First = null;
            Last = null;
            Count = 0;
        }

    
        public void AddFront(int id)
        {
            Student newStudent = new Student(id);

            if (First == null)
            {
                First = newStudent;
                Last = newStudent;
            }
            else
            {
                newStudent.Next = First;
                First = newStudent;
            }

            Count++;
        }

      
        public void AddEnd(int id)
        {
            Student newStudent = new Student(id);

            if (Last == null)
            {
                First = newStudent;
                Last = newStudent;
            }
            else
            {
                Last.Next = newStudent;
                Last = newStudent;
            }

            Count++;
        }

      
        public bool Remove(int id)
        {
           
            if (First == null)
            {
                return false;
            }

            
            if (First.Id == id)
            {
                First = First.Next;
                Count--;

                if (First == null)
                {
                    Last = null;
                }
                return true;
            }

          
            Student previous = First;
            Student? current = First.Next;

            while (current != null)
            {
                if (current.Id == id)
                {
                    previous.Next = current.Next;

                    if (current == Last)
                    {
                        Last = previous;
                    }

                    Count--;
                    return true;
                }

                previous = current;
                current = current.Next;
            }

            
            return false;
        }

        
        public void Reverse()
        {
            
            if (First == null || First.Next == null)
            {
                return;
            }

            Student? previous = null;
            Student? current = First;

            
            Last = First;

            while (current != null)
            {
                Student? nextStudent = current.Next; 
                current.Next = previous;             
                previous = current;
                current = nextStudent;
            }

            First = previous;
        }

        
        public void Print()
        {
            Student? current = First;
            string result = "";

            while (current != null)
            {
                result += current.Id;

                if (current.Next != null)
                {
                    result += " ";
                }

                current = current.Next;
            }

            Console.WriteLine(result);
        }
    }
}
namespace Cse111Task1
{
    
    public class Student
    {
        public int Id { get; set; }
        public Student? Next { get; set; }

        public Student(int id)
        {
            Id = id;
            Next = null;
        }
    }
}