# LSM - метод наименьших квадратов
Класс LSMeans предназначен для вычисления коэффицентов линейной регрессии по методу наименьших квадратов.
Использование метода показано в проекте LSMExample:

```
double[] coef = LSMeans.Calc(X, Y);
if (coef != null)
{
    String sign = coef[1] > 0 ? "+" : "";
    Console.WriteLine($"Equation: y={Math.Round(coef[0], 2)}{sign}{Math.Round(coef[1], 2)}*x");
}
```

В проекте LSMTests содержатся unit-тесты: первый показывает корректную работу, второй - появление ошибки при передаче методу массивов разной длины.

Лицензия - GNU GPL.
