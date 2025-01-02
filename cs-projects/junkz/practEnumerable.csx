using System;
using System.Collections;

foreach (var value in PowerOf2())
    Console.WriteLine(value);

public  IEnumerable PowerOf2(long startValue=2, int limit=40)
{
    yield return startValue;
    for (int i = 0; i < limit; i++) {
        yield return startValue *= 2;
    }
}
