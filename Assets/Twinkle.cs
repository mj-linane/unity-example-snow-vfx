using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Twinkle : MonoBehaviour
{

  Light lt;

  private float minDim = 12;

  private float currentDim;

  private float step = 0.75f;
  private float maxDim = 16;


  // Start is called before the first frame update
  void Start()
  {
    lt = GetComponent<Light>();
    lt.intensity = minDim;

  }

  // Update is called once per frame
  void Update()
  {
    if (currentDim < maxDim)
    {
      currentDim += step;
    }

    else
    {
      currentDim = minDim;
    }

    lt.intensity = currentDim;
  }

}
