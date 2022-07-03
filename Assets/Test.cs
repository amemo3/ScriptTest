using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[] array = { 50, 30, 20, 100, 60 };

        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[i]);
        }
        for(int j=array.Length-1; 0<=j; j--)
        {
            Debug.Log(array[j]);
        }
        Boss lastboss = new Boss();
        for (int k = 0; k < 11; k++)
        {
            lastboss.Magic();
        }
  }
    public class Boss
    {
        int mp = 53;

        public void Magic()
        {
            if(mp>5)
            {
                mp -= 5;
                Debug.Log("魔法攻撃をした。残りMPは"+mp);
            }
            else
            {
                Debug.Log("MPが足りないため魔法が使えない");
            }
                   
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
