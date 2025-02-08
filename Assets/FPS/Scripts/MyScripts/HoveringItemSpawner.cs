using System.Collections.Generic;
using UnityEngine;

namespace AG2189
{
    public class HoveringItemSpawner : MonoBehaviour
    {
        private string hoveringItemGOName = "HoveringItem_ScriptCreated";
        public int numberOfHoveringItems = 3;
        public List<GameObject> hoveringItemGameObjects;
        public List<HoveringItem> hoveringItemObjectsInGOs;
        public List<HoveringItem> hoveringItemObjectsWithoutGOs;

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //HoveringItem hoveringItem = new HoveringItem();
            //HoveringItem hoveringItem = GetComponent<HoveringItem>();

            for (int i = 0; i < numberOfHoveringItems; i++)
            {
                GameObject hoveringObject = new GameObject();
                hoveringObject.name = hoveringItemGOName;
                hoveringItemGameObjects.Add(hoveringObject);
                hoveringObject.AddComponent<HoveringItem>();

                HoveringItem hoveringItem = hoveringObject.GetComponent<HoveringItem>();
                hoveringItemObjectsInGOs.Add(hoveringItem);
                // hoveringItemObjectsInGOs.Add(hoveringObject.GetComponent<HoveringItem>()); //same thing
            }

            for (int i = 0; i < numberOfHoveringItems; i++)
            {
                HoveringItem hoveringItem = new HoveringItem();
                hoveringItemObjectsWithoutGOs.Add(hoveringItem);
            }

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}