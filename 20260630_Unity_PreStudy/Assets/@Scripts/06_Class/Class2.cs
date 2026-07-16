using UnityEditor.Rendering;
using UnityEngine;

public class Class2 : MonoBehaviour
{
    private void Start()
    {
        // 아파트를 만들어봄
        // 아파트 설계도는 같고
        // 101동과 102동을 만든다고 생각해봄
        // 아파트에는 자기의 동수를 출력하는 기능이 있다
        //1. 이 아파트가 몇동인지에 대한 변수
        //2. 자신의 동수를 출력하는 함수

        Apartment101 apart101 = new Apartment101("101");
        Apartment101 apart102 = new Apartment101("102");
        Apartment101 apart103 = new Apartment101("103");
        Apartment101 apart104 = new Apartment101("104");
        Apartment101 apart105 = new Apartment101("105");
        Apartment101 apart106 = new Apartment101("106");
        Apartment101 apart107 = new Apartment101("107");
        //Apartment102 apart102 = new Apartment102();
        apart101.PrintBuildingNumber();
        apart102.PrintBuildingNumber();
        apart103.PrintBuildingNumber();
        apart104.PrintBuildingNumber();
        apart105.PrintBuildingNumber();
        apart106.PrintBuildingNumber();
        apart107.PrintBuildingNumber();
        //apart102.PrintBuildingNumber();


        // 객체를 생성했는데
        // 생성자를 사용해서 별도의 함수 호출 없이 
        // 객체가 생성될때, 특정 기능을 수핼하게 만들었음
        new Constructor(1);
        new Constructor(1,2);

    }
}

class Apartment101 //101동 설게도
{
    // 생성자
    // 이 클래스를 바탕으로 객체가 만들어질때
    // 반드시 한번 호출되는 함수
    // 같은 class 정보(번수나, 함수)인데, 특정 정보만
    // 다른 객체를 만들때 사용하면 좋음
    //ex1. 아파트는 설계는 같지만, 동호수만 다름
    //ex2. 모둔 플레이어의 설계는 같지만 닉네임만 다름
    //ex3. 모든 아이템의 설꼐는 같지만, 아이템의 이름만 다름
    public Apartment101(string buildingNumber)
    {
        this.buildingNumber = buildingNumber;
    }

    private string buildingNumber = "";

    public void PrintBuildingNumber()
    {
        Debug.Log("--이 아파트는 " + buildingNumber + "동입니다.");
    }
}

//class Apartment102 //102동 설계도
//{
//    private string buildingNumber = "102";
//    public void PrintBuildingNumber()
//    {
//        Debug.Log("이 아파트는 " + buildingNumber + "동입니다.");
//    }
//}

class Constructor // 생성자라는 이름을 가진 클래스
{
    // 이 클래스를 바탕으로 객체가 생성될때
    // 객체 생성됨! 이라는 문구를 띄우고 싶음

    // 생성자도 함수처럼 오버로딩이 가능하다
    public Constructor(int value)
    {
        Debug.Log("객체 생성됨"+value);
    }
    public Constructor(int value, int value2)
    {
        Debug.Log("객체 생성됨" + (value +value2));
    }

}