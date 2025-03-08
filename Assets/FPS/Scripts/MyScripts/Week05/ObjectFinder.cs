using UnityEngine;

namespace AG2189
{
    public class ObjectFinder : MonoBehaviour
    {
        [SerializeField] private GameObject targetForDragNDropWay;
        [SerializeField] private GameObject targetForNameFinding;
        [SerializeField] private GameObject targetForTagFinding;
        [SerializeField] private GameObject targetForTypeFinding;
        [SerializeField] private Dice[] targetsForFindingWithOfType;
        [SerializeField] private ThingToFind targetForGetComponentFinding;
        [SerializeField] private ThingToFind targetForGetComponentInChildrenFinding;



        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //targetForNameFinding = GameObject.Find("Moving Sphere");
            targetForTagFinding = GameObject.FindGameObjectWithTag("Enemy");
            targetForTypeFinding = GameObject.FindFirstObjectByType<ThingToFind>().gameObject;
            targetsForFindingWithOfType = GameObject.FindObjectsByType<Dice>(FindObjectsInactive.Include,FindObjectsSortMode.None);
            targetForGetComponentFinding = GetComponent<ThingToFind>();
            targetForGetComponentInChildrenFinding = GetComponentInChildren<ThingToFind>(true);
        }

    } 
}
