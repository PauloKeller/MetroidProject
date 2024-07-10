using UnityEngine;
using TMPro;

public class CraftController : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI metallicAmountLabel;
    CraftUseCase useCase;

    private void Awake()
    {
        useCase = new CraftUseCase();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void CraftItem()
    {
        Debug.Log("Craft item clicked");
    }
}
