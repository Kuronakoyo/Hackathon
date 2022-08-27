using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
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
        if (Input.GetMouseButtonDown(0))    // 左マウスボタンをクリックしたら
        {
            SceneManager.LoadScene("HitboxTest");    // GameSceneに移動
        }
    }
    IEnumerator sound()
    {
        
        yield return new WaitForSeconds(2);
        SoundManager.Instance.Play_SE(0, 0);

    }
}
