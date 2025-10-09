using UnityEngine;

public class MyName : MonoBehaviour
{
   



    void Update()
    {
        //Letra A
        Debug.DrawLine(new Vector2(0, 0), new Vector2(0.40f, 0.5f));
        Debug.DrawLine(new Vector2(0.40f, 0.5f), new Vector2(0.75f,0));
        Debug.DrawLine(new Vector2(0.20f , 0.25f), new Vector2 (0.58f, 0.25f));
        //Letra I
        Debug.DrawLine(new Vector2(1.25f, 0), new Vector2(1.25f, 0.5f));
        Debug.DrawLine(new Vector2(1, 0), new Vector2(1.50f, 0));
        Debug.DrawLine(new Vector2(1, 0.5F), new Vector2(1.50f, 0.5F));
        //Letra T
        Debug.DrawLine(new Vector2(2, 0), new Vector2(2, 0.5f));
        Debug.DrawLine(new Vector2(1.75f, 0.5f), new Vector2(2.25f, 0.5f));
        //Letra O
        Debug.DrawLine(new Vector2(2.5f, 0.5f), new Vector2(3, 0.5f));
        Debug.DrawLine(new Vector2(2.5F, 0), new Vector2(3, 0));
        Debug.DrawLine(new Vector2(2.5F, 0), new Vector2(2.5f, 0.5f));
        Debug.DrawLine(new Vector2(3, 0), new Vector2(3, 0.5f));
        //Letra R
        Debug.DrawLine(new Vector2(3.25f,0), new Vector2(3.25f,0.5f));
        Debug.DrawLine(new Vector2(3.25f,0.5f), new Vector2(3.60f, 0.40f));
        Debug.DrawLine(new Vector2(3.60f, 0.40f), new Vector2(3.25f, 0.25f));
        Debug.DrawLine(new Vector2(3.25f, 0.25f), new Vector2(3.60f, 0));


    }
}
