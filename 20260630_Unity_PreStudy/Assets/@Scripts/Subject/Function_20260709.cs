using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Function_20260709 : MonoBehaviour
{
    private void Start()
    {
        int Score = 96;
        Debug.Log(Score + " 의 점수를 받은 학생의 등급은 " + CalcScore(Score) + "입니다.");
        MultiCheak(Score);
        /*if (MultiCheak(Score) == true)
        {
            Debug.Log(Score + "은(는) 3의 배수입니다");
        }
        else
        {
            Debug.Log(Score + "은(는) 3의 배수가 아닙니다");
        }*/
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

    }
