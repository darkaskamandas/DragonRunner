//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentContextApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class ConfigContext {

    public ConfigEntity velocityDecreaseSpeedEntity { get { return GetGroup(ConfigMatcher.VelocityDecreaseSpeed).GetSingleEntity(); } }
    public VelocityDecreaseSpeedComponent velocityDecreaseSpeed { get { return velocityDecreaseSpeedEntity.velocityDecreaseSpeed; } }
    public bool hasVelocityDecreaseSpeed { get { return velocityDecreaseSpeedEntity != null; } }

    public ConfigEntity SetVelocityDecreaseSpeed(float newValue) {
        if (hasVelocityDecreaseSpeed) {
            throw new Entitas.EntitasException("Could not set VelocityDecreaseSpeed!\n" + this + " already has an entity with VelocityDecreaseSpeedComponent!",
                "You should check if the context already has a velocityDecreaseSpeedEntity before setting it or use context.ReplaceVelocityDecreaseSpeed().");
        }
        var entity = CreateEntity();
        entity.AddVelocityDecreaseSpeed(newValue);
        return entity;
    }

    public void ReplaceVelocityDecreaseSpeed(float newValue) {
        var entity = velocityDecreaseSpeedEntity;
        if (entity == null) {
            entity = SetVelocityDecreaseSpeed(newValue);
        } else {
            entity.ReplaceVelocityDecreaseSpeed(newValue);
        }
    }

    public void RemoveVelocityDecreaseSpeed() {
        velocityDecreaseSpeedEntity.Destroy();
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class ConfigEntity {

    public VelocityDecreaseSpeedComponent velocityDecreaseSpeed { get { return (VelocityDecreaseSpeedComponent)GetComponent(ConfigComponentsLookup.VelocityDecreaseSpeed); } }
    public bool hasVelocityDecreaseSpeed { get { return HasComponent(ConfigComponentsLookup.VelocityDecreaseSpeed); } }

    public void AddVelocityDecreaseSpeed(float newValue) {
        var index = ConfigComponentsLookup.VelocityDecreaseSpeed;
        var component = CreateComponent<VelocityDecreaseSpeedComponent>(index);
        component.Value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceVelocityDecreaseSpeed(float newValue) {
        var index = ConfigComponentsLookup.VelocityDecreaseSpeed;
        var component = CreateComponent<VelocityDecreaseSpeedComponent>(index);
        component.Value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveVelocityDecreaseSpeed() {
        RemoveComponent(ConfigComponentsLookup.VelocityDecreaseSpeed);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class ConfigMatcher {

    static Entitas.IMatcher<ConfigEntity> _matcherVelocityDecreaseSpeed;

    public static Entitas.IMatcher<ConfigEntity> VelocityDecreaseSpeed {
        get {
            if (_matcherVelocityDecreaseSpeed == null) {
                var matcher = (Entitas.Matcher<ConfigEntity>)Entitas.Matcher<ConfigEntity>.AllOf(ConfigComponentsLookup.VelocityDecreaseSpeed);
                matcher.componentNames = ConfigComponentsLookup.componentNames;
                _matcherVelocityDecreaseSpeed = matcher;
            }

            return _matcherVelocityDecreaseSpeed;
        }
    }
}
