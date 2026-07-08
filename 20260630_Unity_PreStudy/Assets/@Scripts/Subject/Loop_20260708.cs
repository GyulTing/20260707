using System.Threading;
using UnityEngine;

public class Loop_20260708 : MonoBehaviour
{
    // 1. 구구단 만들기 
    // 1단부터 9단까지 구구단이 출력되도록 해보세요
    // 출력예시
    // 1단------
    // 1 x 1 = 1
    // 1 x 2 = 2
    // 1 x 3 = 3
    // ....
    // 1 x 9 = 9
    // 2단------
    // 2 x 1 = 2
    // ....

    // 2. 지뢰찾기
    // 가로 6칸 세로 5칸 인 지뢰판이 있다고 가정함 
    // 14번째, 19번째, 28번째 칸에 지뢰가 있다고 가정함
    // 지뢰가 총 3개이고, 3개의 지뢰를 모두 발견하면 게임 중단
    // 매칸 확일할때마다 xx칸 확인중... 을 출력
    // 지뢰를 찾을때 마다, "**칸에 있는 지뢰를 확인 완료!" 를 출력 하면됨

    // 3. star pyramid
    // *
    // **
    // ***
    // ****
    // *****
    // 1. Debug.log 쓰면 안됨
    // 2. 내가 100층짜리 피라미드를 만들고 싶을때
    //    변수만 100으로 바꿨을때, 피라미드가 완성되면 됨
    private void Start()
    {
        int Sum = 0;
        for (int y = 1; y <= 9; ++y) 
        {
            for (int x = 1; x <= 9; ++x)
            {
                {
                    Sum = y * x;
                    Debug.Log(y + " X "+ x + " = " + Sum);
                }
            }
        }

        Debug.Log("-----------------------------------");

        for (int y = 1; y <= 6; ++y)
        {
            for(int x = 1; x<=5; ++x)
            {
                int Mine = 0;
                int Count = 0;
                if (Mine == 14 || Mine == 19 || Mine == 28)
                {
                    Debug.Log(Mine + "지역에 지뢰 발견!!");
                    ++Count;
                }
                else if (Count == 3)
                {
                    Debug.Log("모든 지뢰를 찾았습니다!!!");
                    break;
                }
                else
                {
                    Debug.Log(Mine + "지역에 지뢰를 찾는중....");
                }
            }
        }

        Debug.Log("-----------------------------------");

        int Pyramid = 5;
        int Count2 = 1;
        for (int y = 1; y <= Pyramid; ++y)
        {
            for (int x = 1; x <= Count2; ++x)
            {
               Debug.Log("*");
                ++Count2;
            }
        }
    }
}
