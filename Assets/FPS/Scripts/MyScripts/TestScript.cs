using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows;


namespace AG2189
{
    public class TestScript : MonoBehaviour
    {
        public KeyCode activationKey = KeyCode.T;

        [SerializeField] private GameObject m_target;
        [SerializeField] private float justANumber = 5.0f;
        [SerializeField] private List<GameObject> listOfObjects;
        [SerializeField] private GameObject[] gameObjects;

        public float x = 0;
        [SerializeField] private Transform target;
        public bool enabledBool = false;

        private void Awake()
        {
            //Do stuff before Start()
        }

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        private void Start()
        {
            m_target = FindAnyObjectByType<DiceManager>().gameObject;
        }

        // Update is called once per frame
        private void Update()
        {
            Debug.Log("Running update");
            //if (Mouse.current.rightButton.wasPressedThisFrame) //(UnityEngine.Input.GetKeyDown(activationKey)
            {
                enabledBool = !enabledBool;
                CustomMethodOfExcellence();
            }
        }

        private void CustomMethodOfExcellence()
        {
            x = 5.0f;
            target = transform;
            m_target.SetActive(enabledBool);
            Debug.Log("Nice variable value: " + x);
            justANumber += justANumber;
        }
    }
}
