using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("sound");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator sound()
    {
        
        yield return new WaitForSeconds(2);
        SoundManager.Instance.Play_SE(0, 0);

    }
}
