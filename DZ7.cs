//LANAC ODGOVORNOSTI
   
    public class Signer
{
        public string Name { get; set;}
        public Signer(string name)
        {
            Name = name;
        }
    }
    public abstract class SignHandler
    {
        protected SignHandler successor;

        public void SetSuccessor(SignHandler successor)
        {
            this.successor = successor;
        }

        public abstract void SignDocument(List<Signer> signers);
    }

    public class BaseHandler : SignHandler
    {
        public override void SignDocument(List<Signer> signers)
        {
            foreach (var signer in signers)
            {
                if (signer.Name == "Marko")
                {
                    Console.WriteLine($"Signer {signer.Name} signed the document.");
                    return;
                }
            }
            if (successor != null)
            {
                successor.SignDocument(signers);
            }
        }
    }
    public class SignerHandler : SignHandler
    {
        public override void SignDocument(List<Signer> signers)
        {
            foreach (var signer in signers)
            {
                Console.WriteLine($"Signer {signer.Name} signed the document.");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Signer> signers = new List<Signer>()
            {
                new Signer("Ivan"),
                new Signer("Petar"),
                new Signer("Marko"),
                new Signer("Ana")
            };

            SignHandler firstHandler = new BaseHandler();
            SignHandler secondHandler = new SignerHandler();
            firstHandler.SetSuccessor(secondHandler);

            firstHandler.SignDocument(signers);
        }
    }

// ITERATOR

namespace CustomIterator
{
    public class Task
    {
        public string TaskName;

        public Task(string taskName)
        {
            TaskName = taskName;
        }
    }

    public interface IIterator
    {
        public Task GetNext();
        public bool HasNext();
    }

    public interface IIteratorCollection
    {
        public IIterator CreateIterator();
    }
    public class TaskIterator : IIterator
    {
        private TaskCollection taskCollection;
        private int currentPosition;
        public TaskIterator(TaskCollection collection)
        {
            taskCollection = collection;
            currentPosition = 0;
        }

        public Task GetNext()
        {
            Task task = taskCollection.GetTask(currentPosition);
            currentPosition++;
            return task;
        }

        public bool HasNext()
        {
            return currentPosition < taskCollection.Count();
        }
    }
    public class TaskCollection : IIteratorCollection
    {
        public List<Task> tasks;

        public TaskCollection()
        {
            tasks = new List<Task>();
        }

        public IIterator CreateIterator()
        {
            return new TaskIterator(this);
        }

        public Task GetTask(int index)
        {
            return tasks[index];
        }

        public int Count()
        {
            return tasks.Count;
        }
    }

    public static class ClientCode
    {
        public static void Run()
        {
            TaskCollection taskCollection = new TaskCollection();

            taskCollection.tasks.Add(new Task(" Riješi zadaću 7"));
            taskCollection.tasks.Add(new Task("Predaj zadaću"));

            IIterator iterator = taskCollection.CreateIterator();

            while (iterator.HasNext())
            {
                Task task = iterator.GetNext();
                Console.WriteLine(task.TaskName);
            }
        }
    }
}

