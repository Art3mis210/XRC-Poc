using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public int count = 0;
    public TMPro.TextMeshProUGUI score;
    public List<bool> checkList = new List<bool>();
    public List<Image> marks = new List<Image>();

    private void Awake()
    {
        if(instance!=null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }
    }
    private void Update()
    {
        score.text = count.ToString();
    }

    public void CheckBool(int n)
    {
        checkList[n] = true;
        marks[n].color = Color.green;
    }
    public void CheckSteps(int n)
    {
        if(n == 0)
        {
            if (checkList[0] == false)
            {
                count = count - 10;
                Debug.Log("Wrong");
            }
            else
            {
                count = count + 10;
                Debug.Log("Right");
            }
        }
        for(int i =0;i<n;i++)
        {
            if (checkList[i] == false)
            {
                count = count - 10;
                Debug.Log("Wrong");
            }
            else
            {
                count = count + 10;
                Debug.Log("Right");
            }
        }
    }
}
