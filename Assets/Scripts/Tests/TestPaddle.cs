using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class TestPaddle
    {
        // A Test behaves as an ordinary method
        [Test]
        public void TestPaddleMove()
        {
            // Use the Assert class to test conditions
            var go = new GameObject();
            var originalPosition = go.transform.position.x;
            for (float i = -1; i < 1; i = i + 0.1f)
            {
                //i refer to input.getAxis("Horizontal") value
                float xPos = go.transform.position.x + i;
                //-10 & 10 are xPosLimit
                go.transform.position = new Vector3(Mathf.Clamp(xPos, -10, 10), go.transform.position.y, go.transform.position.z);
                if (i == 0)
                {
                    //if i == 0 the player don't try to move the Paddle
                    //so the Paddle didn't move
                    Assert.AreEqual(originalPosition, go.transform.position.x);
                }
                else
                {
                    //if i != 0 the player try to move the Paddle
                    //so the Paddle isn't at the same position
                    Assert.AreNotEqual(originalPosition, go.transform.position.x);
                }
            }
        }
    }
}
