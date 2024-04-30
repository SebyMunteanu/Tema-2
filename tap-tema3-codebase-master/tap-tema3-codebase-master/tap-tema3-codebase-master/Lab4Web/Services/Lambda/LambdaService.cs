namespace Lab4Web.Services.Lambda
{
    public class LambdaService : ILambdaService
    {
        /*public async Tuple<int, int, int> Test1(int value)
        {
            var lambdaExp2 = async () => Delay();
            await lambdaExp2();
            var lambdaExpression = new Func<int, Tuple<int, int, int>>((v) => new Tuple<int, int, int>(v%10, (v/=10)%10, (v/=10)%10));
            return lambdaExpression(value);
        }
        public  Delay(int value)
        {
            Task.Delay(10000);
            return value * 10;
        }
        */
        public string TestLambdaWithoutParameters()
        {
            Func<string> lambdaWithoutParameters = () => "Aceasta este o expresie lambda fără parametri";
            return lambdaWithoutParameters();
        }
        public string TestLambdaWithParameters(int number)
        {
            Func<int, string> lambdaWithParameter = (x) => $"Aceasta este o expresie lambda cu parametru: {x}";
            return lambdaWithParameter(number);
        }
        public string TestLambdaWithTwoParameters(int valoare1, int valoare2)
        {
            Func<int, int, string> lambdaWithTwoParameters = (x, y) => $"Aceasta este o expresie lambda cu doi parametri: {x}, {y}";
            return lambdaWithTwoParameters(valoare1, valoare2);
        }

        public string TestLambdaWithUnusedParameters(int x, int y)
        {
            Func<int, int, string> lambdaWithUnusedParameters = (a, b) =>
            {
                // Parametrii x și y sunt neutilizați în corpul expresiei lambda
                return "Aceasta este o expresie lambda cu parametri neutilizați";
            };
            return lambdaWithUnusedParameters(12431312, 123132131); // Poți folosi orice valoare pentru parametrii neutilizați
        }

        public string TestLambdaWithDefaultParameters(int x = 1, int y = 2)
        {
            Func<int, int, string> lambdaWithDefaultParameters = (a, b) =>
            {
                // Utilizarea valorilor implicite ale parametrilor x și y în corpul expresiei lambda
                return $"Aceasta este o expresie lambda cu parametri cu valori implicite: {a}, {b}";
            };
            return lambdaWithDefaultParameters(x, y);
        }

        public async Task<Tuple<int, int, int>> Test1Async(int value)
        {
            var lamdaExp2 = async () => await Delay();
            await lamdaExp2();

            var lambdaExpression = new Func<int, Tuple<int, int, int>>((v) => new Tuple<int, int, int>(v % 10, (v /= 10) % 10, (v /= 10) % 10));
            return lambdaExpression(value);
        }
        public Task Delay()
        {
            return Task.Delay(10000);
        }
    }
}
