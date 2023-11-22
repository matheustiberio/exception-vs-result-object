using BenchmarkDotNet.Attributes;

namespace BenchmarkExceptionVsResultObject;

[MemoryDiagnoser]
public class ExceptionVsResultObject
{
    [Benchmark]
    public void CriarComResultObject()
    {
        Service.CriarUsuarioComResultObject();
    }

    [Benchmark]
    public void CriarComException()
    {
        try
        {
            Service.CriarUsuarioComException();
        }
        catch (Exception)
        {
        }
    }
}
