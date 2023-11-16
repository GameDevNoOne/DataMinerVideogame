using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerAbilities : MonoBehaviour
{
    [Header("Other")]
    public Transform shootPoint;
    public GameObject[] bullets;

    [Header("States")]
    public bool Fire;
    public bool Electricity;
    public bool Gravity;
    public bool Basic;

    [Header("Stats")]
    public float[] FireDamage;
    public float[] FireRange;
    public float[] FireSpeed;

    public float[] ElectricDamage;
    public float[] ElectricRange;
    public float[] ElectricSpeed;

    public float[] GravityDamage;
    public float[] GravityRange;
    public float[] GravitySpeed;

    public float[] Damage;
    public float[] Range;
    public float[] Speed;

    [Header("Animation")]
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        Fire = gameObject.GetComponent<Powers>().stateFire;
        Electricity = gameObject.GetComponent <Powers>().stateElectricity;
        Gravity = gameObject.GetComponent<Powers>().stateGravity;
        Basic = gameObject.GetComponent<Powers>().basicState;
    }

    // Update is called once per frame
    void Update()
    {
        Fire = gameObject.GetComponent<Powers>().stateFire;
        Electricity = gameObject.GetComponent<Powers>().stateElectricity;
        Gravity = gameObject.GetComponent<Powers>().stateGravity;
        Basic = gameObject.GetComponent<Powers>().basicState;

        if (Fire)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                FireAbility1();
            }
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                FireAbility2();
            }
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                FireAbility3();
            }
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                FireAbility4();
            }
        }
        else if (Electricity)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                ElectricAbility1();
            }
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                ElectricAbility2();
            }
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                ElectricAbility3();
            }
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                ElectricAbility4();
            }
        }
        else if (Gravity)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                GravityAbility1();
            }
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                GravityAbility2();
            }
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                GravityAbility3();
            }
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                GravityAbility4();
            }
        }
        else if (Basic)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                BasicAbility1();
            }
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                BasicAbility2();
            }
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                BasicAbility3();
            }
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                BasicAbility4();
            }
        }
    }

    //ShortRange bursts
    public void FireAbility1()
    {
        float damage = FireDamage[0];
        float range = FireRange[0];
        float speed = FireSpeed[0];
        Instantiate(bullets[0], shootPoint);
    }
    //Mid range flame wall
    public void FireAbility2()
    {
        float damage = FireDamage[1];
        float range = FireRange[1];
        float speed = FireSpeed[1];
    }
    //Long range FIREBALL!!
    public void FireAbility3()
    {
        float damage = FireDamage[2];
        float range = FireRange[2];
        float speed = FireSpeed[2];
    }
    //ULTIMATE
    public void FireAbility4()
    {
        float damage = FireDamage[3];
        float range = FireRange[3];
        float speed = FireSpeed[3];
    }

    //Short range burst
    public void ElectricAbility1()
    {
        float damage = ElectricDamage[0];
        float range = ElectricRange[0];
        float speed = ElectricSpeed[0];
    }
    //ElectricField
    public void ElectricAbility2()
    {
        float damage = ElectricDamage[1];
        float range = ElectricRange[1];
        float speed = ElectricSpeed[1];
    }
    //I am PALPATINE
    public void ElectricAbility3()
    {
        float damage = ElectricDamage[2];
        float range = ElectricRange[2];
        float speed = ElectricSpeed[2];
    }
    //UNLIMITED POWAAAAAA!!!!
    public void ElectricAbility4()
    {
        float damage = ElectricDamage[3];
        float range = ElectricRange[3];
        float speed = ElectricSpeed[3];
    }

    //Blast
    public void GravityAbility1()
    {
        float damage = GravityDamage[0];
        float range = GravityRange[0];
        float speed = GravitySpeed[0];
    }
    //Self change
    public void GravityAbility2()
    {
        float damage = GravityDamage[1];
        float range = GravityRange[1];
        float speed = GravitySpeed[1];
    }
    //Gravity field
    public void GravityAbility3()
    {
        float damage = GravityDamage[2];
        float range = GravityRange[2];
        float speed = GravitySpeed[2];
    }
    //RADAHN!!!!
    public void GravityAbility4()
    {
        float damage = GravityDamage[3];
        float range = GravityRange[3];
        float speed = GravitySpeed[3];
    }

    //Basic blast
    public void BasicAbility1()
    {
        float damage = Damage[0];
        float range = Range[0];
        float speed = Speed[0];
    }
    //Basic burstt
    public void BasicAbility2()
    {
        float damage = Damage[1];
        float range = Range[1];
        float speed = Speed[1];
    }
    //Basic explosion
    public void BasicAbility3()
    {
        float damage = Damage[2];
        float range = Range[2];
        float speed = Speed[2];
    }
    //Bigger Basic explosion
    public void BasicAbility4()
    {
        float damage = Damage[3];
        float range = Range[3];
        float speed = Speed[3];
    }
}
