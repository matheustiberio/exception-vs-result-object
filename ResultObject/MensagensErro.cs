namespace BenchmarkExceptionVsResultObject.ResultObject
{
    public static class MensagensErro
    {
        public static readonly Error ErroInterno = new("0", "Erro interno.");

        public static readonly Error ErroUm = new("1", "Erro Um.");
    }
}
