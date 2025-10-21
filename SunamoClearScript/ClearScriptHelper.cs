// EN: Variable names have been checked and replaced with self-descriptive names
// CZ: Názvy proměnných byly zkontrolovány a nahrazeny samopopisnými názvy
namespace SunamoClearScript;

public class ClearScriptHelper
{
    public static ClearScriptHelper ci = new();
    private readonly V8ScriptEngine engine = new();

    private ClearScriptHelper()
    {
    }

    public bool Execute(string c)
    {
        try
        {
            engine.Compile(c);
            //engine.Execute(c);
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