using Parsing;

namespace Core;

public class TaskOrchestrator
{
    private readonly int _threads;

    public TaskOrchestrator(int threads)
    {
        _threads = threads;
    }

    public async Task RunAsync()
    {
        var tasks = new List<Task>();

        for (int i = 0; i < _threads; i++)
        {
            tasks.Add(Task.Run(async () =>
            {
                var brut = new OzonBrut();
                await brut.RunAsync();
            }));
        }

        await Task.WhenAll(tasks);
    }
}