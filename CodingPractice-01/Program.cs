using System;

// 1. 튜플 리터럴
{
    var tp = ("Bob", 23);

    Console.WriteLine(tp.Item1);
    Console.WriteLine(tp.Item2);
    Console.WriteLine();
    Console.WriteLine();
}

// 2-1. 같은 타입의 튜플
{
    var tp = (12, 34, 56);
    Console.WriteLine($"{tp.Item1}, {tp.Item2}, {tp.Item3}");
    Console.WriteLine();
    Console.WriteLine();
}

// 2-2. 서로 다른 타입의 튜플
{
    var tp = ("Hello", 100, true, 3.14);

    Console.WriteLine($"{tp.Item1}, {tp.Item2}, {tp.Item3}, {tp.Item4}");
    Console.WriteLine();
    Console.WriteLine();
}

// 3-1. 기본 명시적 타입
{
    (string, int) tp = ("Alice", 25);
    Console.WriteLine($"{tp.Item1}, {tp.Item2}");
    Console.WriteLine();
    Console.WriteLine();
}

// 3-2. 이름이 있는 명시적 타입
{
    (ushort Width, ushort Height) tp = (1920, 1080);
    Console.WriteLine($"해상도 : {tp.Width} x {tp.Height}");
    Console.WriteLine();
    Console.WriteLine();
}

// 4. 튜플의 값 타입 특성
{
    var original = ("Bob", 23);
    var copy = original;

    original.Item1 = "Alice";

    Console.WriteLine($"원본 : ({original.Item1}, {original.Item2})");
    Console.WriteLine($"복사본 : ({copy.Item1}, {copy.Item2})");
    Console.WriteLine();
    Console.WriteLine();
}

// 5. 생성 시 이름 지정
{
    (string name, int age) tp = ("Bob", 23);

    Console.WriteLine(tp.Item1);
    Console.WriteLine(tp.Item2);
    Console.WriteLine(tp.name);
    Console.WriteLine(tp.age);
    Console.WriteLine();
    Console.WriteLine();
}

// 6. 요소 이름 지정 예제
{
    var tp = ("철수", true, 1000);
    Console.WriteLine($"{tp.Item1}(학생 : {tp.Item2}) - 주문 : {tp.Item3:N0}원");
    Console.WriteLine();
    Console.WriteLine();
}

// 7. 타입 선언에서 이름 지정
{
    (string name, int age, char gender) tp = ("Bob", 23, 'M');

    Console.WriteLine($"이름 : {tp.name}");
    Console.WriteLine($"나이 : {tp.age}");
    Console.WriteLine($"성별 : {tp.gender}");
    Console.WriteLine();
    Console.WriteLine();
}

// 8. 요소 이름 자동 추론
{
    var tp = (DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year);

    Console.WriteLine($"일 : {tp.Day}");
    Console.WriteLine($"월 : {tp.Month}");
    Console.WriteLine($"년 : {tp.Year}");
    Console.WriteLine();
    Console.WriteLine();
}