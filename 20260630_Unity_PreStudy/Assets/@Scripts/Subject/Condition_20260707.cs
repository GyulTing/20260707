using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Condition_20260707 : MonoBehaviour
{
    private void Start()
    {
        // 과제 1 
        // 성적처리기 
        // 내가 받은 성적이 있고 거기에 따라서 
        // A,B,C,D,F 라고 성적을 메길거임
        // 성적은 - 0~100점까지 존재함
        // 100포함 ~95 미포함 점까지 A
        // 95     ~90 b
        // 90     ~85 c
        // 85     ~80 d
        // 그외 점수   f

        // 마지막에 그 성적이 3의 배수인지 아닌지 출력해보세요

        // 출력예시 : 
        // 98점을 받은 학생의 점수는 A입니다.
        // 98은 3의 배수가 아닙니다.

        int Student = 101;
        if (Student <= 100 || Student >= 95)
        {
            Debug.Log(Student + "의점수는 A입니다");
        }
        else if (Student >= 95 || Student >= 90)
        {
            Debug.Log(Student + "의점수는 b입니다");
        }
        else if (Student >= 90 || Student >= 85)
        {
            Debug.Log(Student + "의점수는 c입니다");
        }
        else if (Student >= 85 || Student >= 80)
        {
           Debug.Log(Student + "의점수는 d입니다");
        }
        else if (Student >= 80 || Student >= 0)
        {
            Debug.Log(Student + "의점수는 f입니다");
        }
        else
        {
            Debug.Log("점수의 입력을 잘못했습니다.");
        }


        if (Student % 3 == 0)
        {
            Debug.Log(Student + "의 점수는 3의 배수입니다");
        }
        else
        {
            Debug.Log(Student + "의 점수는 3가 아닙니다");
        }

        /*int Student = 97;
        if (Student >= 100 || Student >= 95) //&& Student % 3 == 0//)
        {
            Debug.Log(Student + "의점수는 A입니다 그리고 3의 배수입니다.");
            if (Student >= 100 || Student >= 95) //&& Student % 3 != 0)
            {
                Debug.Log(Student + "의점수는 A입니다 그리고 3의 배수가 아닙니다.");
            }
        }
        /*else if (Student >= 95 && Student >= 90)
        {
            Debug.Log(Student + "의점수는 b입니다");
        }
        else if (Student >= 90 && Student >= 85)
        {
            Debug.Log(Student + "의점수는 c입니다");
        }
        else if (Student >= 85 && Student >= 80)
        {
            Debug.Log(Student + "의점수는 d입니다");
        }
        else
        {
            Debug.Log(Student + "의점수는 f입니다");
        }


        if (Student % 3 == 0)
        {
            Debug.Log(Student + "의 점수는 3의 배수입니다");
        }
        else
        {
            Debug.Log(Student + "의 점수는 3가 아닙니다");
        }*/
    }
}
