# GameCreator2SoapSupport

## Summary
Adds bindings for GameCreator2 to reference built-in SOAP variable types. 

### Supported types
- `BoolVariable`
- `FloatVariable`
- `IntVariable`
- `StringVariable`
- `Vector2Variable`
- `Vector3Variable`
- `ColorVariable`


### Unsupported types

These require additional types implemented in the GameCreator2SoapSupport project. 

- `QuaternionVariable`
- `GameObjectVariable`
- `TransformVariable`


### Adding a type
To add a new type that GameCreator2 supports, you need to extend these classes, along with the `[Serializable]` attribute:

- Getters
  - `TPropertyTypeGet<T>`
  - `TPropertyGet<TType, TValue>`

- Setters
  - `TPropertyTypeSet<T>`
  - `TPropertySet<TType, TValue>`

These work in pairs, where the `TPropertyTypeGet<T>` and `TPropertyTypeSet<T>` are the type definitions, and the `TPropertyGet<TType, TValue>` and `TPropertySet<TType, TValue>` are the actual implementations that are serialized in the editor.

See `PropertyTypeGetVector2` and `PropertyTypeSetVector2` for an example of a new type.
> Note that GameCreator 2 covers some but not all cases of types. For example, `Vector3` has a `PropertyTypeSetVector3` already, but no equivalent `PropertyTypeGetVector3` defined.  
> There's also some oddities in GameCreator2 where doubles are set using the term `Number`, but their equivalent get is using the term `Decimal`.