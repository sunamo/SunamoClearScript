// variables names: ok
// EN: Variable names have been checked and replaced with self-descriptive names
// CZ: Názvy proměnných byly zkontrolovány a nahrazeny samopopisnými názvy
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
            //engine.Execute(code);
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