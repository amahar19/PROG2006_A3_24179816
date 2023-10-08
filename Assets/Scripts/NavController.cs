using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SeamlessScrolling : MonoBehaviour
{
    public float scrollSpeed = 1.0f;
    private RectTransform contentRect;

    private void Start()
    {
        contentRect = GetComponent<RectTransform>();
    }

    private void Update()
    {
        float offset = Mathf.Repeat(Time.time * scrollSpeed, contentRect.sizeDelta.y);
        contentRect.anchoredPosition = new Vector2(contentRect.anchoredPosition.x, -offset);
    }
}
public class NavController : MonoBehaviour
{
   public void LoadMyScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
        
    public void LoadMyScene(int sceneNumber)
    {
        SceneManager.LoadScene(sceneNumber);
    }
}

