using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using System.Threading.Tasks;

public class LightRotation : MonoBehaviour
{
    // Start is called before the first frame update
    async void Start()
    {
        await CameraLoop();
    }
    
    private async Task CameraLoop()
    {
        float i = 0;
        while (true)
        {
            transform.rotation = Quaternion.Euler(50f, i, 0f);

            await new WaitForEndOfFrame();
            i += 2f;
            if (i >= 360) i = 0 ;
        }
    }



}
