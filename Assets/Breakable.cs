using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using UnityEngine.Events;

public class Breakable : MonoBehaviour
{
    public List<GameObject> breakablePieces;
    public float timetoBreak = 5;
    private  float timer = 0;
    public UnityEvent onBreak;
    // Start is called once bfore the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        foreach(var item in breakablePieces)
        {
            item.SetActive(false);  
        }
    }

    // Update is called once per frame
    public void Break()
    {
        timer += Time.deltaTime;

        if (timer < timetoBreak)
        {
            foreach (var item in breakablePieces)
            {
                item.SetActive(true);
                item.transform.parent = null;
            }

            onBreak.Invoke();

            gameObject.SetActive(false);
        }
          

    }
}
