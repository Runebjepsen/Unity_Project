using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class DirectionTest
{
    [Test]
    public void North()
    {
        Assert.AreEqual(new Vector3(0, 1, 0), new Vector3(0, 1, 0));
    }
}
