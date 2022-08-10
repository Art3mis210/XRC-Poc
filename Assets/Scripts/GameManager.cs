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
    public AudioClip wrong, right;
    private AudioSource src;
    public List<Outline> tasks = new List<Outline>();

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

    private void Start()
    {
        src = GetComponent<AudioSource>();
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
        CheckBool(n);
        if (n == 0)
        {
                count = count + 10;
                src.clip = right;
                src.Play();
                TaskCheck(n);
        }
        else
        {

            for (int i = 0; i < n; i++)
            {
                if (checkList[i] == false)
                {
                    count = count - 10;
                    src.clip = wrong;
                    src.Play(); 
                    return;
                }
            }
            count = count + 10;
            src.clip = right;
            src.Play();
            TaskCheck(n);
        }

    }

    public void TaskCheck(int n)
    {
        for(int i = n;i<checkList.Count;i++)
        {
                if (checkList[i] == false)
                {
                    tasks[i].OutlineColor = Color.green;
                    return;
                }
        }
    }
}
