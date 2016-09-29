# Unity Singleton

A simple implementation of the singleton pattern with consideration for practical real usecases.

## Usage
Simply create your singleton class by inheriting from `SimpleSingleton` and call `CreateInstance` like so:

```
    SoundManager.CreateInstance ();

    ...


    SoundManager.Instance.SomeMethod ();
```

`Instance` property has a very low performance cost because it does not check for null instance, unlike other singleton implementations.

A sample scene is also included.
