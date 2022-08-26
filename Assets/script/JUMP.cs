using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JUMP : MonoBehaviour
{
    public GameObject start;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void jump()
    {
        SoundManager.Instance.Play_SE(0, 1);
    }
    public void kick()
    {
        SoundManager.Instance.Play_SE(0, 2);
        StartCoroutine("sound");
    }
    IEnumerator sound()
    {

        yield return new WaitForSeconds(1);
        start.SetActive(true);

    }
}
