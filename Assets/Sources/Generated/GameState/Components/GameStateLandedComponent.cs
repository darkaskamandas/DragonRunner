//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentContextApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameStateContext {

    public GameStateEntity landedEntity { get { return GetGroup(GameStateMatcher.Landed).GetSingleEntity(); } }

    public bool isLanded {
        get { return landedEntity != null; }
        set {
            var entity = landedEntity;
            if (value != (entity != null)) {
                if (value) {
                    CreateEntity().isLanded = true;
                } else {
                    entity.Destroy();
                }
            }
        }
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
public partial class GameStateEntity {

    static readonly LandedComponent landedComponent = new LandedComponent();

    public bool isLanded {
        get { return HasComponent(GameStateComponentsLookup.Landed); }
        set {
            if (value != isLanded) {
                var index = GameStateComponentsLookup.Landed;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : landedComponent;

                    AddComponent(index, component);
                } else {
                    RemoveComponent(index);
                }
            }
        }
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
public sealed partial class GameStateMatcher {

    static Entitas.IMatcher<GameStateEntity> _matcherLanded;

    public static Entitas.IMatcher<GameStateEntity> Landed {
        get {
            if (_matcherLanded == null) {
                var matcher = (Entitas.Matcher<GameStateEntity>)Entitas.Matcher<GameStateEntity>.AllOf(GameStateComponentsLookup.Landed);
                matcher.componentNames = GameStateComponentsLookup.componentNames;
                _matcherLanded = matcher;
            }

            return _matcherLanded;
        }
    }
}
