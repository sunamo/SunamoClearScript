namespace SunamoClearScript;

public class ClearScriptHelper
{
    V8ScriptEngine engine = new V8ScriptEngine();

    public static ClearScriptHelper ci = new ClearScriptHelper();

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
