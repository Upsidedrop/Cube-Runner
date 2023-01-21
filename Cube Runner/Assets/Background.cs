using UnityEngine;
using UnityEngine.SceneManagement;

public class Background : MonoBehaviour
{
    public Transform Background1;
    public Transform Background2;

    private bool whichOne;

    public Transform cam;

    float currentpos = 40;

    void Update()
    {
        if (currentpos < cam.position.x)
        {
            if (whichOne)
                Background2.localPosition = new Vector3(Background2.localPosition.x + 80, 0);
            
            else
                Background1.localPosition = new Vector3(Background1.localPosition.x + 80, 0);

            
            currentpos += 40;
            
            whichOne = !whichOne;
        }
        if (currentpos > cam.position.x + 40)
        {
            if (whichOne)
                Background1.localPosition = new Vector3(Background1.localPosition.x - 80, 0);
            else
                Background2.localPosition = new Vector3(Background2.localPosition.x - 80, 0);
            

            currentpos -= 40;

            whichOne = !whichOne;
        }
        
    }
}
