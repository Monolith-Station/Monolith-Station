using Content.Server.Shuttles.Systems;

namespace Content.Server.Shuttles.Components;

/// <summary>
/// A component that allows a shuttle to engage FTL travel when powered.
/// </summary>
[RegisterComponent, Access(typeof(ShuttleSystem), typeof(FTLDriveSystem))]
public sealed partial class FTLDriveComponent : Component
{
    /// <summary>
    /// Whether the FTL drive is currently powered and operational.
    /// </summary>
    [ViewVariables]
    public bool Powered;
}
