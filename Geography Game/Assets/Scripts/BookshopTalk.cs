using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookshopTalk : MonoBehaviour
{
    public string description;
    public int currentamount;
    public int requiredamount;
    public bool completed;

    public void Update()
    {
        Evaluate();
        if(completed == true)
        {
            StateNameController.townProgress += 5;
        }
    }

    public void Evaluate()
    {
        if(currentamount >= requiredamount)
        {
            Complete();
        }
    }
    public void Complete()
    {
        completed = true;
    }
    public void addAmount()
    {
        currentamount += 1;
    }
}
