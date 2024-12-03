namespace DotNetRuntime;

public class Handler {
    public async Task<RuntimeOutput> Main(RuntimeContext Context) {
        await Task.CompletedTask;
        Context.Log("hello world!");
        Context.Error("Error: hello world!");
        return Context.Res.Send("hello world!");
    }
}