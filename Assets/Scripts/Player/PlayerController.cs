using UnityEditor.Animations;
using UnityEngine;
using UnityEngine.InputSystem;
using Unity.Services.Analytics;
using Unity.Services.Core;
using Unity.Services.Core.Environments;
using System;
using Event = Unity.Services.Analytics.Event;

public class MyEvent : Event
{
    public MyEvent() : base("myEvent")
    {
    }

    public string FabulousString { set { SetParameter("fabulousString", value); } }
    public int SparklingInt { set { SetParameter("sparklingInt", value); } }
    public float SpectacularFloat { set { SetParameter("spectacularFloat", value); } }
    public bool PeculiarBool { set { SetParameter("peculiarBool", value); } }
}

public class PlayerController : MonoBehaviour
{
    [Header("Movement")]
    [SerializeField] float moveSpeed = 5f;
    [SerializeField] float dashForce = 5f;

    [Header("Projectiles")]
    [SerializeField] GameObject projectile; 

    private Rigidbody2D MyRigidbody2D => GetComponent<Rigidbody2D>();

    private PlayerControls PlayerControls;

    private IPlayerUseCaseInterface playerUseCase;

    private void Awake() {
        PlayerControls = new PlayerControls();
        PlayerControls.Player.Enable();
        PlayerControls.Player.Jump.performed += Jump;
        PlayerControls.Player.Fire.performed += Fire;
        PlayerControls.Player.Dash.performed += Dash;

        playerUseCase = new PlayerUseCase(moveSpeed: moveSpeed);
    }

    private void Update() 
    {
        Move();

        if (Input.GetKeyDown(KeyCode.E)) 
        {
            RecordCustomEvent();
        }
    }

    private void RecordCustomEvent() 
    {
        Debug.Log("Record custom event");

        MyEvent myEvent = new MyEvent();

        AnalyticsService.Instance.RecordEvent(myEvent);
    }

    async void Start()
    {
        // TODO: Should be on the game start
        var options = new InitializationOptions();

        options.SetEnvironmentName("staging");
        await UnityServices.InitializeAsync(options);

        AnalyticsService.Instance.StartDataCollection();
    }

    void Move() {
        Vector2 inputVector = PlayerControls.Player.Movement.ReadValue<Vector2>();
        Vector2 movementVector = playerUseCase.CalculateMovement(inputVector: inputVector);

        MyRigidbody2D.AddForce(movementVector, ForceMode2D.Force);
    }

    void Jump(InputAction.CallbackContext context) 
    {
        if (context.performed) 
        {
            MyRigidbody2D.AddForce(Vector2.up * 5f, ForceMode2D.Impulse);
        }
    }
    void Fire(InputAction.CallbackContext context) 
    {
        if (context.performed)
        {
            if (playerUseCase.CraftBullet() is FlameBullet flameBullet)
            {
                GameObject prefab = Instantiate(projectile, gameObject.transform.position, Quaternion.identity);
                prefab.GetComponent<ProjectileController>().BuldProjectile(facingDirection: playerUseCase.FacingDir, projectile: flameBullet);
            }
        }
    } 

    void Dash(InputAction.CallbackContext context) 
    {
        if (context.performed)
        {
            MyRigidbody2D.AddForce(playerUseCase.FacingDir * dashForce, ForceMode2D.Impulse);
        }
    }
}
