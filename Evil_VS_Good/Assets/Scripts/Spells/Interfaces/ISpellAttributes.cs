using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ISpellAttributes
{
    public float ManaCost  { get; set; }
    public GameObject SelectedTarget { get; set; }

}
