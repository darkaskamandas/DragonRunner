//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentContextApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class ConfigContext {

    public ConfigEntity maxJumpCountEntity { get { return GetGroup(ConfigMatcher.MaxJumpCount).GetSingleEntity(); } }
    public MaxJumpCountComponent maxJumpCount { get { return maxJumpCountEntity.maxJumpCount; } }
    public bool hasMaxJumpCount { get { return maxJumpCountEntity != null; } }

    public ConfigEntity SetMaxJumpCount(int newValue) {
        if (hasMaxJumpCount) {
            throw new Entitas.EntitasException("Could not set MaxJumpCount!\n" + this + " already has an entity with MaxJumpCountComponent!",
                "You should check if the context already has a maxJumpCountEntity before setting it or use context.ReplaceMaxJumpCount().");
        }
        var entity = CreateEntity();
        entity.AddMaxJumpCount(newValue);
        return entity;
    }

    public void ReplaceMaxJumpCount(int newValue) {
        var entity = maxJumpCountEntity;
        if (entity == null) {
            entity = SetMaxJumpCount(newValue);
        } else {
            entity.ReplaceMaxJumpCount(newValue);
        }
    }

    public void RemoveMaxJumpCount() {
        maxJumpCountEntity.Destroy();
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

    public MaxJumpCountComponent maxJumpCount { get { return (MaxJumpCountComponent)GetComponent(ConfigComponentsLookup.MaxJumpCount); } }
    public bool hasMaxJumpCount { get { return HasComponent(ConfigComponentsLookup.MaxJumpCount); } }

    public void AddMaxJumpCount(int newValue) {
        var index = ConfigComponentsLookup.MaxJumpCount;
        var component = CreateComponent<MaxJumpCountComponent>(index);
        component.Value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceMaxJumpCount(int newValue) {
        var index = ConfigComponentsLookup.MaxJumpCount;
        var component = CreateComponent<MaxJumpCountComponent>(index);
        component.Value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveMaxJumpCount() {
        RemoveComponent(ConfigComponentsLookup.MaxJumpCount);
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

    static Entitas.IMatcher<ConfigEntity> _matcherMaxJumpCount;

    public static Entitas.IMatcher<ConfigEntity> MaxJumpCount {
        get {
            if (_matcherMaxJumpCount == null) {
                var matcher = (Entitas.Matcher<ConfigEntity>)Entitas.Matcher<ConfigEntity>.AllOf(ConfigComponentsLookup.MaxJumpCount);
                matcher.componentNames = ConfigComponentsLookup.componentNames;
                _matcherMaxJumpCount = matcher;
            }

            return _matcherMaxJumpCount;
        }
    }
}