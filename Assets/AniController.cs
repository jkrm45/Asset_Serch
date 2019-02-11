using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AniController : MonoBehaviour
{
    private static AniController _instance = null;
    public static AniController Instance { get { return _instance; } }
    public Animator AniControll;
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
    }

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
}
