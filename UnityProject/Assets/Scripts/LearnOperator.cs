using UnityEngine;

public class LearnOperator : MonoBehaviour
{
    public int num1 = 1, num2 = 2;
    public int score = 50;
    public int a = 3, b = 10, c=10, d=10;
    public void Start()
    {
        print(a + b);
        print(a - b);
        print(a * b);
        print(a / b);
        print(a % b);

        print(c++);
        print(++d);

        score = score + 10;
        score += 10;
        print(num1 > num2);
        print(num1 < num2);
        print(num1 >= num2);
        print(num1 <= num2);
        print(num1 == num2);
        print(num1 != num2);
    }
}
