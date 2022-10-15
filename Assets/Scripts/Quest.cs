using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Quest : MonoBehaviour
{
    public Image questItem;
    public Color completedColor;
    public Color activeColor;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("items"))
            FinishQuest();
        Debug.Log("Triggered");
    }

    void FinishQuest()
    {
        questItem.color = completedColor;
    }
}
