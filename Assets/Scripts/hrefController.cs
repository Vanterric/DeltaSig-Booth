using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hrefController : MonoBehaviour
{
    // Start is called before the first frame update
    public void goToInsta()
    {
        Application.OpenURL("https://www.instagram.com/deltasigfiu/");
    }

    public void goToFund()
    {
        Application.OpenURL("https://www.gofundme.com/f/ymr8vf-the-red-cross?utm_source=customer&utm_medium=copy_link&utm_campaign=p_cf+share-flow-1");
    }

    public void goToMainSite()
    {
        Application.OpenURL("https://www.deltasigfiu.com/");
    }
}
