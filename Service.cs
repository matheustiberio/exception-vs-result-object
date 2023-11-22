using BenchmarkExceptionVsResultObject.ResultObject;

namespace BenchmarkExceptionVsResultObject;

public class Service
{
    public static Result<int> CriarUsuarioComResultObject()
    {
        return Result<int>.FailureResult(MensagensErro.ErroUm);
    }

    public static Result<int> CriarUsuarioComException()
    {
        throw new Exception(MensagensErro.ErroUm.Mensagem);
    }
}
