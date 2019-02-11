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
           
        }
        if (Input.GetKey(KeyCode.X))
        {
            AttackOn();
        }
        if (Input.GetKey(KeyCode.Z))
        {
            DeadOn();
        }
    }
    //key값"  swordmove , swordbackmove  , swordattack , swordstunned , sworddeath
    //key값  Archermove , Archerbackmove , Archerattack , Archerstunned , Archerdeath
    //key 값  Magicmove , Magicbackmove , Magicattack , Magicstunned ,  Magicdeath


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








}
