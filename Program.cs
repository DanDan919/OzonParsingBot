using Core;

class Program
{
    static async Task Main()
    {
        var orchestrator = new TaskOrchestrator(threads: 5);
        await orchestrator.RunAsync();
    }
}