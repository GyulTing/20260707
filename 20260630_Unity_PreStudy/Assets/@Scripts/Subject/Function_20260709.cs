using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

//1. 변수 네이밍 규칙
// - 변수에는 띄어쓰기가 안됨
// - Camel Case, Snake case, Pascal Case
// - CamelCase (띄어쓰기 대신 앞글자 소문자 다음 글자 대문자)
// - isMultipulOfThree 
// - Snake Case (앞글자에 언더바)
// - is_multipul_of_three
// - PascalCase (CamelCase랑 같은데 앞글자만 대문자)
// - IsMultipulOfThree 

// C# 코딩 컨벤션
// Camel Case - 멥버 변수, 지역변수, 
// Pascal Case - 클래스명, 함수명
// 

public class Function_20260709 : MonoBehaviour
{
    private void Start()
    {
        int Score = 96;
        char Grade = CalcScore(Score);
        printStudentinfo(Score, Grade);
        //Debug.Log(Score + " 의 점수를 받은 학생의 등급은 " + CalcScore(Score) + "입니다.");
        //MultiCheak(Score);
        bool isMultipulofthree = IsMultipleofThree(Score);
        /*if (MultiCheak(Score) == true)
        {
            Debug.Log(Score + "은(는) 3의 배수입니다");
        }
        else
        {
            Debug.Log(Score + "은(는) 3의 배수가 아닙니다");
        }*/
        printisMultipleofThree(isMultipulofthree, Score);

        // 요구사항을 수행하는 기능
        // StartScoreCalculator()
        // 입력 - 점수만 받으면 됨
        // 출력 - x
        StartScoreCalculator(Score);

        // 원칙 : 관리포인트를 줄이는 방향으로 함수 설계
    }

    void StartScoreCalculator(int score)
    {
        char Grade = CalcScore(score);
        printStudentinfo(score, Grade);

        bool isMultipulofthree = IsMultipleofThree(score);
        printisMultipleofThree(isMultipulofthree, score);
    }

    char CalcScore(int score)
    {
        char grade = ' ';
        if (score <= 100 && score >= 0)
        {
            if (score > 95)
            {
                grade = 'A';
            }
            else if (score > 90)
            {
                grade = 'B';
            }
            else if (score > 85)
            {
                grade = 'C';
            }
            else if (score > 80)
            {
                grade = 'D';
            }
            else
            {
                grade = 'F';
            }
        }
        return grade;
    }

    /*bool MultiCheak(int score)
    {
        if (score % 3 == 0)
        { 
            return true;
        }
        else
        {
            return false;
        }
    }*/

    bool IsMultipleofThree(int score)
    {
        bool Result = false;
        if (score % 3 == 0)
        {
            Result = true;
        }
        else
        {
            Result = false;
        }
        return Result;
    }

    void MultiCheak(int score)
    {
        if (score % 3 == 0)
        {
            Debug.Log(score + "은(는) 3의 배수입니다");
        }
        else
        {
            Debug.Log(score + "은(는) 3의 배수가 아닙니다");
        }
    }

    // 학생의 점수와, 등급을 출력해주는 함수를 만들거임
    // 출력 - 없어도됨 (Debug.log를 수행하고 다른 결과를 받을 필요가 없음
    // 입력 - int 형 점수, char 형 등급

    void printStudentinfo(int _score, char _grade)
    {
        Debug.Log(_score + " 의 점수를 받은 학생의 등급은 " + _grade + "입니다.");
    }

    //
    // 입력 - bool 형 하나
    //        int 형 하나 (Score를 받을 녀석)
    // 출력 - 없음

    void printisMultipleofThree(bool isMultipleofthree, int Score)
    {
        if (isMultipleofthree)
        {
            Debug.Log(Score + "은(는) 3의 배수입니다");
        }
        else
        {
            Debug.Log(Score + "은(는) 3의 배수가 아닙니다");
        }
    }

    }
