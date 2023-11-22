class TaskManager
{
    private List<Task> tasks;

    public TaskManager()
    {
        tasks = new List<Task>();
    }

    public void AddTask(Task task)
    {
        tasks.Add(task);
    }

    public void CompleteTask(int taskId)
    {
        var task = tasks.FirstOrDefault(t => t.Id == taskId);
        if (task != null)
        {
            task.IsCompleted = true;
            task.CompletedDateTime = DateTime.Now;
        }
    }

    public void DeleteTask(int taskId)
    {
        var task = tasks.FirstOrDefault(t => t.Id == taskId);
        if (task != null)
        {
            tasks.Remove(task);
        }
    }

    public List<Task> PendingTask()
    {
        return tasks.Where(t => !t.IsCompleted).ToList();
    }

    public List<Task> CompletedTasks()
    {
        return tasks.Where(t => t.IsCompleted).ToList();
    }

    public List<Task> SearchTasks(string keyword)
    {
        return tasks.Where(t => t.Title.Contains(keyword, StringComparison.OrdinalIgnoreCase) || t.Description.Contains(keyword, StringComparison.OrdinalIgnoreCase)).ToList();
    }
    public void PrintStatistics()
    {
        Console.WriteLine("----- Estatísticas das Tarefas ------");
        Console.WriteLine($"Concluídas: {tasks.Count(t => t.IsCompleted)}" + "\n" + $"Pendentes: {tasks.Count(t => !t.IsCompleted)}");

        var oldestTask = tasks.OrderBy(t => t.CreatedDate).FirstOrDefault();
        var newestTask = tasks.OrderByDescending(t => t.CreatedDate).FirstOrDefault();

        Console.WriteLine($"Mais antiga: {oldestTask?.Title} ({oldestTask?.CreatedDate})" + "\n" + $"Mais recente: {newestTask?.Title} ({newestTask?.CreatedDate})");

        if (oldestTask != null && oldestTask.IsCompleted)
        {
            var earliestCompletedTask = tasks.Where(t => t.IsCompleted).OrderBy(t => t.CompletedDateTime).FirstOrDefault();
            Console.WriteLine($"Primeira tarefa concluída: {earliestCompletedTask?.Title} ({earliestCompletedTask?.CompletedDateTime})");
        }

        if (newestTask != null && newestTask.IsCompleted)
        {
            var latestCompletedTask = tasks.Where(t => t.IsCompleted).OrderByDescending(t => t.CompletedDateTime).FirstOrDefault();
            Console.WriteLine($"Última tarefa concluída: {latestCompletedTask?.Title} ({latestCompletedTask?.CompletedDateTime})");
        }
    }
}

class Task
{
    private static int lastId = 0;
    public int Id { get; }
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime CreatedDate { get; }
    public DateTime? CompletedDateTime { get; set; }
    public bool IsCompleted { get; set; }

    public Task(string title, string description)
    {
        Id = ++lastId;
        Title = title;
        Description = description;
        CreatedDate = DateTime.Now;
    }
}

class Program
{
    static void PrintTasks(List<Task> tasks)
    {
        foreach (var task in tasks)
            Console.WriteLine($"{task.Id}: {task.Title} - {task.Description} {(task.IsCompleted ? "(Concluída em " + task.CompletedDateTime?.ToString() + ")" : "")}");
    }
    static void Main()
    {
        var taskManager = new TaskManager();
        string option;

        do
        {
            Console.Write("1. Adicionar Tarefa" + "\n" +
                                "2. Marcar Tarefa como Concluída" + "\n" +
                                "3. Excluir Tarefa" + "\n" +
                                "4. Listar Tarefas Pendentes" + "\n" +
                                "5. Listar Tarefas Concluídas" + "\n" +
                                "6. Pesquisar Tarefas" + "\n" +
                                "7. Exibir Estatísticas" + "\n" +
                                "0. Sair \n\n");

            Console.Write("Escolha uma opção: ");
            option = Console.ReadLine() ?? "";
            Console.WriteLine();

            switch (option)
            {
                case "1":
                    Console.Write("Digite o título da tarefa: ");
                    string title = Console.ReadLine() ?? "";

                    Console.Write("Digite a descrição da tarefa: ");
                    string description = Console.ReadLine() ?? "";

                    taskManager.AddTask(new Task(title, description));
                    Console.WriteLine();
                    break;

                case "2":
                    Console.WriteLine("Tarefas Pendentes:");
                    var completeTask = taskManager.PendingTask();
                    PrintTasks(completeTask);

                    Console.WriteLine();

                    Console.Write("Digite o ID da tarefa a ser marcada como concluída: ");
                    if (int.TryParse(Console.ReadLine(), out int taskId))
                        taskManager.CompleteTask(taskId);
                    else
                        Console.WriteLine("ID inválido. Digite um número válido.");
                    Console.WriteLine();
                    break;

                case "3":
                    Console.WriteLine("Tarefas Pendentes:");
                    var pendingTasksId = taskManager.PendingTask();
                    PrintTasks(pendingTasksId);
                    Console.WriteLine();

                    Console.WriteLine("Tarefas Concluídas:");
                    var completedTasksId = taskManager.CompletedTasks();
                    PrintTasks(completedTasksId);
                    Console.WriteLine();

                    Console.Write("Digite o ID da tarefa a ser excluída: ");
                    if (int.TryParse(Console.ReadLine(), out int deleteTaskId))
                        taskManager.DeleteTask(deleteTaskId);
                    else
                        Console.WriteLine("ID inválido. Digite um número válido.");
                    Console.WriteLine();
                    break;

                case "4":
                    Console.WriteLine("Tarefas Pendentes:");
                    var pendingTasks = taskManager.PendingTask();
                    PrintTasks(pendingTasks);
                    break;

                case "5":
                    Console.WriteLine("Tarefas Concluídas:");
                    var completedTasks = taskManager.CompletedTasks();
                    PrintTasks(completedTasks);
                    Console.WriteLine();
                    break;

                case "6":
                    Console.Write("Digite a palavra-chave para pesquisa: ");
                    string keyword = Console.ReadLine() ?? "";

                    var searchedTasks = taskManager.SearchTasks(keyword);
                    PrintTasks(searchedTasks);

                    Console.WriteLine();
                    break;

                case "7":
                    taskManager.PrintStatistics();

                    Console.WriteLine();
                    break;

                case "0":
                    Console.WriteLine("Saindo!!\n\n");
                    break;

                default:
                    Console.WriteLine("Opção inválida. Tente novamente.\n\n");
                    break;
            }

            Console.WriteLine();
        } while (option != "0");
    }
}
