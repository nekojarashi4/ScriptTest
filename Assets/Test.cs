using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int hp = 100;
    private int power = 25;
    int mp = 53;


    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた！");

    }

    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた！");
        this.hp -= damage;

    }

    public void Magic()
    {

        if (mp >= 10)
        {
            this.mp -= 8;
            Debug.Log("魔法攻撃をした。残りMPは" + mp + "。");
        }
        else
        {
            Debug.Log("MPが足りないため魔法が使えない。");

        }
        

    }
}


public class Test : MonoBehaviour {

    void Start()
    {
        Boss lastboss = new Boss();

        lastboss.Attack();

        lastboss.Defence(3);


        for (int i = 0; i <= 9; i++)
        {
            if (i <= 10)
            {
                lastboss.Magic();
            }
        }
        




        int[] array = { 12, 24, 36, 48, 60 };

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] >= 0)
            {
                Debug.Log(array[i]);
            }
        }
        for (int i = array.Length-1; i>=0; i--)
            //調べて-1にしましたが、理由がよくわかりません
        {
            if (array[i] > 0)
            {
                Debug.Log(array[i]);
            }
        }
    }
}


