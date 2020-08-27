using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class DragDropRelease : MonoBehaviour, IDragHandler
{

    private RectTransform rectTransform;
    [SerializeField] private Canvas canvas;
    public bool isMotionDone;
    public bool win;
    public quizManager qm;
    public GameObject correct;
    public GameObject wrong;
    public GameObject success;
    public bool moving;

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        
    }

    void Start()
    {
        isMotionDone = false;
        win = false;
        moving = false;
    }

    public void Update()
    {
        if (Input.GetMouseButtonUp(0) && moving == true)
        {
            isMotionDone = true;
            CheckIfWinOrLose();
        }
    }

    public void OnDrag(PointerEventData eventData)
    {
        rectTransform.anchoredPosition += eventData.delta;
        moving = true;
        
    }

    void CheckIfWinOrLose()
    {
        if (win)
        {
            StartCoroutine(userPickCorrect());
        }

        else 
        {
            StartCoroutine(userPickWrong());
        }

    }

    public void OnTriggerEnter2D(Collider2D col)
    {
        win = true;
    }

    public void OnTriggerExit2D(Collider2D col)
    {
        win = false;
    }

    public IEnumerator userPickCorrect()
    {
        qm.CorrectAnswer();
        correct.transform.gameObject.SetActive(true);
        yield return new WaitForSeconds(2.5f);
        success.SetActive(true);
    }

    public IEnumerator userPickWrong()
    {
        qm.WrongAnswer();
        wrong.transform.gameObject.SetActive(true);
        yield return new WaitForSeconds(2.5f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }
}
