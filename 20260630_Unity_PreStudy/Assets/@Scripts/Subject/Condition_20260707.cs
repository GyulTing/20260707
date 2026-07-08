using Unity.VisualScripting;
using UnityEditor;
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

        //1. 내가 받은 성적
        // - 성적이라는 변수를 하나 만들어 관리한다.
        //2. 성적은 - 0~100점까지 존재함
        // - 여기서 100이상 0이하는 예외 처리를 한다
        //3. 각 점수별 성적이 존재한다
        // - 각 파트별 점수를 나눠서 성적을 매긴다.
        //4. 3의 배수인지 확인해야한다
        // - 나머지 연산자를 이용해서 3의 배수인지 확인한다.

        /*int Student = 12;
        {
            if (Student >= 100 || Student <= 0)
                Debug.Log("점수 입력값 밖입니다.");

            else if (Student <= 100 && Student > 95)
            {
                Debug.Log(Student + "의점수는 A입니다");
            }
            else if (Student >= 95 && Student > 90)
            {
                Debug.Log(Student + "의점수는 b입니다");
            }
            else if (Student >= 90 && Student > 85)
            {
                Debug.Log(Student + "의점수는 c입니다");
            }
            else if (Student >= 85 && Student > 80)
            {
                Debug.Log(Student + "의점수는 d입니다");
            }
            else if (Student >= 80 && Student >= 0)
            {
                Debug.Log(Student + "의점수는 f입니다");
            }
            else
            {
                Debug.Log("점수의 입력을 잘못했습니다.");
            }
        }

        if (Student % 3 == 0)
        {
            Debug.Log(Student + "의 점수는 3의 배수입니다");
        }
        else
        {
            Debug.Log(Student + "의 점수는 3가 배수가 아닙니다");
        }

        //---------------------------------------------------------------------------//

        /*int Student = 97;
        if (Student >= 100 && Student >= 95 && Student % 3 == 0)
        {
            Debug.Log(Student + "의점수는 A입니다 그리고 3의 배수입니다.");
            if (Student >= 100 && Student >= 95 && Student % 3 != 0)
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

        //-------------------------------------------------------------------------------//

        int score = 93;
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

        Debug.Log(score + "점을 받은 학생의 등급은 " + grade + "입니다.");

        //잘라내기 단축키는 ctrl + x 
        if (score % 3 ==0)
        {
            Debug.Log(score + "은(는) 3의 배수입니다");
        }
        else
        {
            Debug.Log(score + "은(는) 3의 배수가 아닙니다");
        }

    }
}
