namespace SunamoClearScript;

/// <summary>
/// Represents the clear script helper type.
/// </summary>
public class ClearScriptHelper
{
    /// <summary>
    /// Gets the instance.
    /// </summary>
    public static ClearScriptHelper Instance { get; } = new();

    private readonly V8ScriptEngine engine = new();

    private ClearScriptHelper()
    {
    }

    /// <summary>
    /// Execute.
    /// </summary>
    /// <param name="code">The code.</param>
    /// <returns>The execute result.</returns>
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
    /// Clear script helper.
    /// </summary>
    /// <returns>The clear script helper result.</returns>
    ~ClearScriptHelper()
    {
        engine.Dispose();
    }
}