using Content.Server.Power.Components;
using Content.Server.Power.EntitySystems;
using Content.Server.Shuttles.Components;
using Content.Shared.Power;

namespace Content.Server.Shuttles.Systems;

public sealed class FTLDriveSystem : EntitySystem
{
    [Dependency] private readonly PowerReceiverSystem _powerReceiverSystem = default!;

    public override void Initialize()
    {
        base.Initialize();

        SubscribeLocalEvent<FTLDriveComponent, ComponentStartup>(OnStartup);
        SubscribeLocalEvent<FTLDriveComponent, PowerChangedEvent>(OnPowerChanged);
    }

    private void OnStartup(EntityUid uid, FTLDriveComponent component, ComponentStartup args)
    {
        // Set initial power state
        if (TryComp<ApcPowerReceiverComponent>(uid, out var powerReceiver))
        {
            component.Powered = powerReceiver.Powered;
        }
    }

    private void OnPowerChanged(EntityUid uid, FTLDriveComponent component, ref PowerChangedEvent args)
    {
        component.Powered = args.Powered;
    }
}
