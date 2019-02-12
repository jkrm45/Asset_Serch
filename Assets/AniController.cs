using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AniController : MonoBehaviour
{
    private static AniController _instance = null;
    public static AniController Instance { get { return _instance; } }
    public Animator AniControll;
    public Transform Player;
    public int Job = 1;
    // Start is called before the first frame update

    private void Awake()
    {
        _instance = this;
    }
    void Start()
    {

        AniControll = GameObject.Find("Player").GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Chrickidle();
        RunOff();
        WalkOff();
        AttackOff();
        DrinkOff();
        Eatpoff();
        Changeoff();
        PickUpoff();
        if (Input.GetKey(KeyCode.UpArrow))
        {
           Player.Translate(0, 0, 4 * Time.deltaTime);
            RunOn();
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            Player.Translate(0, 0, -4 * Time.deltaTime);
            RunOn();
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Player.Translate(-4 * Time.deltaTime, 0,0);
            WalkOn();
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Player.Translate(4 * Time.deltaTime, 0, 0);
            WalkOn();
        }
        if (Input.GetKey(KeyCode.Space))
        {
            DeadOn();
        }
        if (Input.GetKey(KeyCode.A))
        {
            AttackOn();
        }
        if (Input.GetKey(KeyCode.Z))
        {
            PickUpOn();
        }
        if (Input.GetKey(KeyCode.X))
        {
            DrinkOn();
        }
        if (Input.GetKey(KeyCode.C))
        {
            EatOn();
        }
        if (Input.GetKey(KeyCode.F))
        {
            ChangeOn();
        }
    }
    //key값"  swordmove , swordbackmove  , swordattack  , sworddeath
    //key값  Archermove , Archerbackmove , Archerattack  , Archerdeath
    //key 값  Magicmove , Magicbackmove , Magicattack ,  Magicdeath
    //key 값 Drink , Eat , Pickup , Change


    public void Chrickidle() //애니메이션 종류선택
    {
        if (Job == 1)
        {
            AniControll.SetBool("SwardMan", true);
            AniControll.SetBool("Archer", false);
            AniControll.SetBool("Magic", false);

        }
        if (Job == 2)
        {
            AniControll.SetBool("SwardMan", false);
            AniControll.SetBool("Archer", true);
            AniControll.SetBool("Magic", false);
        }
        if (Job == 3)
        {
            AniControll.SetBool("SwardMan", false);
            AniControll.SetBool("Archer", false);
            AniControll.SetBool("Magic", true);
        }
    }

    public void RunOn() // 달리기 불값 
    {
        AniControll.SetBool("swordmove", true);
        AniControll.SetBool("Archermove", true);
        AniControll.SetBool("Magicmove", true);
    }
    public void RunOff()
    {
        AniControll.SetBool("swordmove", false);
        AniControll.SetBool("Archermove", false);
        AniControll.SetBool("Magicmove", false);
    }


    public void WalkOn()//천천히 걷기
    {
        AniControll.SetBool("swordbackmove", true);
        AniControll.SetBool("Archerbackmove", true);
        AniControll.SetBool("Magicbackmove", true);
    }
    public void WalkOff()
    {
        AniControll.SetBool("swordbackmove", false);
        AniControll.SetBool("Archerbackmove", false);
        AniControll.SetBool("Magicbackmove", false);
    }

    public void AttackOn() //어택 함수호출
    {
        AniControll.SetBool("swordattack", true);
        AniControll.SetBool("Archerattack", true);
        AniControll.SetBool("Magicattack", true);
    }
    public void AttackOff()
    {
        AniControll.SetBool("swordattack", false);
        AniControll.SetBool("Archerattack", false);
        AniControll.SetBool("Magicattack", false);
    }

    public void DeadOn()  //죽는모션호출
    {
        AniControll.SetBool("sworddeath", true);
        AniControll.SetBool("Archerdeath", true);
        AniControll.SetBool("Magicdeath", true);
    }
    public void DeadOff()
    {
        AniControll.SetBool("sworddeath", false);
        AniControll.SetBool("Archerdeath", false);
        AniControll.SetBool("Magicdeath", false);
    }


    public void DrinkOn()//마시는 모션
    {
        AniControll.SetBool("Drink", true);
    }
    public void DrinkOff()
    {
        AniControll.SetBool("Drink", false);
    }

    public void PickUpOn()//줍는모션
    {
        AniControll.SetBool("Pickup", true);
    }
    public void PickUpoff()
    {
        AniControll.SetBool("Pickup", false);
    }

    public void EatOn()//먹는 모션
    {
        AniControll.SetBool("Eat", true);
    }
    public void Eatpoff()
    {
        AniControll.SetBool("Eat", false);
    }
    public void ChangeOn()//바꾸는 모션
    {
        AniControll.SetBool("Change", true);
    }
    public void Changeoff()
    {
        AniControll.SetBool("Change", false);
    }






}
