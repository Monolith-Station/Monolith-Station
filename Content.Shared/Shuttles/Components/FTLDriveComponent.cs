using Robust.Shared.GameStates;

namespace Content.Shared.Shuttles.Components;

/// <summary>
/// A component that allows a shuttle to engage FTL travel when powered.
/// </summary>
[RegisterComponent]
[NetworkedComponent]
[AutoGenerateComponentState]
public sealed partial class FTLDriveComponent : Component
{
    /// <summary>
    /// Whether the FTL drive is currently powered and operational.
    /// </summary>
    [ViewVariables(VVAccess.ReadWrite)]
    [DataField("powered")]
    [AutoNetworkedField]
    public bool Powered = true;

    /// <summary>
    /// The maximum FTL range this drive can achieve when powered.
    /// </summary>
    [ViewVariables(VVAccess.ReadWrite)]
    [DataField("range")]
    [AutoNetworkedField]
    public float Range = 256f;
}
