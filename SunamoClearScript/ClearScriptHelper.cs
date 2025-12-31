namespace SunamoClearScript;

public class ClearScriptHelper
{
    public static ClearScriptHelper Instance = new();
    private readonly V8ScriptEngine engine = new();

    private ClearScriptHelper()
    {
    }

    public bool Execute(string code)
    {
        try
        {
            engine.Compile(code);
        }
        catch (Exception ex)
        {
            return false;
        }

        return true;
    }

    ~ClearScriptHelper()
    {
        engine.Dispose();
    }
}