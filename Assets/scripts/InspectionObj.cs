using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InspectionObj : MonoBehaviour
{
   public GameObject[] inspectionObject;
   private int currIndex;

   public void TurnOnInspection(int index)
   {
       currIndex = index;
       inspectionObject[index].SetActive(true);

   }
   public void TurnOffInspection()
   {
       inspectionObject[currIndex].SetActive(false);
   }
}
