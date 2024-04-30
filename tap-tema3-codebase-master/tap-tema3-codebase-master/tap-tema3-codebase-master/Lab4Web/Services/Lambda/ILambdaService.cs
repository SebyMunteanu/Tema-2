namespace Lab4Web.Services.Lambda
{
    public interface ILambdaService
    {
        Task<Tuple<int, int, int>> Test1Async(int value);
        string TestLambdaWithoutParameters();
        string TestLambdaWithParameters(int number);
        string TestLambdaWithTwoParameters(int valoare1, int valoare2);
        string TestLambdaWithUnusedParameters(int x, int y);
        string TestLambdaWithDefaultParameters(int x = 1, int y = 2);
    }
}
