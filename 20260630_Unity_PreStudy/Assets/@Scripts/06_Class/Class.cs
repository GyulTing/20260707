using UnityEngine;
using UnityEngine.Rendering;

// Class -> 어떤 작은 물건을 만들기 위한 설계도
// Class -> 분류
// 자동차
//1. 페달

//2. 핸들손잡이 
//3. 핸들 가죽

//4. 엔진 나사
//5. 엔진 기름
// class에는 같은 정보들이 들어가있음 -> 변수
// class에는 특정 기능이 있어야 함 -> 함수
//-> class는 같은 속성을 가진 변수와 함수의 집합
// 엔진이라는 분류를 만들었음
//-> Engine 이라는 이름을 가진 class
//-> Engine이라는 class에는
//   Engine을 구성하는 정보와 엔진의 기능이 정의되어 있음
//   Engine을 구성하는 변수와 함수가 존재한다.

//-> class안에 존재하는 변수와 함수를
// 멤버 변수, 멤버 함수 라고 부름

// 모니터
//1. 화면을 보여주는 역할 (144hz) - 변수, 함수
//2. 제조사 : 삼성 - 변수, 함수 
// 마우스
//1. 좌클릭 했을때, 좌클릭! 이라는 문구를 띄어주고
//2. 우클릭 했을때, 우클릭! 이라는 문구를 띄어주고
//3. 마우스 휠을 굴렸을때, 휠 굴림! 이라는 문구를 띄어주기
//4. 제조사 : 로지텍
// 키보드
public class Class : MonoBehaviour
{

        //    int monitorRate = 144;
        //    string monitorBrand = "삼성";
        //    DisplayMonitor(monitorRate);
        //    PrintMonitorBrand(monitorBrand);

        //    string mouseBrand = "로지텍";
        //    ClickMouseLeft();
        //    ClickMouseRight();
        //    ScrollMouseWheel();
        //    printMouseBrand(mouseBrand);
        //}
        //// 모니터를 출력하는 함수
        //void DisplayMonitor(int hz)
        //{
        //    //144hz로 모니터 출력 시작!
        //    Debug.Log(hz + "hz로 모니터 출력 시작!");
        //}
        //// 모니터의 제조사를 출력하는 함수
        //void PrintMonitorBrand(string brand)
        //{
        //    //이 모니터는 삼성입니다.
        //    Debug.Log("이 모니터의 브랜드는 " + brand + "입니다!");
        //}

        ////좌클릭 했을때 사용할 함수
        //void ClickMouseLeft()
        //{
        //    Debug.Log("마우스 좌클림됨");
        //}
        ////우클릭 했을때 사용할 함수
        //void ClickMouseRight()
        //{
        //    Debug.Log("마우스 우클림됨");
        //}
        ////마우스 휠 움직였을때 사용할 함수
        //void ScrollMouseWheel()
        //{
        //    Debug.Log("마우스 휠 움직임");
        //}
        ////마우스 브랜드를 출력하는 함수
        //void printMouseBrand(string brand)
        //{
        //    Debug.Log("이 마우스의 브랜드는 " + brand + "입니다");
        //}

    

    private void Start()
    {
        //분류를 하긴 했는데
        //실행을 할려고 보니까
        //class라는 class에는 아무것도 없음
        //기능이나 변수들이 다른 class로 넘어갔기 때문
        //class -> 설계도
        //설계도를 바탕으로 어떤 객체를 만들거임

        //Monitor라는 설계도를 가지고 모니터르 만든거임
        Monitor monitor = new Monitor();
        // 멤버 접근 연산자 (.)
        // monitor 라는 객체 안에 있는 멤버 함수인
        // DisplayMonitor() 라는 함수를 사용(호출)하고 싶음
        // monitor에 멤버 접근 연산자 . 을 사용해서
        // 그 안에 있는 멤버 함수인 DisplayMonitor()를 호출
        monitor.DisplayMonitor();
        monitor.PrintMonitorBrand();
        //string monitoBrand = monitor.monitorBrand;
        //string monitoBrand = monitor.GetMonitorBrand();
        //monitor.monitorBrand = "LG";
        monitor.SetMonitorBrand("LG");
        Debug.Log(monitor.monitorBrand);

        // 멤버 변수에 접근해서 값을 바꿔야하는 경우도 생김
        // 이때, 멤버 변수 보다는 멤버 함수를 사용해서
        // 값을 바꾸는 방식을 권장함
        // 이유는 함수를 사용해서 구현해야, 기능의 확장이 일어남
        // 이때, 관리 포인트가 함수 1개로 특정되기 때문임
        // 변수를 사용해서 기능을 확장하려고 하면, 변수를
        // 사용한 모든 곳을 찾아가서 기능을 확장해줘야 함
        // 관리포인트가 변수를 사용한 모든곳이 됨 - 퇴근 못함

        Mouse mouse = new Mouse();
        mouse.ClickMouseLeft();
        mouse.ClickMouseRight();
        mouse.ScrollMouseWheel();
        mouse.printMouseBrand();

        // 이전에는 class라는 class에 마우스의 기능과
        // 모니터의 기능이 정의되어 있었음
        // 즉, class가 모니터의 기능과 마우스의 기능을 
        // 관리하는 중이였음
        // 하지만 이것을 Monitor라는 클래스, mouse라는
        // 클래스로 옮기니까, 더이상 calss는 monitor와 mouse의 구현이 어떻게 되어있는지 몰라도 됨
        // 그냥 monitor와 mouse에 정의된 함수만 호출하면 기능을 함
        // 또한, monitor가 고장났다면 monitor 가 고장났다면 monitor 클래스만 확인하면 됨
        // 이러한 특징을 "캡슐화" 라고 함
    }
}

class Monitor // 모니터 분류(Class)
{
    // 전역변수 (global variable) (클래스 멤버변수라고도 함)
    // 지금까지 배운 지역 변수로는 함수 밖에서 어떤 변수를 사용하려고 하면
    // 입력을 만들어서 처리하는 방식밖엔 없었음
    // 하지만, 클래스라는 개념이 도입되면서, 하나의 객체에 대한 정보를 
    // 모든 함수가 공유해야해하는 상황이 발생했음
    // 그래서 전역변수를 만들어서 다른 함수에서 변수를 사용할 수 있도록 함
    private int monitorRate = 144;
    public string monitorBrand = "삼성";

    // Getter/Setter 함수
    // 멤버 변수의 값을 자겨오거나 수정할때 사용하는 함수를 통상 Getter Setter라고 함

    // monitorBrand 라는 값을 
    // 변수가 아니라 함수로 가져오고 싶음
    public string GetMonitorBrand()
    {
        return monitorBrand;
    }
    // monitorBrand 라는 값을
    // 변수가 아니라 함수로 값을 바꾸고 싶음
    // 출력 - X
    // 입력 - 바꾸고 싶은 값을 받으면 될듯 string
    // Debug.Log("--------------"); 도 달아줘야 함
    public void SetMonitorBrand(string newMonitorBrand)
    {
        Debug.Log("--------------");
        monitorBrand = newMonitorBrand;
    }

    // 접근 제한자
    // public, private, protected, internal
    // C#에서는 접근 제한자가 없으면
    // 기본값으로 private이 붙음
    public void DisplayMonitor()
    {
        //144hz로 모니터 출력 시작!
        Debug.Log(monitorRate + "hz로 모니터 출력 시작!");
    }
    // 모니터의 제조사를 출력하는 함수
    public void PrintMonitorBrand()
    {
        //이 모니터는 삼성입니다.
        Debug.Log("이 모니터의 브랜드는 " + monitorBrand + "입니다!");
    }
}
class Mouse// 마우스 분류(Class)
{
    string mouseBrand = "로지텍";
    //좌클릭 했을때 사용할 함수
    public void ClickMouseLeft()
    {
        Debug.Log("마우스 좌클림됨");
    }
    //우클릭 했을때 사용할 함수
    public void ClickMouseRight()
    {
        Debug.Log("마우스 우클림됨");
    }
    //마우스 휠 움직였을때 사용할 함수
    public void ScrollMouseWheel()
    {
        Debug.Log("마우스 휠 움직임");
    }
    //마우스 브랜드를 출력하는 함수
    public void printMouseBrand()
    {
        Debug.Log("이 마우스의 브랜드는 " + mouseBrand + "입니다");
    }
}
