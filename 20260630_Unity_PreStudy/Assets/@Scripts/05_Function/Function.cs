using UnityEngine;

public class Function : MonoBehaviour
{
    // Function
    // 함수 
    // 함수 <-> 기능의 단위

    public void Start()
    {
        
    }

    // 함수를 만들려면
    // 함수의 행동
    // 함수의 이름
    // 입력 (어떤 형태의 자료를 입력할건지 - 자료형 필요)
    // 출력 (어떤 형태의 자료를 출력할건지 - 자료형 필요)
    // 출력값의 자료형 / 함수의 이름 / (입력할것들)
    // {
    //     함수에서 실행할 행동
    //     return 출력값
    // }
    // 정수 값 2개를 입력으로 받아서
    // 더하기를 하고 
    // 더한값(정수)를 출력으로 내보내는
    // Add 라는 이름ㅇ을 가진 함수를 만들어봄

    int Add (int _a, int _b)
    {
        int result = _a + _b; 
        return result;
    }

}
