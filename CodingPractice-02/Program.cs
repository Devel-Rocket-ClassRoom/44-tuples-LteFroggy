using System;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;

// 1. 기본 튜플 반환
{
    (int, int) Tally() => (12, 3);

    var tp = Tally();
    Console.WriteLine($"합계 : {tp.Item1}, 개수 : {tp.Item2}");
    Console.WriteLine();
    Console.WriteLine();
}

// 2. 반환 튜플에 이름 지정
{
    (int Sum, int Count) Calculate() => (45, 6);

    var tp = Calculate();
    Console.WriteLine($"합계 : {tp.Sum}, 개수 : {tp.Count}");
    Console.WriteLine();
    Console.WriteLine();
}

// 3. 표현식 본문으로 간결하게 작성
{
    (int first, int second) GetPair() => (100, 200);
    var tp = GetPair();
    Console.WriteLine($"{tp.Item1}, {tp.Item2}");
    Console.WriteLine();
    Console.WriteLine();
}

// 4. 최솟값과 최댓값 반환
{
    (int min, int max) FindMinMax(int[] arr) {
        int min = Int32.MaxValue;
        int max = Int32.MinValue;
        foreach (var val in arr) {
            min = min > val ? val : min;
            max = max < val ? val : max;
        }

        return (min, max);
    };

    int[] arr =  { 5, 2, 8, 1, 9, 3 };
    var tp = FindMinMax(arr);
    Console.WriteLine($"최솟값 : {tp.min}, 최댓값 : {tp.max}");
    Console.WriteLine();
    Console.WriteLine();
}

// 5. 기본값 반환
{
    (int, int) ZeroZero() => default;

    var tp = ZeroZero();
    Console.WriteLine($"{tp.Item1}, {tp.Item2}");
    Console.WriteLine();
    Console.WriteLine();
}

// 6. 분해 기본
{
    var bob = ("Bob", 23);
    var (name, age) = bob;

    Console.WriteLine($"이름 : {name}");
    Console.WriteLine($"나이 : {age}");
    Console.WriteLine();
    Console.WriteLine();
}

// 7. var를 사용한 분해
{
    (int, int) Tally() => (12, 3);
    var (sum, count) = Tally();

    Console.WriteLine($"Sum : {sum}, Count : {count}");
    Console.WriteLine();
    Console.WriteLine();
}

// 8. 기존 변수에 분해
{
    (string name, int age) tp = ("Alice", 30);

    var (name, age) = tp;

    Console.WriteLine($"{name}, {age}");
    Console.WriteLine();
    Console.WriteLine();
}

// 9. 무시 패턴 (_)
{ 
    var tp = (1, 23, 2);
    var (_, age, _) = tp;

    Console.WriteLine($"나이 : {age}");
    Console.WriteLine();
    Console.WriteLine();
}