using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellCollection : MonoBehaviour
{
    [SerializeField] private GameObject fireball;
    [SerializeField] private int testInt;
    
    public GameObject Fireball
    {
        get { return fireball; }
        private set { fireball = value; }
    }
    public int TestInt
    {
        get { return testInt; }
        private set { testInt = value; }
    }
}
