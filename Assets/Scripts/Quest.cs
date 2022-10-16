using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Quest : MonoBehaviour
{
    public Image questItem;
    public Color completedColor;
    public Color activeColor;
    public Color currentColor;
    //List<Image> list = new List<Image>();

    public Quest[] allQuests;
   
    
    private void Start()
    {
        allQuests = FindObjectsOfType<Quest>();
      
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("cart"))
            FinishQuest();
    }

    void FinishQuest()
    {
        questItem.GetComponent<Button>().interactable = false;
        currentColor = completedColor;
        questItem.color = completedColor;
        
    }

    public void OnQuestClick()
    { 
        foreach (Quest quest in allQuests)
        {
            quest.questItem.color = questItem.color;
        }
    questItem.color = activeColor;

    }


}
