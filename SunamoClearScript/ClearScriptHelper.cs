namespace SunamoClearScript;

/// <summary>
/// EN: Helper class for executing JavaScript code using ClearScript V8 engine
/// CZ: Pomocná třída pro spouštění JavaScript kódu pomocí ClearScript V8 engine
/// </summary>
public class ClearScriptHelper
{
    /// <summary>
    /// EN: Singleton instance of ClearScriptHelper
    /// CZ: Singleton instance ClearScriptHelper
    /// </summary>
    public static ClearScriptHelper Instance { get; } = new();

    private readonly V8ScriptEngine engine = new();

    private ClearScriptHelper()
    {
    }

    /// <summary>
    /// EN: Executes (compiles) JavaScript code and returns whether it was successful
    /// CZ: Provede (zkompiluje) JavaScript kód a vrátí zda byl úspěšný
    /// </summary>
    /// <param name="code">EN: JavaScript code to execute; CZ: JavaScript kód k provedení</param>
    /// <returns>EN: True if code compiled successfully, false otherwise; CZ: True pokud se kód úspěšně zkompiloval, jinak false</returns>
    public bool Execute(string code)
    {
        try
        {
            engine.Compile(code);
        }
        catch (Exception)
        {
            return false;
        }

        return true;
    }

    /// <summary>
    /// EN: Finalizer that disposes the V8 engine
    /// CZ: Finalizátor který uvolní V8 engine
    /// </summary>
    ~ClearScriptHelper()
    {
        engine.Dispose();
    }
}