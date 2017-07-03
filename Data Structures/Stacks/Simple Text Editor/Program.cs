class Program
{
    static void Main(string[] args)
    {
        int q = Convert.ToInt32(Console.ReadLine());
        TextEditor textEditor = new TextEditor();

        for (int i = 0; i < q; i++)
        {
            string[] operationArray = Console.ReadLine().Split(' ');
            int operationType = Convert.ToInt32(operationArray[0]);

            switch (operationType)
            {
                case 1:
                    textEditor.Append(operationArray[1]);
                    break;
                case 2:
                    textEditor.Delete(Convert.ToInt32(operationArray[1]));
                    break;
                case 3:
                    textEditor.Print(Convert.ToInt32(operationArray[1]));
                    break;
                case 4:
                    textEditor.Undo();
                    break;
            }
        }
    }
}

public class Node<T>
{
    public Node(T data)
    {
        Data = data;
    }

    public T Data { get; }
    public Node<T> Next { get; set; }
}

public class LinkedList<T>
{
    private Node<T> _head;

    public void Insert(T data)
    {
        if (_head == null)
        {
            _head = new Node<T>(data);
        }
        else
        {
            Node<T> node = _head;

            _head = new Node<T>(data)
            {
                Next = node
            };
        }
    }

    public T Remove()
    {
        if (IsEmpty())
        {
            return default(T);
        }

        Node<T> node = _head;

        _head = node.Next;

        return node.Data;
    }

    public T GetHead()
    {
        if (IsEmpty())
        {
            return default(T);
        }

        return _head.Data;
    }

    public bool IsEmpty()
    {
        return _head == null;
    }
}

public class Stack<T>
{
    private LinkedList<T> _linkedList = new LinkedList<T>();

    public void Push(T item)
    {
        _linkedList.Insert(item);
    }

    public T Pop()
    {
        return _linkedList.Remove();
    }

    public T Top()
    {
        return _linkedList.GetHead();
    }

    public bool IsEmpty()
    {
        return _linkedList.IsEmpty();
    }
}

public class TextEditor
{
    private Stack<string> operations = new Stack<string>();

    public void Append(string input)
    {
        string top = operations.Top() + input;

        operations.Push(top);
    }

    public void Delete(int length)
    {
        string top = operations.Top();

        top = top.Remove(top.Length - length);

        operations.Push(top);
    }

    public void Print(int index)
    {
        string top = operations.Top();

        Console.WriteLine(top[index - 1]);
    }

    public void Undo()
    {
        operations.Pop();
    }
}
