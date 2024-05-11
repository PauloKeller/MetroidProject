using UnityEngine;
using UnityEngine.InputSystem;
using Unity.Services.Analytics;
using Unity.Services.Core;
using Unity.Services.Core.Environments;
using System;
using Event = Unity.Services.Analytics.Event;
using Codice.Client.BaseCommands.Merge;

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
    [SerializeField] float moveSpeed = 10f;
    [SerializeField] float dashForce = 5f;
    [SerializeField] float maxSpeed = 200f;

    [Header("Projectiles")]
    [SerializeField] GameObject projectilePrefab; 

    private Rigidbody2D MyRigidbody2D => GetComponent<Rigidbody2D>();

    private PlayerControls PlayerControls;

    private IPlayerUseCaseInterface playerUseCase;

    private void Awake() {
        PlayerControls = new PlayerControls();
        PlayerControls.Player.Enable();
        PlayerControls.Player.Jump.performed += Jump;
        PlayerControls.Player.Fire.performed += FireWeapon;
        PlayerControls.Player.Dash.performed += Dash;

        playerUseCase = new PlayerUseCase(moveSpeed: moveSpeed);
    }

    private void Update() 
    {
        Move();

        ChangeWieldedWeapon();

        ChangeWeaponAmmo();
    }

    private void ChangeWeaponAmmo() 
    {
        if (Input.GetKeyDown(KeyCode.E)) 
        { 
            playerUseCase.ChangeCurrentWeaponAmmunition();
        }
    }

    private void ChangeWieldedWeapon()
    { 

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            playerUseCase.WieldWeapon(WeaponType.MachineGun);
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            playerUseCase.WieldWeapon(WeaponType.Flamethrower);
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            playerUseCase.WieldWeapon(WeaponType.Laser);
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            playerUseCase.WieldWeapon(WeaponType.Cannon);
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

        if (MyRigidbody2D.velocity.magnitude > maxSpeed)
        {
            MyRigidbody2D.velocity = Vector2.ClampMagnitude(MyRigidbody2D.velocity, maxSpeed);
        }

        MyRigidbody2D.AddForce(movementVector, ForceMode2D.Force);   
    }

    void Jump(InputAction.CallbackContext context) 
    {
        if (context.performed) 
        {
            MyRigidbody2D.AddForce(Vector2.up * 5f, ForceMode2D.Impulse);
        }
    }
    void FireWeapon(InputAction.CallbackContext context) 
    {
        if (context.performed)
        {
            GameObject prefab = Instantiate(projectilePrefab, gameObject.transform.position, Quaternion.identity);
            IProjectile projectile = playerUseCase.EquipedWeapon.CurrentProjectile;
            prefab.GetComponent<ProjectileController>().BuldProjectile(facingDirection: playerUseCase.FacingDir, projectile: projectile);
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
