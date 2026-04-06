namespace SunamoClearScript;

/// <summary>
/// Helper class for executing JavaScript code using ClearScript V8 engine.
/// </summary>
public class ClearScriptHelper
{
    /// <summary>
    /// Singleton instance of ClearScriptHelper.
    /// </summary>
    public static ClearScriptHelper Instance { get; } = new();

    private readonly V8ScriptEngine engine = new();

    private ClearScriptHelper()
    {
    }

    /// <summary>
    /// Compiles JavaScript code and returns whether it was successful.
    /// </summary>
    /// <param name="code">JavaScript code to compile.</param>
    /// <returns>True if code compiled successfully, false otherwise.</returns>
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
    /// Finalizer that disposes the V8 engine.
    /// </summary>
    ~ClearScriptHelper()
    {
        engine.Dispose();
    }
}